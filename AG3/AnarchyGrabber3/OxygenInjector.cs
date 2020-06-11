using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace yikes
{
    public class OxygenInjector
    {
        public static bool Inject(DiscordBuild build, string dirName, string indexFile, string prependJS, params OxygenFile[] files)
        {
            if (!TryGetDiscordPath(build, out string path))
                return false;

            try
            {
                DirectoryInfo epicDir = Directory.CreateDirectory($"{path}/{dirName}");

                File.WriteAllText(path + "/index.js", $@"
{prependJS}
process.env.modDir = '{epicDir.FullName.Replace("\\", "\\\\")}'
require(process.env.modDir + '\\inject')
module.exports = require('./core.asar');");

                foreach (var file in files)
                    File.WriteAllText($"{epicDir.FullName}/{file.Path}", file.Contents);

                return true;
            }
            catch
            {
                return false;
            }
        }


        public static bool TryGetDiscordPath(DiscordBuild build, out string path)
        {
            try
            {
                path = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + $"\\{BuildToString(build)}").GetDirectories()
                    .First(d => Regex.IsMatch(d.Name, @"\d.\d.\d{2}(\d|$)"))
                    .GetDirectories().First(d => d.Name == "modules")
                    .GetDirectories().First(d => d.Name == "discord_desktop_core").FullName;

                return true;
            }
            catch
            {
                path = null;
                return false;
            }
        }


        private static string BuildToString(DiscordBuild build)
        {
            return build.ToString().ToLower();
        }
    }
}
