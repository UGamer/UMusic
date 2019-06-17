namespace UMusic
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DGV = new System.Windows.Forms.DataGridView();
            this.LocalContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddToPlaylistButton = new System.Windows.Forms.ToolStripMenuItem();
            this.addToQueueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteSongButton = new System.Windows.Forms.ToolStripMenuItem();
            this.editTagsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LocalPanel = new System.Windows.Forms.Panel();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.PlaylistsButton = new System.Windows.Forms.Button();
            this.GenresButton = new System.Windows.Forms.Button();
            this.AlbumsButton = new System.Windows.Forms.Button();
            this.ArtistsButton = new System.Windows.Forms.Button();
            this.SongsButton = new System.Windows.Forms.Button();
            this.PlayAllButton = new System.Windows.Forms.Button();
            this.BrowserDock = new System.Windows.Forms.Panel();
            this.GridPanel = new System.Windows.Forms.Panel();
            this.DetailPanel = new System.Windows.Forms.Panel();
            this.DetailBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.DetailPicture = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.miniToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.DownloadButton = new System.Windows.Forms.ToolStripButton();
            this.GoogleButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.SettingsDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.DiscordRichPresenceButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ServicesDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.UMusicButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SoundCloudButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SpotifyButton = new System.Windows.Forms.ToolStripMenuItem();
            this.YouTubeButton = new System.Windows.Forms.ToolStripMenuItem();
            this.YouTubeMusicButton = new System.Windows.Forms.ToolStripMenuItem();
            this.LocalMusicViewDropdown = new System.Windows.Forms.ToolStripDropDownButton();
            this.LayoutDropDown = new System.Windows.Forms.ToolStripMenuItem();
            this.LayoutListButton = new System.Windows.Forms.ToolStripMenuItem();
            this.LayoutGridButton = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.LocalContextMenu.SuspendLayout();
            this.LocalPanel.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.BrowserDock.SuspendLayout();
            this.GridPanel.SuspendLayout();
            this.DetailPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetailPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.ContextMenuStrip = this.LocalContextMenu;
            this.DGV.Location = new System.Drawing.Point(157, 1);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DGV.Size = new System.Drawing.Size(643, 423);
            this.DGV.TabIndex = 0;
            this.DGV.VirtualMode = true;
            this.DGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellDoubleClick);
            this.DGV.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_CellMouseUp);
            this.DGV.Sorted += new System.EventHandler(this.DGV_Sorted);
            // 
            // LocalContextMenu
            // 
            this.LocalContextMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.LocalContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToPlaylistButton,
            this.addToQueueToolStripMenuItem,
            this.DeleteSongButton,
            this.editTagsToolStripMenuItem});
            this.LocalContextMenu.Name = "LocalContextMenu";
            this.LocalContextMenu.Size = new System.Drawing.Size(151, 92);
            // 
            // AddToPlaylistButton
            // 
            this.AddToPlaylistButton.Name = "AddToPlaylistButton";
            this.AddToPlaylistButton.Size = new System.Drawing.Size(150, 22);
            this.AddToPlaylistButton.Text = "Add to Playlist";
            // 
            // addToQueueToolStripMenuItem
            // 
            this.addToQueueToolStripMenuItem.Name = "addToQueueToolStripMenuItem";
            this.addToQueueToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.addToQueueToolStripMenuItem.Text = "Add to Queue";
            this.addToQueueToolStripMenuItem.Click += new System.EventHandler(this.addToQueueToolStripMenuItem_Click);
            // 
            // DeleteSongButton
            // 
            this.DeleteSongButton.Name = "DeleteSongButton";
            this.DeleteSongButton.Size = new System.Drawing.Size(150, 22);
            this.DeleteSongButton.Text = "Delete Song";
            this.DeleteSongButton.ToolTipText = "Delete the song you have selected from your system.";
            this.DeleteSongButton.Click += new System.EventHandler(this.DeleteSongButton_Click);
            // 
            // editTagsToolStripMenuItem
            // 
            this.editTagsToolStripMenuItem.Name = "editTagsToolStripMenuItem";
            this.editTagsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.editTagsToolStripMenuItem.Text = "Edit Tags";
            this.editTagsToolStripMenuItem.Click += new System.EventHandler(this.editTagsToolStripMenuItem_Click);
            // 
            // LocalPanel
            // 
            this.LocalPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LocalPanel.BackColor = System.Drawing.Color.Black;
            this.LocalPanel.Controls.Add(this.LeftPanel);
            this.LocalPanel.Controls.Add(this.BrowserDock);
            this.LocalPanel.Controls.Add(this.DGV);
            this.LocalPanel.Location = new System.Drawing.Point(0, 27);
            this.LocalPanel.Margin = new System.Windows.Forms.Padding(2);
            this.LocalPanel.Name = "LocalPanel";
            this.LocalPanel.Size = new System.Drawing.Size(800, 423);
            this.LocalPanel.TabIndex = 2;
            // 
            // LeftPanel
            // 
            this.LeftPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LeftPanel.BackColor = System.Drawing.Color.DimGray;
            this.LeftPanel.Controls.Add(this.SearchBox);
            this.LeftPanel.Controls.Add(this.PlaylistsButton);
            this.LeftPanel.Controls.Add(this.GenresButton);
            this.LeftPanel.Controls.Add(this.AlbumsButton);
            this.LeftPanel.Controls.Add(this.ArtistsButton);
            this.LeftPanel.Controls.Add(this.SongsButton);
            this.LeftPanel.Controls.Add(this.PlayAllButton);
            this.LeftPanel.Location = new System.Drawing.Point(0, 1);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(158, 422);
            this.LeftPanel.TabIndex = 2;
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(5, 13);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(146, 20);
            this.SearchBox.TabIndex = 6;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // PlaylistsButton
            // 
            this.PlaylistsButton.Location = new System.Drawing.Point(5, 239);
            this.PlaylistsButton.Name = "PlaylistsButton";
            this.PlaylistsButton.Size = new System.Drawing.Size(147, 29);
            this.PlaylistsButton.TabIndex = 5;
            this.PlaylistsButton.Text = "Playlists";
            this.PlaylistsButton.UseVisualStyleBackColor = true;
            // 
            // GenresButton
            // 
            this.GenresButton.Location = new System.Drawing.Point(5, 204);
            this.GenresButton.Name = "GenresButton";
            this.GenresButton.Size = new System.Drawing.Size(147, 29);
            this.GenresButton.TabIndex = 4;
            this.GenresButton.Text = "Genres";
            this.GenresButton.UseVisualStyleBackColor = true;
            // 
            // AlbumsButton
            // 
            this.AlbumsButton.Location = new System.Drawing.Point(5, 169);
            this.AlbumsButton.Name = "AlbumsButton";
            this.AlbumsButton.Size = new System.Drawing.Size(147, 29);
            this.AlbumsButton.TabIndex = 3;
            this.AlbumsButton.Text = "Albums";
            this.AlbumsButton.UseVisualStyleBackColor = true;
            // 
            // ArtistsButton
            // 
            this.ArtistsButton.Location = new System.Drawing.Point(5, 134);
            this.ArtistsButton.Name = "ArtistsButton";
            this.ArtistsButton.Size = new System.Drawing.Size(147, 29);
            this.ArtistsButton.TabIndex = 2;
            this.ArtistsButton.Text = "Artists";
            this.ArtistsButton.UseVisualStyleBackColor = true;
            this.ArtistsButton.Click += new System.EventHandler(this.ArtistsButton_Click);
            // 
            // SongsButton
            // 
            this.SongsButton.Location = new System.Drawing.Point(5, 99);
            this.SongsButton.Name = "SongsButton";
            this.SongsButton.Size = new System.Drawing.Size(147, 29);
            this.SongsButton.TabIndex = 1;
            this.SongsButton.Text = "Songs";
            this.SongsButton.UseVisualStyleBackColor = true;
            this.SongsButton.Click += new System.EventHandler(this.SongsButton_Click);
            // 
            // PlayAllButton
            // 
            this.PlayAllButton.Location = new System.Drawing.Point(5, 47);
            this.PlayAllButton.Name = "PlayAllButton";
            this.PlayAllButton.Size = new System.Drawing.Size(147, 29);
            this.PlayAllButton.TabIndex = 0;
            this.PlayAllButton.Text = "Play All";
            this.PlayAllButton.UseVisualStyleBackColor = true;
            this.PlayAllButton.Click += new System.EventHandler(this.PlayAllButton_Click);
            // 
            // BrowserDock
            // 
            this.BrowserDock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowserDock.BackColor = System.Drawing.Color.White;
            this.BrowserDock.Controls.Add(this.GridPanel);
            this.BrowserDock.Location = new System.Drawing.Point(0, 1);
            this.BrowserDock.Name = "BrowserDock";
            this.BrowserDock.Size = new System.Drawing.Size(800, 423);
            this.BrowserDock.TabIndex = 1;
            this.BrowserDock.Visible = false;
            // 
            // GridPanel
            // 
            this.GridPanel.Controls.Add(this.DetailPanel);
            this.GridPanel.Controls.Add(this.textBox1);
            this.GridPanel.Controls.Add(this.pictureBox3);
            this.GridPanel.Controls.Add(this.pictureBox2);
            this.GridPanel.Controls.Add(this.pictureBox1);
            this.GridPanel.Location = new System.Drawing.Point(157, 0);
            this.GridPanel.Name = "GridPanel";
            this.GridPanel.Size = new System.Drawing.Size(643, 423);
            this.GridPanel.TabIndex = 0;
            // 
            // DetailPanel
            // 
            this.DetailPanel.Controls.Add(this.DetailBox);
            this.DetailPanel.Controls.Add(this.NameLabel);
            this.DetailPanel.Controls.Add(this.DetailPicture);
            this.DetailPanel.Location = new System.Drawing.Point(0, 0);
            this.DetailPanel.Name = "DetailPanel";
            this.DetailPanel.Size = new System.Drawing.Size(643, 422);
            this.DetailPanel.TabIndex = 4;
            // 
            // DetailBox
            // 
            this.DetailBox.Location = new System.Drawing.Point(228, 47);
            this.DetailBox.Multiline = true;
            this.DetailBox.Name = "DetailBox";
            this.DetailBox.Size = new System.Drawing.Size(400, 166);
            this.DetailBox.TabIndex = 2;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(222, 13);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(167, 34);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Artist Name";
            // 
            // DetailPicture
            // 
            this.DetailPicture.Location = new System.Drawing.Point(16, 13);
            this.DetailPicture.Name = "DetailPicture";
            this.DetailPicture.Size = new System.Drawing.Size(200, 200);
            this.DetailPicture.TabIndex = 0;
            this.DetailPicture.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(16, 220);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 27);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Travis Scott";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(428, 13);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(200, 200);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(222, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 200);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(16, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AccessibleName = "New item selection";
            this.miniToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.CanOverflow = false;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.miniToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.miniToolStrip.Location = new System.Drawing.Point(217, 3);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Size = new System.Drawing.Size(800, 25);
            this.miniToolStrip.TabIndex = 8;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DownloadButton,
            this.GoogleButton,
            this.RefreshButton,
            this.SettingsDropDown,
            this.ServicesDropDown,
            this.LocalMusicViewDropdown});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 31);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // DownloadButton
            // 
            this.DownloadButton.Image = global::UMusic.Properties.Resources.Load;
            this.DownloadButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(89, 28);
            this.DownloadButton.Text = "Download";
            this.DownloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // GoogleButton
            // 
            this.GoogleButton.Image = global::UMusic.Properties.Resources.Google;
            this.GoogleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GoogleButton.Name = "GoogleButton";
            this.GoogleButton.Size = new System.Drawing.Size(73, 28);
            this.GoogleButton.Text = "Google";
            this.GoogleButton.Click += new System.EventHandler(this.GoogleButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.RefreshButton.Image = ((System.Drawing.Image)(resources.GetObject("RefreshButton.Image")));
            this.RefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(50, 28);
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // SettingsDropDown
            // 
            this.SettingsDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SettingsDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DiscordRichPresenceButton});
            this.SettingsDropDown.Image = ((System.Drawing.Image)(resources.GetObject("SettingsDropDown.Image")));
            this.SettingsDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SettingsDropDown.Name = "SettingsDropDown";
            this.SettingsDropDown.Size = new System.Drawing.Size(62, 28);
            this.SettingsDropDown.Text = "Settings";
            this.SettingsDropDown.ToolTipText = "Configure settings for UMusic.";
            this.SettingsDropDown.Click += new System.EventHandler(this.SettingsDropDown_Click);
            // 
            // DiscordRichPresenceButton
            // 
            this.DiscordRichPresenceButton.Name = "DiscordRichPresenceButton";
            this.DiscordRichPresenceButton.Size = new System.Drawing.Size(190, 22);
            this.DiscordRichPresenceButton.Text = "Discord Rich Presence";
            this.DiscordRichPresenceButton.ToolTipText = "Enables or disables Discord Rich Presence. This will display information about yo" +
    "ur music listening on your Discord profile.";
            this.DiscordRichPresenceButton.Click += new System.EventHandler(this.DiscordRichPresenceButton_Click);
            // 
            // ServicesDropDown
            // 
            this.ServicesDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ServicesDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UMusicButton,
            this.SoundCloudButton,
            this.SpotifyButton,
            this.YouTubeButton,
            this.YouTubeMusicButton});
            this.ServicesDropDown.Image = ((System.Drawing.Image)(resources.GetObject("ServicesDropDown.Image")));
            this.ServicesDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ServicesDropDown.Name = "ServicesDropDown";
            this.ServicesDropDown.Size = new System.Drawing.Size(62, 28);
            this.ServicesDropDown.Text = "Services";
            this.ServicesDropDown.ToolTipText = "Change which service you would like to use.";
            // 
            // UMusicButton
            // 
            this.UMusicButton.Image = global::UMusic.Properties.Resources.logo;
            this.UMusicButton.Name = "UMusicButton";
            this.UMusicButton.Size = new System.Drawing.Size(155, 22);
            this.UMusicButton.Text = "UMusic (Local)";
            this.UMusicButton.Click += new System.EventHandler(this.UMusicButton_Click);
            // 
            // SoundCloudButton
            // 
            this.SoundCloudButton.Image = global::UMusic.Properties.Resources.SoundCloud;
            this.SoundCloudButton.Name = "SoundCloudButton";
            this.SoundCloudButton.Size = new System.Drawing.Size(155, 22);
            this.SoundCloudButton.Text = "SoundCloud";
            this.SoundCloudButton.Click += new System.EventHandler(this.SoundCloudButton_Click);
            // 
            // SpotifyButton
            // 
            this.SpotifyButton.Image = global::UMusic.Properties.Resources.Spotify;
            this.SpotifyButton.Name = "SpotifyButton";
            this.SpotifyButton.Size = new System.Drawing.Size(155, 22);
            this.SpotifyButton.Text = "Spotify";
            this.SpotifyButton.Click += new System.EventHandler(this.SpotifyButton_Click);
            // 
            // YouTubeButton
            // 
            this.YouTubeButton.Image = global::UMusic.Properties.Resources.YouTube;
            this.YouTubeButton.Name = "YouTubeButton";
            this.YouTubeButton.Size = new System.Drawing.Size(155, 22);
            this.YouTubeButton.Text = "YouTube";
            this.YouTubeButton.Click += new System.EventHandler(this.YouTubeButton_Click);
            // 
            // YouTubeMusicButton
            // 
            this.YouTubeMusicButton.Image = global::UMusic.Properties.Resources.YouTube_Music;
            this.YouTubeMusicButton.Name = "YouTubeMusicButton";
            this.YouTubeMusicButton.Size = new System.Drawing.Size(155, 22);
            this.YouTubeMusicButton.Text = "YouTube Music";
            this.YouTubeMusicButton.Click += new System.EventHandler(this.YouTubeMusicButton_Click);
            // 
            // LocalMusicViewDropdown
            // 
            this.LocalMusicViewDropdown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.LocalMusicViewDropdown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LayoutDropDown});
            this.LocalMusicViewDropdown.Image = ((System.Drawing.Image)(resources.GetObject("LocalMusicViewDropdown.Image")));
            this.LocalMusicViewDropdown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LocalMusicViewDropdown.Name = "LocalMusicViewDropdown";
            this.LocalMusicViewDropdown.Size = new System.Drawing.Size(45, 28);
            this.LocalMusicViewDropdown.Text = "View";
            this.LocalMusicViewDropdown.ToolTipText = "Determine which layout you would like to use for your local music.";
            // 
            // LayoutDropDown
            // 
            this.LayoutDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LayoutListButton,
            this.LayoutGridButton});
            this.LayoutDropDown.Name = "LayoutDropDown";
            this.LayoutDropDown.Size = new System.Drawing.Size(110, 22);
            this.LayoutDropDown.Text = "Layout";
            // 
            // LayoutListButton
            // 
            this.LayoutListButton.Name = "LayoutListButton";
            this.LayoutListButton.Size = new System.Drawing.Size(96, 22);
            this.LayoutListButton.Text = "List";
            this.LayoutListButton.Click += new System.EventHandler(this.LayoutListButton_Click);
            // 
            // LayoutGridButton
            // 
            this.LayoutGridButton.Name = "LayoutGridButton";
            this.LayoutGridButton.Size = new System.Drawing.Size(96, 22);
            this.LayoutGridButton.Text = "Grid";
            this.LayoutGridButton.Click += new System.EventHandler(this.LayoutGridButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.LocalPanel);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "UMusic";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.LocalContextMenu.ResumeLayout(false);
            this.LocalPanel.ResumeLayout(false);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.BrowserDock.ResumeLayout(false);
            this.GridPanel.ResumeLayout(false);
            this.GridPanel.PerformLayout();
            this.DetailPanel.ResumeLayout(false);
            this.DetailPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetailPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Panel LocalPanel;
        private System.Windows.Forms.Panel BrowserDock;
        private System.Windows.Forms.ContextMenuStrip LocalContextMenu;
        private System.Windows.Forms.ToolStripMenuItem addToQueueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editTagsToolStripMenuItem;
        private System.Windows.Forms.ToolStrip miniToolStrip;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton DownloadButton;
        private System.Windows.Forms.ToolStripButton GoogleButton;
        private System.Windows.Forms.ToolStripDropDownButton ServicesDropDown;
        private System.Windows.Forms.ToolStripMenuItem UMusicButton;
        private System.Windows.Forms.ToolStripMenuItem SoundCloudButton;
        private System.Windows.Forms.ToolStripMenuItem SpotifyButton;
        private System.Windows.Forms.ToolStripMenuItem YouTubeButton;
        private System.Windows.Forms.ToolStripMenuItem YouTubeMusicButton;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.ToolStripDropDownButton LocalMusicViewDropdown;
        private System.Windows.Forms.ToolStripMenuItem LayoutDropDown;
        private System.Windows.Forms.ToolStripMenuItem LayoutListButton;
        private System.Windows.Forms.ToolStripMenuItem LayoutGridButton;
        private System.Windows.Forms.Button PlayAllButton;
        private System.Windows.Forms.Button PlaylistsButton;
        private System.Windows.Forms.Button GenresButton;
        private System.Windows.Forms.Button AlbumsButton;
        private System.Windows.Forms.Button ArtistsButton;
        private System.Windows.Forms.Button SongsButton;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Panel GridPanel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel DetailPanel;
        private System.Windows.Forms.PictureBox DetailPicture;
        private System.Windows.Forms.TextBox DetailBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripDropDownButton SettingsDropDown;
        private System.Windows.Forms.ToolStripMenuItem DiscordRichPresenceButton;
        private System.Windows.Forms.ToolStripMenuItem DeleteSongButton;
        private System.Windows.Forms.ToolStripMenuItem AddToPlaylistButton;
    }
}

