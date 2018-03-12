using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using SharpUpdate;
using System.Reflection;

namespace Multi_Game_Launcher
{
    public partial class LauncherWindow : Form, ISharpUpdatable
    {

        private SharpUpdater updater;
        private Uri xmlLocation;

        //Initalize Main Window
        public LauncherWindow(string[] args)
        {
            InitializeComponent();

            #region Init
            Custom_Functions.CreateFiles();
            #endregion

                try
                {
                    MessageBox.Show(string.Format("Updated to {0}", args[0]), "Multi-Game Launcher", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {

                }

            updater = new SharpUpdater(this);
            updater.DoUpdate();
        }

        #region SharpUpdate

        public string ApplicationName
        {
            get { return "Multi-Game Launcher"; }
        }

        public string ApplicationID
        {
            get { return "MultiGameLauncher"; }
        }

        public Uri UpdateXmlLocation
        {
            get { return new Uri("https://raw.githubusercontent.com/MWolf88/MultiGameLauncher/master/project.xml"); }
        }

        public Assembly ApplicationAssembly
        {
            get { return Assembly.GetExecutingAssembly(); }
        }

        public Icon ApplicationIcon
        {
            get { return this.Icon; }
        }


        public Form Context
        {
            get { return this; }
        }
        #endregion

        //Runs on Program Exit, Determines Weather the Program Should Minimize or Exit When A Application Is Started.
        void ExitMode()
        {
            string state = "mgl";

            if (File.Exists(Path.Combine(Custom_Functions.mgldir, @"switch.dat")))
            {
                state = File.ReadAllText(Path.Combine(Custom_Functions.mgldir, @"switch.dat"));
            }

            if (state.Equals("m"))
            {
                WindowState = FormWindowState.Minimized;
            }
            else
            {
                Close();
            }

        }

        //Game Vars
        public string Game;
        public int GameInt = 8;
        public bool MakeFiles;


    #region WindowEventHandler

        //Mouse Tracking Vars For move window.
        private bool _dragging = false;
        private Point _sart_point = new Point(0, 0);

        //Window Move Event Handler's
        private void MoveWindow_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _sart_point = new Point(e.X, e.Y);
        }
        private void MoveWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._sart_point.X, p.Y - this._sart_point.Y);
            }

        }
        private void MoveWindow_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        //Window Change Event (Exit, Minimize)
        private void QuitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Minimize_Click(object sender, EventArgs e)
        {
                WindowState = FormWindowState.Minimized;
        }
        #endregion

    #region Select Game Events
        // Click Select Game Events
        private void MC_Click(object sender, EventArgs e)
        {
            Game = "Minecraft";
            SelGame.Text = Game.ToString();
            GameInt = 1;
        }
        private void RL_Click(object sender, EventArgs e)
        {
            Game = "Rocket Leauge";
            SelGame.Text = Game.ToString();
            GameInt = 2;
        }
        private void CSGO_Click(object sender, EventArgs e)
        {
            Game = "CS:GO";
            SelGame.Text = Game.ToString();
            GameInt = 3;
        }
        private void LOL_Click(object sender, EventArgs e)
        {
            Game = "Leauge OF Legends";
            SelGame.Text = Game.ToString();
            GameInt = 4;
        }
        private void ScrapMech_Click(object sender, EventArgs e)
        {
            Game = "Scrap Mechanic";
            SelGame.Text = Game.ToString();
            GameInt = 5;
        }
        private void Unturned_Click(object sender, EventArgs e)
        {
            Game = "Unturned";
            SelGame.Text = Game.ToString();
            GameInt = 6;
        }
        private void Factorio_Click(object sender, EventArgs e)
        {
            Game = "Factorio";
            SelGame.Text = Game.ToString();
            GameInt = 7;
        }
    #endregion

        //Open Options Form When Options Button Clicked
        private void OptionsBtn_Click(object sender, EventArgs e)
        {
            Hide();
            Options OForm = new Options();
            OForm.ShowDialog();
            Show();
        }

        //Play Selected Game On Play Button Click
        private void PlayBtn_Click(object sender, EventArgs e)
        {
            string App = "h";

            switch (GameInt)
            {
                case 1:

                    App = File.ReadAllText(Path.Combine(Custom_Functions.mgldir, @"mcexe.dat"));
                    try
                    {
                        Process.Start(App);
                    }
                    catch (Win32Exception)
                    {
                        MessageBox.Show("Please change the location of the Minecraft executable in Options or Install it", "Multi-Game Launcher", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    ExitMode();
                    break; 
                case 2:
                    try
                    {
                        Process.Start("steam://rungameid/252950");
                    }
                    catch (Win32Exception)
                    {
                        MessageBox.Show("Please Install Steam From: \n\n store.steampowered.com", "Multi-Game Launcher", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    ExitMode();
                    break;
                case 3:
                    try
                    {
                        Process.Start("steam://rungameid/730");
                    }
                    catch (Win32Exception)
                    {
                        MessageBox.Show("Please Install Steam From: \n\n store.steampowered.com", "Multi-Game Launcher", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    ExitMode();
                    break;
                case 4:
                     App = File.ReadAllText(Path.Combine(Custom_Functions.mgldir, @"lolexe.dat"));
                    try
                    {
                        Process.Start(App);
                    }
                    catch (Win32Exception)
                    {
                        MessageBox.Show("Please change the location of the League of Legends executable in Options or Install it", "Multi-Game Launcher", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    ExitMode();
                    break;
                case 5:
                    try
                    {
                        Process.Start("steam://rungameid/387990");
                    }
                    catch (Win32Exception)
                    {
                        MessageBox.Show("Please Install Steam From: \n\n store.steampowered.com", "Multi-Game Launcher", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    break;
                case 6:
                    try
                    {
                        Process.Start("steam://rungameid/304930");
                    }
                    catch (Win32Exception)
                    {
                        MessageBox.Show("Please Install Steam From: \n\n store.steampowered.com", "Multi-Game Launcher", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    ExitMode();
                    break;
                case 7:
                    App = File.ReadAllText(Path.Combine(Custom_Functions.mgldir, @"factorioexe.dat"));
                    try
                    {
                        Process.Start(App);
                    }
                    catch (Win32Exception)
                    {
                        MessageBox.Show("Please Change The Factorio Executeable Location In Options or Install it", "Multi-Game Launcher", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case 8:
                    MessageBox.Show("Please Select a Game To Launch", "Multi-Game Launcher", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }
    }
}
