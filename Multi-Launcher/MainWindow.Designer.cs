namespace Multi_Game_Launcher
{
    partial class LauncherWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LauncherWindow));
            this.QuitBtn = new System.Windows.Forms.Button();
            this.PlayBtn = new System.Windows.Forms.Button();
            this.OptionsBtn = new System.Windows.Forms.Button();
            this.CurrSelGameText = new System.Windows.Forms.Label();
            this.SelGame = new System.Windows.Forms.Label();
            this.MovePanel = new System.Windows.Forms.Panel();
            this.MGL2 = new System.Windows.Forms.PictureBox();
            this.MGL1 = new System.Windows.Forms.PictureBox();
            this.Minimize = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.MCTEXT = new System.Windows.Forms.Label();
            this.RLTEXT = new System.Windows.Forms.Label();
            this.CSGOTEXT = new System.Windows.Forms.Label();
            this.SCRAPMECHTEXT = new System.Windows.Forms.Label();
            this.UNTURNEDIMG = new System.Windows.Forms.PictureBox();
            this.ScrapMechIMG = new System.Windows.Forms.PictureBox();
            this.LOLIMG = new System.Windows.Forms.PictureBox();
            this.GSGOIMG = new System.Windows.Forms.PictureBox();
            this.RLIMG = new System.Windows.Forms.PictureBox();
            this.MCIMG = new System.Windows.Forms.PictureBox();
            this.LOLTEXT = new System.Windows.Forms.Label();
            this.UnturnedTEXT = new System.Windows.Forms.Label();
            this.FactorioTEXT = new System.Windows.Forms.Label();
            this.FactorioIMG = new System.Windows.Forms.PictureBox();
            this.MovePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MGL2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MGL1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UNTURNEDIMG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScrapMechIMG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LOLIMG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GSGOIMG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RLIMG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MCIMG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FactorioIMG)).BeginInit();
            this.SuspendLayout();
            // 
            // QuitBtn
            // 
            this.QuitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.QuitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.QuitBtn.Location = new System.Drawing.Point(12, 468);
            this.QuitBtn.Name = "QuitBtn";
            this.QuitBtn.Size = new System.Drawing.Size(114, 46);
            this.QuitBtn.TabIndex = 0;
            this.QuitBtn.Text = "Quit";
            this.QuitBtn.UseVisualStyleBackColor = true;
            this.QuitBtn.Click += new System.EventHandler(this.QuitBtn_Click);
            // 
            // PlayBtn
            // 
            this.PlayBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.PlayBtn.Location = new System.Drawing.Point(776, 459);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(126, 55);
            this.PlayBtn.TabIndex = 1;
            this.PlayBtn.Text = "Play";
            this.PlayBtn.UseVisualStyleBackColor = true;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // OptionsBtn
            // 
            this.OptionsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OptionsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.5F);
            this.OptionsBtn.Location = new System.Drawing.Point(644, 459);
            this.OptionsBtn.Name = "OptionsBtn";
            this.OptionsBtn.Size = new System.Drawing.Size(126, 55);
            this.OptionsBtn.TabIndex = 2;
            this.OptionsBtn.Text = "Options";
            this.OptionsBtn.UseVisualStyleBackColor = true;
            this.OptionsBtn.Click += new System.EventHandler(this.OptionsBtn_Click);
            // 
            // CurrSelGameText
            // 
            this.CurrSelGameText.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CurrSelGameText.AutoSize = true;
            this.CurrSelGameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.CurrSelGameText.Location = new System.Drawing.Point(246, 427);
            this.CurrSelGameText.Name = "CurrSelGameText";
            this.CurrSelGameText.Size = new System.Drawing.Size(331, 36);
            this.CurrSelGameText.TabIndex = 3;
            this.CurrSelGameText.Text = "Current Selected Game:";
            // 
            // SelGame
            // 
            this.SelGame.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SelGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.SelGame.Location = new System.Drawing.Point(247, 468);
            this.SelGame.Name = "SelGame";
            this.SelGame.Size = new System.Drawing.Size(330, 46);
            this.SelGame.TabIndex = 4;
            this.SelGame.Text = "None";
            this.SelGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MovePanel
            // 
            this.MovePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MovePanel.BackColor = System.Drawing.Color.OrangeRed;
            this.MovePanel.Controls.Add(this.MGL2);
            this.MovePanel.Controls.Add(this.MGL1);
            this.MovePanel.Controls.Add(this.Minimize);
            this.MovePanel.Controls.Add(this.Title);
            this.MovePanel.Location = new System.Drawing.Point(-1, -1);
            this.MovePanel.Name = "MovePanel";
            this.MovePanel.Size = new System.Drawing.Size(915, 36);
            this.MovePanel.TabIndex = 5;
            this.MovePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow_MouseDown);
            this.MovePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveWindow_MouseMove);
            this.MovePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MoveWindow_MouseUp);
            // 
            // MGL2
            // 
            this.MGL2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MGL2.Image = global::Multi_Game_Launcher.Properties.Resources.Icon;
            this.MGL2.Location = new System.Drawing.Point(879, -1);
            this.MGL2.Name = "MGL2";
            this.MGL2.Size = new System.Drawing.Size(35, 35);
            this.MGL2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MGL2.TabIndex = 16;
            this.MGL2.TabStop = false;
            this.MGL2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow_MouseDown);
            this.MGL2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveWindow_MouseMove);
            this.MGL2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MoveWindow_MouseUp);
            // 
            // MGL1
            // 
            this.MGL1.Image = global::Multi_Game_Launcher.Properties.Resources.Icon;
            this.MGL1.Location = new System.Drawing.Point(1, -1);
            this.MGL1.Name = "MGL1";
            this.MGL1.Size = new System.Drawing.Size(35, 35);
            this.MGL1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MGL1.TabIndex = 15;
            this.MGL1.TabStop = false;
            this.MGL1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow_MouseDown);
            this.MGL1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveWindow_MouseMove);
            this.MGL1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MoveWindow_MouseUp);
            // 
            // Minimize
            // 
            this.Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize.AutoSize = true;
            this.Minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.Minimize.Location = new System.Drawing.Point(844, 3);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(33, 29);
            this.Minimize.TabIndex = 1;
            this.Minimize.Text = "🗕";
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(76)))), ((int)(((byte)(74)))));
            this.Title.Location = new System.Drawing.Point(327, 3);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(242, 29);
            this.Title.TabIndex = 0;
            this.Title.Text = "Multi-Game Launcher";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow_MouseDown);
            this.Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveWindow_MouseMove);
            this.Title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MoveWindow_MouseUp);
            // 
            // MCTEXT
            // 
            this.MCTEXT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MCTEXT.AutoSize = true;
            this.MCTEXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.MCTEXT.Location = new System.Drawing.Point(24, 144);
            this.MCTEXT.Name = "MCTEXT";
            this.MCTEXT.Size = new System.Drawing.Size(101, 26);
            this.MCTEXT.TabIndex = 11;
            this.MCTEXT.Text = "Minecraft";
            this.MCTEXT.Click += new System.EventHandler(this.MC_Click);
            // 
            // RLTEXT
            // 
            this.RLTEXT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.RLTEXT.AutoSize = true;
            this.RLTEXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.RLTEXT.Location = new System.Drawing.Point(147, 144);
            this.RLTEXT.Name = "RLTEXT";
            this.RLTEXT.Size = new System.Drawing.Size(84, 52);
            this.RLTEXT.TabIndex = 12;
            this.RLTEXT.Text = "Rocket\r\nLeauge\r\n";
            this.RLTEXT.Click += new System.EventHandler(this.RL_Click);
            // 
            // CSGOTEXT
            // 
            this.CSGOTEXT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.CSGOTEXT.AutoSize = true;
            this.CSGOTEXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.CSGOTEXT.Location = new System.Drawing.Point(282, 144);
            this.CSGOTEXT.Name = "CSGOTEXT";
            this.CSGOTEXT.Size = new System.Drawing.Size(83, 26);
            this.CSGOTEXT.TabIndex = 13;
            this.CSGOTEXT.Text = "CS:GO";
            this.CSGOTEXT.Click += new System.EventHandler(this.CSGO_Click);
            // 
            // SCRAPMECHTEXT
            // 
            this.SCRAPMECHTEXT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.SCRAPMECHTEXT.AutoSize = true;
            this.SCRAPMECHTEXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.SCRAPMECHTEXT.Location = new System.Drawing.Point(540, 144);
            this.SCRAPMECHTEXT.Name = "SCRAPMECHTEXT";
            this.SCRAPMECHTEXT.Size = new System.Drawing.Size(105, 52);
            this.SCRAPMECHTEXT.TabIndex = 14;
            this.SCRAPMECHTEXT.Text = "Scrap \r\nMechanic";
            this.SCRAPMECHTEXT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SCRAPMECHTEXT.Click += new System.EventHandler(this.ScrapMech_Click);
            // 
            // UNTURNEDIMG
            // 
            this.UNTURNEDIMG.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UNTURNEDIMG.Image = global::Multi_Game_Launcher.Properties.Resources.UnturendLOGO;
            this.UNTURNEDIMG.Location = new System.Drawing.Point(677, 41);
            this.UNTURNEDIMG.Name = "UNTURNEDIMG";
            this.UNTURNEDIMG.Size = new System.Drawing.Size(102, 100);
            this.UNTURNEDIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UNTURNEDIMG.TabIndex = 16;
            this.UNTURNEDIMG.TabStop = false;
            this.UNTURNEDIMG.Click += new System.EventHandler(this.Unturned_Click);
            // 
            // ScrapMechIMG
            // 
            this.ScrapMechIMG.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ScrapMechIMG.Image = global::Multi_Game_Launcher.Properties.Resources.ScrapMechLogo;
            this.ScrapMechIMG.Location = new System.Drawing.Point(539, 41);
            this.ScrapMechIMG.Name = "ScrapMechIMG";
            this.ScrapMechIMG.Size = new System.Drawing.Size(102, 100);
            this.ScrapMechIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ScrapMechIMG.TabIndex = 10;
            this.ScrapMechIMG.TabStop = false;
            this.ScrapMechIMG.Click += new System.EventHandler(this.ScrapMech_Click);
            // 
            // LOLIMG
            // 
            this.LOLIMG.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LOLIMG.Image = global::Multi_Game_Launcher.Properties.Resources.LOLLogo;
            this.LOLIMG.Location = new System.Drawing.Point(405, 41);
            this.LOLIMG.Name = "LOLIMG";
            this.LOLIMG.Size = new System.Drawing.Size(102, 100);
            this.LOLIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LOLIMG.TabIndex = 9;
            this.LOLIMG.TabStop = false;
            this.LOLIMG.Click += new System.EventHandler(this.LOL_Click);
            // 
            // GSGOIMG
            // 
            this.GSGOIMG.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GSGOIMG.Image = global::Multi_Game_Launcher.Properties.Resources.CSGOLogo;
            this.GSGOIMG.Location = new System.Drawing.Point(272, 41);
            this.GSGOIMG.Name = "GSGOIMG";
            this.GSGOIMG.Size = new System.Drawing.Size(102, 100);
            this.GSGOIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GSGOIMG.TabIndex = 8;
            this.GSGOIMG.TabStop = false;
            this.GSGOIMG.Click += new System.EventHandler(this.CSGO_Click);
            // 
            // RLIMG
            // 
            this.RLIMG.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RLIMG.Image = global::Multi_Game_Launcher.Properties.Resources.RocketLeauge;
            this.RLIMG.Location = new System.Drawing.Point(138, 41);
            this.RLIMG.Name = "RLIMG";
            this.RLIMG.Size = new System.Drawing.Size(102, 100);
            this.RLIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RLIMG.TabIndex = 7;
            this.RLIMG.TabStop = false;
            this.RLIMG.Click += new System.EventHandler(this.RL_Click);
            // 
            // MCIMG
            // 
            this.MCIMG.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MCIMG.Image = global::Multi_Game_Launcher.Properties.Resources.MinecraftLogo;
            this.MCIMG.Location = new System.Drawing.Point(23, 41);
            this.MCIMG.Name = "MCIMG";
            this.MCIMG.Size = new System.Drawing.Size(102, 100);
            this.MCIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MCIMG.TabIndex = 6;
            this.MCIMG.TabStop = false;
            this.MCIMG.Click += new System.EventHandler(this.MC_Click);
            // 
            // LOLTEXT
            // 
            this.LOLTEXT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LOLTEXT.AutoSize = true;
            this.LOLTEXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.LOLTEXT.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.LOLTEXT.Location = new System.Drawing.Point(394, 144);
            this.LOLTEXT.Name = "LOLTEXT";
            this.LOLTEXT.Size = new System.Drawing.Size(120, 52);
            this.LOLTEXT.TabIndex = 18;
            this.LOLTEXT.Text = "League OF\r\nLegends";
            this.LOLTEXT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LOLTEXT.Click += new System.EventHandler(this.LOL_Click);
            // 
            // UnturnedTEXT
            // 
            this.UnturnedTEXT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.UnturnedTEXT.AutoSize = true;
            this.UnturnedTEXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.UnturnedTEXT.Location = new System.Drawing.Point(678, 146);
            this.UnturnedTEXT.Name = "UnturnedTEXT";
            this.UnturnedTEXT.Size = new System.Drawing.Size(101, 26);
            this.UnturnedTEXT.TabIndex = 19;
            this.UnturnedTEXT.Text = "Unturned";
            this.UnturnedTEXT.Click += new System.EventHandler(this.Unturned_Click);
            // 
            // FactorioTEXT
            // 
            this.FactorioTEXT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FactorioTEXT.AutoSize = true;
            this.FactorioTEXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.FactorioTEXT.Location = new System.Drawing.Point(804, 144);
            this.FactorioTEXT.Name = "FactorioTEXT";
            this.FactorioTEXT.Size = new System.Drawing.Size(90, 26);
            this.FactorioTEXT.TabIndex = 17;
            this.FactorioTEXT.Text = "Factorio";
            this.FactorioTEXT.Click += new System.EventHandler(this.Factorio_Click);
            // 
            // FactorioIMG
            // 
            this.FactorioIMG.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FactorioIMG.Image = global::Multi_Game_Launcher.Properties.Resources.Factorio;
            this.FactorioIMG.Location = new System.Drawing.Point(800, 41);
            this.FactorioIMG.Name = "FactorioIMG";
            this.FactorioIMG.Size = new System.Drawing.Size(102, 100);
            this.FactorioIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FactorioIMG.TabIndex = 15;
            this.FactorioIMG.TabStop = false;
            this.FactorioIMG.Click += new System.EventHandler(this.Factorio_Click);
            // 
            // LauncherWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Multi_Game_Launcher.Properties.Resources.Icon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 526);
            this.Controls.Add(this.UnturnedTEXT);
            this.Controls.Add(this.LOLTEXT);
            this.Controls.Add(this.FactorioTEXT);
            this.Controls.Add(this.UNTURNEDIMG);
            this.Controls.Add(this.FactorioIMG);
            this.Controls.Add(this.SCRAPMECHTEXT);
            this.Controls.Add(this.CSGOTEXT);
            this.Controls.Add(this.RLTEXT);
            this.Controls.Add(this.MCTEXT);
            this.Controls.Add(this.ScrapMechIMG);
            this.Controls.Add(this.LOLIMG);
            this.Controls.Add(this.GSGOIMG);
            this.Controls.Add(this.RLIMG);
            this.Controls.Add(this.MCIMG);
            this.Controls.Add(this.MovePanel);
            this.Controls.Add(this.SelGame);
            this.Controls.Add(this.CurrSelGameText);
            this.Controls.Add(this.OptionsBtn);
            this.Controls.Add(this.PlayBtn);
            this.Controls.Add(this.QuitBtn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LauncherWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multi-Game Launcher";
            this.MovePanel.ResumeLayout(false);
            this.MovePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MGL2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MGL1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UNTURNEDIMG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScrapMechIMG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LOLIMG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GSGOIMG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RLIMG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MCIMG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FactorioIMG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button QuitBtn;
        private System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.Button OptionsBtn;
        private System.Windows.Forms.Label CurrSelGameText;
        private System.Windows.Forms.Label SelGame;
        private System.Windows.Forms.Panel MovePanel;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Minimize;
        private System.Windows.Forms.PictureBox MCIMG;
        private System.Windows.Forms.PictureBox RLIMG;
        private System.Windows.Forms.PictureBox GSGOIMG;
        private System.Windows.Forms.PictureBox LOLIMG;
        private System.Windows.Forms.PictureBox ScrapMechIMG;
        private System.Windows.Forms.Label MCTEXT;
        private System.Windows.Forms.Label RLTEXT;
        private System.Windows.Forms.Label CSGOTEXT;
        private System.Windows.Forms.Label SCRAPMECHTEXT;
        private System.Windows.Forms.PictureBox MGL1;
        private System.Windows.Forms.PictureBox UNTURNEDIMG;
        private System.Windows.Forms.Label LOLTEXT;
        private System.Windows.Forms.Label UnturnedTEXT;
        private System.Windows.Forms.PictureBox MGL2;
        private System.Windows.Forms.Label FactorioTEXT;
        private System.Windows.Forms.PictureBox FactorioIMG;
    }
}

