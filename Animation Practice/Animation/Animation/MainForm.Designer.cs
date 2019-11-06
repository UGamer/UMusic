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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.ListDurationTrackLabel = new System.Windows.Forms.Label();
            this.ListBottomLabel = new System.Windows.Forms.Label();
            this.ListTopLabel = new System.Windows.Forms.Label();
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
            this.DrawerButton.Location = new System.Drawing.Point(-2, -2);
            this.DrawerButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.DrawerButton.Name = "DrawerButton";
            this.DrawerButton.Size = new System.Drawing.Size(104, 100);
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
            this.Drawer.Location = new System.Drawing.Point(0, 94);
            this.Drawer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Drawer.Name = "Drawer";
            this.Drawer.Size = new System.Drawing.Size(98, 1042);
            this.Drawer.TabIndex = 1;
            // 
            // SettingsButton
            // 
            this.SettingsButton.Location = new System.Drawing.Point(-2, 840);
            this.SettingsButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(100, 96);
            this.SettingsButton.TabIndex = 10;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            // 
            // AboutButton
            // 
            this.AboutButton.Location = new System.Drawing.Point(-2, 948);
            this.AboutButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(100, 96);
            this.AboutButton.TabIndex = 9;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = true;
            // 
            // PlaylistsButton
            // 
            this.PlaylistsButton.Location = new System.Drawing.Point(-2, 613);
            this.PlaylistsButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PlaylistsButton.Name = "PlaylistsButton";
            this.PlaylistsButton.Size = new System.Drawing.Size(100, 96);
            this.PlaylistsButton.TabIndex = 8;
            this.PlaylistsButton.Text = "Playlists";
            this.PlaylistsButton.UseVisualStyleBackColor = true;
            // 
            // GenresButton
            // 
            this.GenresButton.Location = new System.Drawing.Point(-2, 513);
            this.GenresButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.GenresButton.Name = "GenresButton";
            this.GenresButton.Size = new System.Drawing.Size(100, 96);
            this.GenresButton.TabIndex = 7;
            this.GenresButton.Text = "Genres";
            this.GenresButton.UseVisualStyleBackColor = true;
            // 
            // AlbumsButton
            // 
            this.AlbumsButton.Location = new System.Drawing.Point(-2, 413);
            this.AlbumsButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.AlbumsButton.Name = "AlbumsButton";
            this.AlbumsButton.Size = new System.Drawing.Size(100, 96);
            this.AlbumsButton.TabIndex = 6;
            this.AlbumsButton.Text = "Albums";
            this.AlbumsButton.UseVisualStyleBackColor = true;
            // 
            // ArtistsButton
            // 
            this.ArtistsButton.Location = new System.Drawing.Point(-2, 313);
            this.ArtistsButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ArtistsButton.Name = "ArtistsButton";
            this.ArtistsButton.Size = new System.Drawing.Size(100, 96);
            this.ArtistsButton.TabIndex = 5;
            this.ArtistsButton.Text = "Artists";
            this.ArtistsButton.UseVisualStyleBackColor = true;
            // 
            // SongsButton
            // 
            this.SongsButton.Location = new System.Drawing.Point(-2, 213);
            this.SongsButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SongsButton.Name = "SongsButton";
            this.SongsButton.Size = new System.Drawing.Size(100, 96);
            this.SongsButton.TabIndex = 4;
            this.SongsButton.Text = "Songs";
            this.SongsButton.UseVisualStyleBackColor = true;
            this.SongsButton.Click += new System.EventHandler(this.SongsButton_Click);
            // 
            // OnlineButton
            // 
            this.OnlineButton.Location = new System.Drawing.Point(-2, 113);
            this.OnlineButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.OnlineButton.Name = "OnlineButton";
            this.OnlineButton.Size = new System.Drawing.Size(100, 96);
            this.OnlineButton.TabIndex = 3;
            this.OnlineButton.Text = "Online";
            this.OnlineButton.UseVisualStyleBackColor = true;
            // 
            // HomeButton
            // 
            this.HomeButton.Location = new System.Drawing.Point(-2, 13);
            this.HomeButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(100, 96);
            this.HomeButton.TabIndex = 2;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.ListPanel);
            this.MainPanel.Controls.Add(this.HomePanel);
            this.MainPanel.Location = new System.Drawing.Point(100, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1500, 1033);
            this.MainPanel.TabIndex = 2;
            // 
            // ListPanel
            // 
            this.ListPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ListPanel.Controls.Add(this.ListDurationTrackLabel);
            this.ListPanel.Controls.Add(this.ListBottomLabel);
            this.ListPanel.Controls.Add(this.ListTopLabel);
            this.ListPanel.Controls.Add(this.ListArtBox);
            this.ListPanel.Controls.Add(this.ListDGV);
            this.ListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListPanel.Location = new System.Drawing.Point(0, 0);
            this.ListPanel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ListPanel.Name = "ListPanel";
            this.ListPanel.Size = new System.Drawing.Size(1500, 1033);
            this.ListPanel.TabIndex = 1;
            // 
            // ListDurationTrackLabel
            // 
            this.ListDurationTrackLabel.AutoSize = true;
            this.ListDurationTrackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListDurationTrackLabel.ForeColor = System.Drawing.Color.White;
            this.ListDurationTrackLabel.Location = new System.Drawing.Point(332, 240);
            this.ListDurationTrackLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ListDurationTrackLabel.Name = "ListDurationTrackLabel";
            this.ListDurationTrackLabel.Size = new System.Drawing.Size(547, 55);
            this.ListDurationTrackLabel.TabIndex = 4;
            this.ListDurationTrackLabel.Text = "Duration: 00:00, # tracks";
            // 
            // ListBottomLabel
            // 
            this.ListBottomLabel.AutoSize = true;
            this.ListBottomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBottomLabel.ForeColor = System.Drawing.Color.White;
            this.ListBottomLabel.Location = new System.Drawing.Point(328, 110);
            this.ListBottomLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ListBottomLabel.Name = "ListBottomLabel";
            this.ListBottomLabel.Size = new System.Drawing.Size(847, 55);
            this.ListBottomLabel.TabIndex = 3;
            this.ListBottomLabel.Text = "... / ... / Album Artist(s) Name(s) / ... / ...";
            // 
            // ListTopLabel
            // 
            this.ListTopLabel.AutoSize = true;
            this.ListTopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListTopLabel.ForeColor = System.Drawing.Color.White;
            this.ListTopLabel.Location = new System.Drawing.Point(328, 25);
            this.ListTopLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ListTopLabel.Name = "ListTopLabel";
            this.ListTopLabel.Size = new System.Drawing.Size(1647, 73);
            this.ListTopLabel.TabIndex = 2;
            this.ListTopLabel.Text = "Songs / Artist Name / Album Title / Genre / Playlist Name";
            // 
            // ListArtBox
            // 
            this.ListArtBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ListArtBox.Location = new System.Drawing.Point(30, 23);
            this.ListArtBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ListArtBox.Name = "ListArtBox";
            this.ListArtBox.Size = new System.Drawing.Size(284, 273);
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.ListDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListDGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.ListDGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ListDGV.Location = new System.Drawing.Point(0, 318);
            this.ListDGV.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ListDGV.Name = "ListDGV";
            this.ListDGV.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.ListDGV.RowHeadersVisible = false;
            this.ListDGV.RowHeadersWidth = 82;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            this.ListDGV.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.ListDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListDGV.Size = new System.Drawing.Size(1500, 715);
            this.ListDGV.TabIndex = 0;
            this.ListDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListDGV_CellClick);
            this.ListDGV.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListDGV_CellMouseEnter);
            this.ListDGV.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListDGV_CellMouseLeave);
            this.ListDGV.Sorted += new System.EventHandler(this.ListDGV_Sorted);
            // 
            // HomePanel
            // 
            this.HomePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.HomePanel.Controls.Add(this.HelloLabel);
            this.HomePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomePanel.Location = new System.Drawing.Point(0, 0);
            this.HomePanel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(1500, 1033);
            this.HomePanel.TabIndex = 0;
            this.HomePanel.Visible = false;
            // 
            // HelloLabel
            // 
            this.HelloLabel.AutoSize = true;
            this.HelloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelloLabel.ForeColor = System.Drawing.Color.White;
            this.HelloLabel.Location = new System.Drawing.Point(16, 25);
            this.HelloLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.HelloLabel.Name = "HelloLabel";
            this.HelloLabel.Size = new System.Drawing.Size(444, 73);
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
            this.PlayerBar.Location = new System.Drawing.Point(100, 1033);
            this.PlayerBar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PlayerBar.Name = "PlayerBar";
            this.PlayerBar.Size = new System.Drawing.Size(1500, 106);
            this.PlayerBar.TabIndex = 3;
            // 
            // BarVolumeSlider
            // 
            this.BarVolumeSlider.Location = new System.Drawing.Point(1362, 15);
            this.BarVolumeSlider.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BarVolumeSlider.Maximum = 100;
            this.BarVolumeSlider.Name = "BarVolumeSlider";
            this.BarVolumeSlider.Size = new System.Drawing.Size(132, 90);
            this.BarVolumeSlider.TabIndex = 9;
            // 
            // BarProgressSlider
            // 
            this.BarProgressSlider.Location = new System.Drawing.Point(360, 15);
            this.BarProgressSlider.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BarProgressSlider.Name = "BarProgressSlider";
            this.BarProgressSlider.Size = new System.Drawing.Size(442, 90);
            this.BarProgressSlider.TabIndex = 8;
            this.BarProgressSlider.MouseCaptureChanged += new System.EventHandler(this.BarProgressSlider_MouseCaptureChanged);
            this.BarProgressSlider.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarProgressSlider_MouseDown);
            this.BarProgressSlider.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BarProgressSlider_MouseUp);
            // 
            // BarLoopButton
            // 
            this.BarLoopButton.Location = new System.Drawing.Point(826, 10);
            this.BarLoopButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BarLoopButton.Name = "BarLoopButton";
            this.BarLoopButton.Size = new System.Drawing.Size(90, 87);
            this.BarLoopButton.TabIndex = 7;
            this.BarLoopButton.Text = "LOOP";
            this.BarLoopButton.UseVisualStyleBackColor = true;
            // 
            // BarPreviousButton
            // 
            this.BarPreviousButton.Location = new System.Drawing.Point(928, 10);
            this.BarPreviousButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BarPreviousButton.Name = "BarPreviousButton";
            this.BarPreviousButton.Size = new System.Drawing.Size(90, 87);
            this.BarPreviousButton.TabIndex = 6;
            this.BarPreviousButton.Text = "|<";
            this.BarPreviousButton.UseVisualStyleBackColor = true;
            this.BarPreviousButton.Click += new System.EventHandler(this.BarPreviousButton_Click);
            // 
            // BarPausePlayButton
            // 
            this.BarPausePlayButton.Location = new System.Drawing.Point(1030, 10);
            this.BarPausePlayButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BarPausePlayButton.Name = "BarPausePlayButton";
            this.BarPausePlayButton.Size = new System.Drawing.Size(90, 87);
            this.BarPausePlayButton.TabIndex = 5;
            this.BarPausePlayButton.Text = ">";
            this.BarPausePlayButton.UseVisualStyleBackColor = true;
            this.BarPausePlayButton.Click += new System.EventHandler(this.BarPausePlayButton_Click);
            // 
            // BarNextButton
            // 
            this.BarNextButton.Location = new System.Drawing.Point(1132, 10);
            this.BarNextButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BarNextButton.Name = "BarNextButton";
            this.BarNextButton.Size = new System.Drawing.Size(90, 87);
            this.BarNextButton.TabIndex = 4;
            this.BarNextButton.Text = ">|";
            this.BarNextButton.UseVisualStyleBackColor = true;
            this.BarNextButton.Click += new System.EventHandler(this.BarNextButton_Click);
            // 
            // BarShuffleButton
            // 
            this.BarShuffleButton.Location = new System.Drawing.Point(1234, 10);
            this.BarShuffleButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BarShuffleButton.Name = "BarShuffleButton";
            this.BarShuffleButton.Size = new System.Drawing.Size(90, 87);
            this.BarShuffleButton.TabIndex = 3;
            this.BarShuffleButton.Text = "-->\r\n-->";
            this.BarShuffleButton.UseVisualStyleBackColor = true;
            // 
            // BarArtistLabel
            // 
            this.BarArtistLabel.AutoSize = true;
            this.BarArtistLabel.ForeColor = System.Drawing.Color.White;
            this.BarArtistLabel.Location = new System.Drawing.Point(126, 62);
            this.BarArtistLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.BarArtistLabel.Name = "BarArtistLabel";
            this.BarArtistLabel.Size = new System.Drawing.Size(0, 25);
            this.BarArtistLabel.TabIndex = 2;
            // 
            // BarTitleLabel
            // 
            this.BarTitleLabel.AutoSize = true;
            this.BarTitleLabel.ForeColor = System.Drawing.Color.White;
            this.BarTitleLabel.Location = new System.Drawing.Point(126, 19);
            this.BarTitleLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.BarTitleLabel.Name = "BarTitleLabel";
            this.BarTitleLabel.Size = new System.Drawing.Size(0, 25);
            this.BarTitleLabel.TabIndex = 1;
            // 
            // BarAlbumArt
            // 
            this.BarAlbumArt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BarAlbumArt.Location = new System.Drawing.Point(22, 10);
            this.BarAlbumArt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BarAlbumArt.Name = "BarAlbumArt";
            this.BarAlbumArt.Size = new System.Drawing.Size(90, 87);
            this.BarAlbumArt.TabIndex = 0;
            this.BarAlbumArt.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1600, 1138);
            this.Controls.Add(this.PlayerBar);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.Drawer);
            this.Controls.Add(this.DrawerButton);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "MainForm";
            this.Text = "UMusic";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Drawer.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.ListPanel.ResumeLayout(false);
            this.ListPanel.PerformLayout();
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
        private System.Windows.Forms.Label ListBottomLabel;
        private System.Windows.Forms.Label ListTopLabel;
        public System.Windows.Forms.Label ListDurationTrackLabel;
    }
}

