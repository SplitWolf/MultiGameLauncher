using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Multi_Game_Launcher
{
    public class GameData
    {
        
        private List<string> games = new List<string>();
        private List<bool> hasFileExt = new List<bool>();
        private List<string> process = new List<string>();
        private List<string> MLN = new List<string>();

        /// <summary>
        /// Adds a game to the game list
        /// </summary>
        /// <param name="name">Name of the game to add</param>
        /// <param name="Procces">Where is the storge file located or What is the procces to start</param>
        /// <param name="hasFile">Does the game have a storage file</param>
        /// <param name="MultiLauncherName">Name of multi launcher program if applicable (steam/origin/other)</param>
        public void AddGame (string name, string Process, bool hasFile = true, string MultiLauncherName = null)
        {
            games.Add(name);
            hasFileExt.Add(hasFile);
            process.Add(Process);
            MLN.Add(MultiLauncherName);
        }

        //Runs on Program Exit, Determines Weather the Program Should Minimize or Exit When A Application Is Started.
        void ExitMode(Form form)
        {
            string state = "mgl";



            if (File.Exists(Path.Combine(Functions.mgldir, @"switch.dat")))
            {
                state = File.ReadAllText(Path.Combine(Functions.mgldir, @"switch.dat"));
            }

            if (state.Equals("m"))
            {
                form.WindowState = FormWindowState.Minimized;
            }
            else
            {
                form.Close();
            }

        }

        /// <summary>
        /// Starts the game with the given name if game if regisitered in the arrays
        /// </summary>
        /// <param name="GameName">Name of game to start</param>
        /// <param name="form">The main form</param>
        public void StartGame (string GameName, Form form)
        {
            int index = -1;
            string[] gamesArray = games.ToArray();
            bool[] hasFileArray = hasFileExt.ToArray();
            string[] processArray = process.ToArray();
            string[] mlnameArray = MLN.ToArray();

            for (int i = 0; i < gamesArray.Length; i++)
            {
                if (gamesArray[i] == GameName)
                {
                    index = i; break;
                }
            }

            if (index != -1)
            {
                string process = processArray[index];
                bool hasFile = hasFileArray[index];

                string mln = mlnameArray[index];
                
                if(File.Exists(Functions.mgldir+process))
                {
                    process = File.ReadAllText(Functions.mgldir+process);
                }
                Console.WriteLine(process);
                Process p = new Process();
                p.StartInfo.FileName = process;

                try
                {
                    p.Start();
                    ExitMode(form);
                }
                catch (Win32Exception)
                {
                    if(hasFile)
                    {
                        MessageBox.Show("Please change the location of the " + GameName + " executable in options or Install it", "Multi-Game Launcher", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Please Install" + mln + "From: \n\n" + mln + "'s website", "Multi-Game Launcher", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Select a Game To Launch", "Multi-Game Launcher", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
    }
}
