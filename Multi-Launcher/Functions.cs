using System;
using System.IO;
using System.Text;

namespace Multi_Game_Launcher
{
    public class Functions
    {
        //File to store Custom Functions useable throughout the application
        public string mgldir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"mgl\");

        /// <summary>
        /// Create Game Location Files to Prevent Crash
        /// </summary>
        public void CreateFiles()
        {
            string write;

            if (!File.Exists(Path.Combine(mgldir, @"mcexe.dat")))
            {
                write = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), @"Minecraft\MinecraftLauncher.exe");
                CreateFile(mgldir, Path.Combine(mgldir, @"mcexe.dat"), write);
            }

            if (!File.Exists(Path.Combine(mgldir, @"lolexe.dat")))
            {
                write = @"C:\Riot Games\League of Legends\LeagueClient.exe";
                CreateFile(mgldir, Path.Combine(mgldir, @"lolexe.dat"), write);
            }

            if (!File.Exists(Path.Combine(mgldir, @"factorioexe.dat")))
            {
                write = ".";
                CreateFile(mgldir, Path.Combine(mgldir, @"factorioexe.dat"), write);
            }
        }

        /// <summary>
        /// Create the File to store Application Locations
        /// </summary>
        /// <param name="dirpath"></param>
        /// <param name="filepath"></param>
        /// <param name="text"></param>
        public void CreateFile(string dirpath, string filepath, string text)
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
