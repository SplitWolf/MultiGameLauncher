using System;
using System.IO;
using System.Windows.Forms;

namespace Multi_Game_Launcher
{
    public partial class Options : Form
    {

        private bool switchstate = false;
        private Functions func = new Functions();

        public Options()
        {
            InitializeComponent();
#region Intit
            string state;
            TextBox[] t1 = new TextBox[3];
            t1.SetValue(OptionsFileLoctextBox1, 0);
            t1.SetValue(OptionsFileLoctextBox2, 1);
            t1.SetValue(OptionsFileLoctextBox3, 2);
            // t1.SetValue(OptionsFileLoctextBox4, 3);
            string[] s1 = new string[3];
            s1.SetValue(func.mgldir + @"mcexe.dat", 0);
            s1.SetValue(func.mgldir + @"lolexe.dat", 1);
            s1.SetValue(func.mgldir + @"factorioexe.dat", 2);
            //s1.SetValue(func.mgldir + @"fortniteexe.dat", 3);

            Refill(t1, s1, Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), @"Minecraft\MinecraftLauncher.exe"), @"C:\Riot Games\League of Legends\LeagueClient.exe", null);

            if (File.Exists(Path.Combine(func.mgldir, @"\switch.dat")))
            {
                state = File.ReadAllText(Path.Combine(func.mgldir, @"\switch.dat"));

                if (state.Equals("e"))
                {
                    switchstate = false;
                }
                else
                {
                    switchstate = true;
                }
            }

            if (switchstate == false)
            {
                SwitchLabel.Text = "Exit";
            }
            else
            {
                SwitchLabel.Text = "Minimize";
            }

#endregion

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SwitchLabel_Click(object sender, EventArgs e)
        {
            if (switchstate == false)
            {
                switchstate = true;
                SwitchLabel.Text = "Minimize";
                File.WriteAllText(Path.Combine(func.mgldir, @"switch.dat"), "m");
            }
            else
            {
                switchstate = false;
                SwitchLabel.Text = "Exit";
                File.WriteAllText(Path.Combine(func.mgldir, @"switch.dat"), "e");
            }
        }

        private void BrowseBtn1_Click(object sender, EventArgs e)
        {
            OFileDialog(
                "Minecraft executable|minecraft.exe; MinecraftLauncher.exe",
                func.mgldir,
                Path.Combine(func.mgldir, @"mcexe.dat"),
                "MinecraftLauncher.exe",
                OptionsFileLoctextBox1
            );
        }

        private void BrowseBtn2_Click(object sender, EventArgs e)
        {
            OFileDialog(
               "League of Legeneds Executable|LeagueClient.exe",
               func.mgldir,
               Path.Combine(func.mgldir, @"lolexe.dat"),
               "LeagueClient.exe",
               OptionsFileLoctextBox2
           );
        }

        private void BrowseBtn3_Click(object sender, EventArgs e)
        {
            OFileDialog(
               "Factorio Executable|factorio.exe",
               func.mgldir,
               Path.Combine(func.mgldir, @"factorioexe.dat"),
               "Factorio.exe",
               OptionsFileLoctextBox3
               );
        }

        private void BrowseBtn4_Click(object sender, EventArgs e)
        {

        }

        #region Custom func


        /// <summary>
        /// Replace Textbox text on Form Open
        /// </summary>
        /// <param name="textBoxes">Array of textboxes on Form</param>
        /// <param name="fileloc">Array of file locations</param>
        /// <param name="defualtloc">Array of default locations</param>
        public static void Refill(TextBox[] textBoxes, string[] fileloc, params string[] defualtloc)
        {
 

            for (int i = 0; i < textBoxes.Length; i++)
            {
                if (File.Exists(fileloc[i]))
                {
                    textBoxes[i].Text = File.ReadAllText(fileloc[i]);
                }
                else
                {
                    if (defualtloc != null)
                    {
                        textBoxes[i].Text = defualtloc[i];
                    }
                    else
                    {
                        return;
                    }
                }
                textBoxes[i].TabStop = false;
            }

        }

        /// <summary>
        /// Create Browse Dialog
        /// </summary>
        /// <param name="Filterargs"></param>
        /// <param name="dirpath"></param>
        /// <param name="filepath"></param>
        /// <param name="textbox"></param>
        public void OFileDialog(string Filterargs,string dirpath, string filepath, string exename, TextBox textbox)
        {
            string textforfile;

            OpenFileDialog ofd = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Find Exe of Application",
                DefaultExt = "exe",
                Multiselect = false
            };

            Reshow:

            ofd.Filter = Filterargs;
            
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textforfile = ofd.FileName;
                if (Path.GetExtension(ofd.FileName) != ".exe")
                {
                    MessageBox.Show("Invalid File", "Multi-Game Launcher", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    ofd.Reset();
                    goto Reshow;
                }
                else
                {
                    textbox.Text = ofd.FileName;
                    func.CreateFile(dirpath, filepath, textforfile);
                    ofd.Reset();
                }
            }
        }


        #endregion
    }
}
