using System;
using System.IO;
using System.Windows.Forms;

namespace Multi_Game_Launcher
{
    public partial class Options : Form
    {

        public bool switchstate = false;

        public Options()
        {
            InitializeComponent();
#region Intit
            string state;

            Refill(OptionsFileLoctextBox1, OptionsFileLoctextBox2, OptionsFileLoctextBox3);

            if (File.Exists(Path.Combine(Custom_Functions.mgldir, @"\switch.dat")))
            {
                state = File.ReadAllText(Path.Combine(Custom_Functions.mgldir, @"\switch.dat"));

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
                File.WriteAllText(Path.Combine(Custom_Functions.mgldir, @"switch.dat"), "m");
            }
            else
            {
                switchstate = false;
                SwitchLabel.Text = "Exit";
                File.WriteAllText(Path.Combine(Custom_Functions.mgldir, @"switch.dat"), "e");
            }
        }

        private void BrowseBtn1_Click(object sender, EventArgs e)
        {
            OFileDialog(
                "Minecraft executable|minecraft.exe; MinecraftLauncher.exe",
                Custom_Functions.mgldir,
                Path.Combine(Custom_Functions.mgldir, @"mcexe.dat"),
                "MinecraftLauncher.exe",
                OptionsFileLoctextBox1
            );
        }

        private void BrowseBtn2_Click(object sender, EventArgs e)
        {
            OFileDialog(
               "League of Legeneds Executable|LeagueClient.exe",
               Custom_Functions.mgldir,
               Path.Combine(Custom_Functions.mgldir, @"lolexe.dat"),
               "LeagueClient.exe",
               OptionsFileLoctextBox2
           );
        }

        private void BrowseBtn3_Click(object sender, EventArgs e)
        {
            OFileDialog(
               "Factorio Executable|factorio.exe",
               Custom_Functions.mgldir,
               Path.Combine(Custom_Functions.mgldir, @"factorioexe.dat"),
               "Factorio.exe",
               OptionsFileLoctextBox3
               );
        }

        #region Custom Functions

        /// <summary>
        /// Replace Textbox text on Form Open
        /// </summary>
        /// <param name="TextBox 1"></param>
        /// <param name="TextBox 2"></param>
        /// <param name="TextBox 3"></param>
        public static void Refill(TextBox t1, TextBox t2, TextBox t3)
        {
            string write;

            if (File.Exists(Custom_Functions.mgldir + @"mcexe.dat"))
            {
                write = File.ReadAllText(Path.Combine(Custom_Functions.mgldir, @"mcexe.dat"));
                t1.Text = write;
            }
            else
            {
                write = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), @"Minecraft\MinecraftLauncher.exe");
                Custom_Functions.CreateFile(Custom_Functions.mgldir, Path.Combine(Custom_Functions.mgldir, @"mcexe.dat"),write);
                t1.Text = write;
            }

            if (File.Exists(Custom_Functions.mgldir + "lolexe.dat"))
            {
                write = File.ReadAllText(Custom_Functions.mgldir + "lolexe.dat");
                t2.Text = write;
            }
            else
            {
                write = Path.Combine(@"C:\Riot Games\League of Legends\LeagueClient.exe");
                Custom_Functions.CreateFile(Custom_Functions.mgldir, Path.Combine(Custom_Functions.mgldir, @"lolexe.dat"), write);
                t2.Text = write;
            }

            if (File.Exists(Custom_Functions.mgldir + "factorioexe.dat"))
            {
                write = File.ReadAllText(Custom_Functions.mgldir + "factorioexe.dat");
                t3.Text = write;
            }
            else
            {
                return;
            }

            t1.TabStop = false;
            t2.TabStop = false;
            t3.TabStop = false;
        }

        /// <summary>
        /// Create Browse Dialog
        /// </summary>
        /// <param name="Filterargs"></param>
        /// <param name="dirpath"></param>
        /// <param name="filepath"></param>
        /// <param name="textbox"></param>
        public static void OFileDialog(string Filterargs,string dirpath, string filepath, string exename, TextBox textbox)
        {
            string textforfile;

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\";
            ofd.Title = "Find Exe of Application";
            ofd.DefaultExt = "exe";
            ofd.Multiselect = false;

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
                    Custom_Functions.CreateFile(dirpath, filepath, textforfile);
                    ofd.Reset();
                }
            }
        }

        #endregion


    }
}
