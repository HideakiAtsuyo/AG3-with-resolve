using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace AnarchyGrabber_Remover
{
	// Token: 0x02000002 RID: 2
	internal class Program
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		private static void Main(string[] args)
		{
			Console.Title = "Anarchy Remover";
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write("\r\n                               _             _____                                    \r\n    /\\                        | |           |  __ \\                                   \r\n   /  \\   _ __   __ _ _ __ ___| |__  _   _  | |__) |___ _ __ ___   _____   _____ _ __ \r\n  / /\\ \\ | '_ \\ / _` | '__/ __| '_ \\| | | | |  _  // _ \\ '_ ` _ \\ / _ \\ \\ / / _ \\ '__|\r\n / ____ \\| | | | (_| | | | (__| | | | |_| | | | \\ \\  __/ | | | | | (_) \\ V /  __/ |   \r\n/_/    \\_\\_| |_|\\__,_|_|  \\___|_| |_|\\__, | |_|  \\_\\___|_| |_| |_|\\___/ \\_/ \\___|_|   \r\n                                      __/ |                                           \r\n                                     |___/    \r\n");
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("[ CHECKING ] Checking If Someone Injected Anarchy Grabber..");
			bool flag = Directory.Exists("C:\\Users\\" + Environment.UserName + "\\AppData\\Roaming\\discord\\0.0.306\\modules\\discord_desktop_core\\4n4rchy");
			if (flag)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("[ FOUND ] It seems your discord injected with anarchygrabber, dont worry we are removing the grabber ..");
				try
				{
					foreach (Process process in Process.GetProcessesByName("Discord"))
					{
						process.Kill();
					}
				}
				catch
				{
				}
				Thread.Sleep(1000);
				Directory.Delete("C:\\Users\\" + Environment.UserName + "\\AppData\\Roaming\\discord\\0.0.306\\modules\\discord_desktop_core\\4n4rchy", true);
				File.WriteAllText("C:\\Users\\" + Environment.UserName + "\\AppData\\Roaming\\discord\\0.0.306\\modules\\discord_desktop_core\\index.js", "module.exports = require('./core.asar');");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("[ DONE ] Done, successfully removed the grabber, but you should change your password right now !");
				Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\Windows\\Start Menu\\Programs\\Discord Inc\\Discord.lnk");
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("[ NOT FOUND ] You are safe anarchygrabber not injected in your discord !");
			}
			Console.ResetColor();
			Console.WriteLine("Press Any Key To Exit ..");
			Console.ReadKey();
		}
	}
}
