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
        private GameData gameData;
        /// <summary>
        /// Sharp updater var
        /// </summary>
        private SharpUpdater updater;
        /// <summary>
        /// Uri location for Sharp Updater
        /// </summary>
        private Uri xmlLocation = new Uri("https://raw.githubusercontent.com/MWolf88/MultiGameLauncher/master/project.xml");

        //Initalize Main Window
        public LauncherWindow(string[] args)
        {
            InitializeComponent();
            gameData = new GameData();

            #region Init
            Functions.CreateFiles();
            gameData.AddGame("Minecraft", "mcexe.dat");
            gameData.AddGame("Rocket League", "steam://rungameid/252950", false, "Steam");
            gameData.AddGame("CS:GO", "steam://rungameid/730", false, "Steam");
            gameData.AddGame("League OF Legends", "lolexe.dat");
            gameData.AddGame("Scrap Mechanic", "steam://rungameid/387990", false, "Steam");
            gameData.AddGame("Unturned", "steam://rungameid/304930", false, "Steam");
            gameData.AddGame("Factorio", "factorioexe.dat");
            gameData.AddGame("Fortnite", "fortniteexe.dat");
            #endregion


            // If launched with args (from sharp updater) say Updated to that version
            try
            {
                MessageBox.Show(string.Format("Updated to {0}", args[0]), "Multi-Game Launcher", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {

            }

            //Sharp update check for updates
            updater = new SharpUpdater(this);
            updater.DoUpdate();
        }

        /// <summary>
        /// Sharp update config
        /// </summary>
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
            get { return xmlLocation; }
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

        public Uri XmlLocation { get => xmlLocation; set => xmlLocation = value; }
        public Uri XmlLocation1 { get => xmlLocation; set => xmlLocation = value; }
        #endregion

        //Game Vars
        public string Game;
        public int GameInt = 8;
        public bool MakeFiles;

        /// <summary>
        /// Handles window movement, QuitBtn and MinimizeBtn
        /// </summary>
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
        }
        private void RL_Click(object sender, EventArgs e)
        {
            Game = "Rocket League";
            SelGame.Text = Game.ToString();
        }
        private void CSGO_Click(object sender, EventArgs e)
        {
            Game = "CS:GO";
            SelGame.Text = Game.ToString();
        }
        private void LOL_Click(object sender, EventArgs e)
        {
            Game = "League OF Legends";
            SelGame.Text = Game.ToString();
        }
        private void ScrapMech_Click(object sender, EventArgs e)
        {
            Game = "Scrap Mechanic";
            SelGame.Text = Game.ToString();
        }
        private void Unturned_Click(object sender, EventArgs e)
        {
            Game = "Unturned";
            SelGame.Text = Game.ToString();
        }
        private void Factorio_Click(object sender, EventArgs e)
        {
            Game = "Factorio";
            SelGame.Text = Game.ToString();
        }
        private void Fornite_Click(object sender, EventArgs e)
        {
            Game = "Fortnite";
            SelGame.Text = Game.ToString();
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
            gameData.StartGame(SelGame.Text, this);
        }
    }
}
