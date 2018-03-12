using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Game_Launcher
{
    public class Custom_Functions
    {
        //File to store Custom Functions useable throughout the application
        public static string mgldir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"mgl\");

        /// <summary>
        /// Create Game Location Files to Prevent Crash
        /// </summary>
        public static void CreateFiles()
        {
            string write;

            write = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), @"Minecraft\MinecraftLauncher.exe");
            CreateFile(mgldir, Path.Combine(mgldir, @"mcexe.dat"), write);

            write = @"C:\Riot Games\League of Legends\LeagueClient.exe";
            CreateFile(mgldir, Path.Combine(mgldir, @"lolexe.dat"), write);

            write = "h";
            CreateFile(mgldir, Path.Combine(mgldir, @"factorioexe.dat"), write);
        }

        /// <summary>
        /// Create the File to store Application Locations
        /// </summary>
        /// <param name="dirpath"></param>
        /// <param name="filepath"></param>
        /// <param name="text"></param>
        public static void CreateFile(string dirpath, string filepath, string text)
        {
            if (!File.Exists(filepath))
            {
                System.IO.Directory.CreateDirectory(dirpath);
                using (FileStream fs = File.Create(filepath))
                {
                    Byte[] info = new UTF8Encoding(true).GetBytes("");
                    // Add some information to the file.
                    fs.Write(info, 0, info.Length);
                }

            }
            else
            {
                File.WriteAllText(filepath, text);
            }
        }
    }
}
