namespace Animation
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DrawerButton = new System.Windows.Forms.Button();
            this.Drawer = new System.Windows.Forms.Panel();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.PlaylistsButton = new System.Windows.Forms.Button();
            this.GenresButton = new System.Windows.Forms.Button();
            this.AlbumsButton = new System.Windows.Forms.Button();
            this.ArtistsButton = new System.Windows.Forms.Button();
            this.SongsButton = new System.Windows.Forms.Button();
            this.OnlineButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ListPanel = new System.Windows.Forms.Panel();
            this.ListArtBox = new System.Windows.Forms.PictureBox();
            this.ListDGV = new System.Windows.Forms.DataGridView();
            this.HomePanel = new System.Windows.Forms.Panel();
            this.HelloLabel = new System.Windows.Forms.Label();
            this.PlayerBar = new System.Windows.Forms.Panel();
            this.BarVolumeSlider = new System.Windows.Forms.TrackBar();
            this.BarProgressSlider = new System.Windows.Forms.TrackBar();
            this.BarLoopButton = new System.Windows.Forms.Button();
            this.BarPreviousButton = new System.Windows.Forms.Button();
            this.BarPausePlayButton = new System.Windows.Forms.Button();
            this.BarNextButton = new System.Windows.Forms.Button();
            this.BarShuffleButton = new System.Windows.Forms.Button();
            this.BarArtistLabel = new System.Windows.Forms.Label();
            this.BarTitleLabel = new System.Windows.Forms.Label();
            this.BarAlbumArt = new System.Windows.Forms.PictureBox();
            this.Drawer.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.ListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListArtBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListDGV)).BeginInit();
            this.HomePanel.SuspendLayout();
            this.PlayerBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarVolumeSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarProgressSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarAlbumArt)).BeginInit();
            this.SuspendLayout();
            // 
            // DrawerButton
            // 
            this.DrawerButton.Location = new System.Drawing.Point(-1, -1);
            this.DrawerButton.Name = "DrawerButton";
            this.DrawerButton.Size = new System.Drawing.Size(52, 52);
            this.DrawerButton.TabIndex = 0;
            this.DrawerButton.Text = "Open Drawer";
            this.DrawerButton.UseVisualStyleBackColor = true;
            this.DrawerButton.Click += new System.EventHandler(this.DrawerButton_Click);
            // 
            // Drawer
            // 
            this.Drawer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Drawer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Drawer.Controls.Add(this.SettingsButton);
            this.Drawer.Controls.Add(this.AboutButton);
            this.Drawer.Controls.Add(this.PlaylistsButton);
            this.Drawer.Controls.Add(this.GenresButton);
            this.Drawer.Controls.Add(this.AlbumsButton);
            this.Drawer.Controls.Add(this.ArtistsButton);
            this.Drawer.Controls.Add(this.SongsButton);
            this.Drawer.Controls.Add(this.OnlineButton);
            this.Drawer.Controls.Add(this.HomeButton);
            this.Drawer.Location = new System.Drawing.Point(0, 49);
            this.Drawer.Name = "Drawer";
            this.Drawer.Size = new System.Drawing.Size(50, 543);
            this.Drawer.TabIndex = 1;
            // 
            // SettingsButton
            // 
            this.SettingsButton.Location = new System.Drawing.Point(-1, 437);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(50, 50);
            this.SettingsButton.TabIndex = 10;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            // 
            // AboutButton
            // 
            this.AboutButton.Location = new System.Drawing.Point(-1, 493);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(50, 50);
            this.AboutButton.TabIndex = 9;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = true;
            // 
            // PlaylistsButton
            // 
            this.PlaylistsButton.Location = new System.Drawing.Point(-1, 319);
            this.PlaylistsButton.Name = "PlaylistsButton";
            this.PlaylistsButton.Size = new System.Drawing.Size(50, 50);
            this.PlaylistsButton.TabIndex = 8;
            this.PlaylistsButton.Text = "Playlists";
            this.PlaylistsButton.UseVisualStyleBackColor = true;
            // 
            // GenresButton
            // 
            this.GenresButton.Location = new System.Drawing.Point(-1, 267);
            this.GenresButton.Name = "GenresButton";
            this.GenresButton.Size = new System.Drawing.Size(50, 50);
            this.GenresButton.TabIndex = 7;
            this.GenresButton.Text = "Genres";
            this.GenresButton.UseVisualStyleBackColor = true;
            // 
            // AlbumsButton
            // 
            this.AlbumsButton.Location = new System.Drawing.Point(-1, 215);
            this.AlbumsButton.Name = "AlbumsButton";
            this.AlbumsButton.Size = new System.Drawing.Size(50, 50);
            this.AlbumsButton.TabIndex = 6;
            this.AlbumsButton.Text = "Albums";
            this.AlbumsButton.UseVisualStyleBackColor = true;
            // 
            // ArtistsButton
            // 
            this.ArtistsButton.Location = new System.Drawing.Point(-1, 163);
            this.ArtistsButton.Name = "ArtistsButton";
            this.ArtistsButton.Size = new System.Drawing.Size(50, 50);
            this.ArtistsButton.TabIndex = 5;
            this.ArtistsButton.Text = "Artists";
            this.ArtistsButton.UseVisualStyleBackColor = true;
            // 
            // SongsButton
            // 
            this.SongsButton.Location = new System.Drawing.Point(-1, 111);
            this.SongsButton.Name = "SongsButton";
            this.SongsButton.Size = new System.Drawing.Size(50, 50);
            this.SongsButton.TabIndex = 4;
            this.SongsButton.Text = "Songs";
            this.SongsButton.UseVisualStyleBackColor = true;
            this.SongsButton.Click += new System.EventHandler(this.SongsButton_Click);
            // 
            // OnlineButton
            // 
            this.OnlineButton.Location = new System.Drawing.Point(-1, 59);
            this.OnlineButton.Name = "OnlineButton";
            this.OnlineButton.Size = new System.Drawing.Size(50, 50);
            this.OnlineButton.TabIndex = 3;
            this.OnlineButton.Text = "Online";
            this.OnlineButton.UseVisualStyleBackColor = true;
            // 
            // HomeButton
            // 
            this.HomeButton.Location = new System.Drawing.Point(-1, 7);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(50, 50);
            this.HomeButton.TabIndex = 2;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.ListPanel);
            this.MainPanel.Controls.Add(this.HomePanel);
            this.MainPanel.Location = new System.Drawing.Point(50, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(750, 537);
            this.MainPanel.TabIndex = 2;
            // 
            // ListPanel
            // 
            this.ListPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ListPanel.Controls.Add(this.ListArtBox);
            this.ListPanel.Controls.Add(this.ListDGV);
            this.ListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListPanel.Location = new System.Drawing.Point(0, 0);
            this.ListPanel.Name = "ListPanel";
            this.ListPanel.Size = new System.Drawing.Size(750, 537);
            this.ListPanel.TabIndex = 1;
            // 
            // ListArtBox
            // 
            this.ListArtBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ListArtBox.Location = new System.Drawing.Point(15, 12);
            this.ListArtBox.Name = "ListArtBox";
            this.ListArtBox.Size = new System.Drawing.Size(142, 142);
            this.ListArtBox.TabIndex = 1;
            this.ListArtBox.TabStop = false;
            // 
            // ListDGV
            // 
            this.ListDGV.AllowUserToAddRows = false;
            this.ListDGV.AllowUserToDeleteRows = false;
            this.ListDGV.AllowUserToOrderColumns = true;
            this.ListDGV.AllowUserToResizeRows = false;
            this.ListDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ListDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.ListDGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ListDGV.Location = new System.Drawing.Point(0, 165);
            this.ListDGV.Name = "ListDGV";
            this.ListDGV.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ListDGV.RowHeadersVisible = false;
            this.ListDGV.RowHeadersWidth = 82;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.ListDGV.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ListDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListDGV.Size = new System.Drawing.Size(750, 372);
            this.ListDGV.TabIndex = 0;
            this.ListDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListDGV_CellClick);
            this.ListDGV.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListDGV_CellMouseEnter);
            this.ListDGV.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListDGV_CellMouseLeave);
            // 
            // HomePanel
            // 
            this.HomePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.HomePanel.Controls.Add(this.HelloLabel);
            this.HomePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomePanel.Location = new System.Drawing.Point(0, 0);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(750, 537);
            this.HomePanel.TabIndex = 0;
            this.HomePanel.Visible = false;
            // 
            // HelloLabel
            // 
            this.HelloLabel.AutoSize = true;
            this.HelloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelloLabel.ForeColor = System.Drawing.Color.White;
            this.HelloLabel.Location = new System.Drawing.Point(8, 13);
            this.HelloLabel.Name = "HelloLabel";
            this.HelloLabel.Size = new System.Drawing.Size(228, 37);
            this.HelloLabel.TabIndex = 0;
            this.HelloLabel.Text = "Hello, Merrek.";
            // 
            // PlayerBar
            // 
            this.PlayerBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PlayerBar.Controls.Add(this.BarVolumeSlider);
            this.PlayerBar.Controls.Add(this.BarProgressSlider);
            this.PlayerBar.Controls.Add(this.BarLoopButton);
            this.PlayerBar.Controls.Add(this.BarPreviousButton);
            this.PlayerBar.Controls.Add(this.BarPausePlayButton);
            this.PlayerBar.Controls.Add(this.BarNextButton);
            this.PlayerBar.Controls.Add(this.BarShuffleButton);
            this.PlayerBar.Controls.Add(this.BarArtistLabel);
            this.PlayerBar.Controls.Add(this.BarTitleLabel);
            this.PlayerBar.Controls.Add(this.BarAlbumArt);
            this.PlayerBar.Location = new System.Drawing.Point(50, 537);
            this.PlayerBar.Name = "PlayerBar";
            this.PlayerBar.Size = new System.Drawing.Size(750, 55);
            this.PlayerBar.TabIndex = 3;
            // 
            // BarVolumeSlider
            // 
            this.BarVolumeSlider.Location = new System.Drawing.Point(681, 8);
            this.BarVolumeSlider.Maximum = 100;
            this.BarVolumeSlider.Name = "BarVolumeSlider";
            this.BarVolumeSlider.Size = new System.Drawing.Size(66, 45);
            this.BarVolumeSlider.TabIndex = 9;
            // 
            // BarProgressSlider
            // 
            this.BarProgressSlider.Location = new System.Drawing.Point(180, 8);
            this.BarProgressSlider.Name = "BarProgressSlider";
            this.BarProgressSlider.Size = new System.Drawing.Size(221, 45);
            this.BarProgressSlider.TabIndex = 8;
            // 
            // BarLoopButton
            // 
            this.BarLoopButton.Location = new System.Drawing.Point(413, 5);
            this.BarLoopButton.Name = "BarLoopButton";
            this.BarLoopButton.Size = new System.Drawing.Size(45, 45);
            this.BarLoopButton.TabIndex = 7;
            this.BarLoopButton.Text = "LOOP";
            this.BarLoopButton.UseVisualStyleBackColor = true;
            // 
            // BarPreviousButton
            // 
            this.BarPreviousButton.Location = new System.Drawing.Point(464, 5);
            this.BarPreviousButton.Name = "BarPreviousButton";
            this.BarPreviousButton.Size = new System.Drawing.Size(45, 45);
            this.BarPreviousButton.TabIndex = 6;
            this.BarPreviousButton.Text = "|<";
            this.BarPreviousButton.UseVisualStyleBackColor = true;
            this.BarPreviousButton.Click += new System.EventHandler(this.BarPreviousButton_Click);
            // 
            // BarPausePlayButton
            // 
            this.BarPausePlayButton.Location = new System.Drawing.Point(515, 5);
            this.BarPausePlayButton.Name = "BarPausePlayButton";
            this.BarPausePlayButton.Size = new System.Drawing.Size(45, 45);
            this.BarPausePlayButton.TabIndex = 5;
            this.BarPausePlayButton.Text = ">";
            this.BarPausePlayButton.UseVisualStyleBackColor = true;
            this.BarPausePlayButton.Click += new System.EventHandler(this.BarPausePlayButton_Click);
            // 
            // BarNextButton
            // 
            this.BarNextButton.Location = new System.Drawing.Point(566, 5);
            this.BarNextButton.Name = "BarNextButton";
            this.BarNextButton.Size = new System.Drawing.Size(45, 45);
            this.BarNextButton.TabIndex = 4;
            this.BarNextButton.Text = ">|";
            this.BarNextButton.UseVisualStyleBackColor = true;
            this.BarNextButton.Click += new System.EventHandler(this.BarNextButton_Click);
            // 
            // BarShuffleButton
            // 
            this.BarShuffleButton.Location = new System.Drawing.Point(617, 5);
            this.BarShuffleButton.Name = "BarShuffleButton";
            this.BarShuffleButton.Size = new System.Drawing.Size(45, 45);
            this.BarShuffleButton.TabIndex = 3;
            this.BarShuffleButton.Text = "-->\r\n-->";
            this.BarShuffleButton.UseVisualStyleBackColor = true;
            // 
            // BarArtistLabel
            // 
            this.BarArtistLabel.AutoSize = true;
            this.BarArtistLabel.ForeColor = System.Drawing.Color.White;
            this.BarArtistLabel.Location = new System.Drawing.Point(63, 32);
            this.BarArtistLabel.Name = "BarArtistLabel";
            this.BarArtistLabel.Size = new System.Drawing.Size(35, 13);
            this.BarArtistLabel.TabIndex = 2;
            this.BarArtistLabel.Text = "label1";
            // 
            // BarTitleLabel
            // 
            this.BarTitleLabel.AutoSize = true;
            this.BarTitleLabel.ForeColor = System.Drawing.Color.White;
            this.BarTitleLabel.Location = new System.Drawing.Point(63, 10);
            this.BarTitleLabel.Name = "BarTitleLabel";
            this.BarTitleLabel.Size = new System.Drawing.Size(35, 13);
            this.BarTitleLabel.TabIndex = 1;
            this.BarTitleLabel.Text = "label1";
            // 
            // BarAlbumArt
            // 
            this.BarAlbumArt.Location = new System.Drawing.Point(11, 5);
            this.BarAlbumArt.Name = "BarAlbumArt";
            this.BarAlbumArt.Size = new System.Drawing.Size(45, 45);
            this.BarAlbumArt.TabIndex = 0;
            this.BarAlbumArt.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(800, 592);
            this.Controls.Add(this.PlayerBar);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.Drawer);
            this.Controls.Add(this.DrawerButton);
            this.Name = "MainForm";
            this.Text = "UMusic";
            this.Drawer.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.ListPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListArtBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListDGV)).EndInit();
            this.HomePanel.ResumeLayout(false);
            this.HomePanel.PerformLayout();
            this.PlayerBar.ResumeLayout(false);
            this.PlayerBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarVolumeSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarProgressSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarAlbumArt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DrawerButton;
        private System.Windows.Forms.Panel Drawer;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Button PlaylistsButton;
        private System.Windows.Forms.Button GenresButton;
        private System.Windows.Forms.Button AlbumsButton;
        private System.Windows.Forms.Button ArtistsButton;
        private System.Windows.Forms.Button SongsButton;
        private System.Windows.Forms.Button OnlineButton;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel HomePanel;
        private System.Windows.Forms.Label HelloLabel;
        private System.Windows.Forms.Panel ListPanel;
        public System.Windows.Forms.DataGridView ListDGV;
        private System.Windows.Forms.PictureBox ListArtBox;
        private System.Windows.Forms.Panel PlayerBar;
        private System.Windows.Forms.TrackBar BarVolumeSlider;
        private System.Windows.Forms.Button BarLoopButton;
        private System.Windows.Forms.Button BarPreviousButton;
        private System.Windows.Forms.Button BarNextButton;
        private System.Windows.Forms.Button BarShuffleButton;
        public System.Windows.Forms.TrackBar BarProgressSlider;
        public System.Windows.Forms.Label BarArtistLabel;
        public System.Windows.Forms.Label BarTitleLabel;
        public System.Windows.Forms.PictureBox BarAlbumArt;
        public System.Windows.Forms.Button BarPausePlayButton;
    }
}

