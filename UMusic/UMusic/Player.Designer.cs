namespace UMusic
{
    partial class Player
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Player));
            this.AlbumArtBox = new System.Windows.Forms.PictureBox();
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.PlayPauseButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.LoopButton = new System.Windows.Forms.Button();
            this.ShuffleButton = new System.Windows.Forms.Button();
            this.VolumeBar = new System.Windows.Forms.TrackBar();
            this.ProgressBar = new System.Windows.Forms.TrackBar();
            this.ArtistPanel = new System.Windows.Forms.Panel();
            this.ArtistLabel = new System.Windows.Forms.Label();
            this.CurrentTimeLabel = new System.Windows.Forms.Label();
            this.TotalLengthLabel = new System.Windows.Forms.Label();
            this.MiniPlayerButton = new System.Windows.Forms.Button();
            this.LockButton = new System.Windows.Forms.Button();
            this.AlbumLabel = new System.Windows.Forms.Label();
            this.AlbumPanel = new System.Windows.Forms.Panel();
            this.GenrePanel = new System.Windows.Forms.Panel();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.PlaylistButton = new System.Windows.Forms.Button();
            this.TagEditorButton = new System.Windows.Forms.Button();
            this.wplayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddToPlaylistButton = new System.Windows.Forms.Button();
            this.AddToPlaylistStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AudioVideoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumArtBox)).BeginInit();
            this.TitlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBar)).BeginInit();
            this.ArtistPanel.SuspendLayout();
            this.AlbumPanel.SuspendLayout();
            this.GenrePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wplayer)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AlbumArtBox
            // 
            this.AlbumArtBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AlbumArtBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AlbumArtBox.Location = new System.Drawing.Point(0, 0);
            this.AlbumArtBox.Name = "AlbumArtBox";
            this.AlbumArtBox.Size = new System.Drawing.Size(425, 425);
            this.AlbumArtBox.TabIndex = 0;
            this.AlbumArtBox.TabStop = false;
            // 
            // TitlePanel
            // 
            this.TitlePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TitlePanel.Controls.Add(this.TitleLabel);
            this.TitlePanel.Location = new System.Drawing.Point(445, 13);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(541, 41);
            this.TitlePanel.TabIndex = 1;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(0, 4);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(126, 30);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Song Title";
            this.TitleLabel.UseMnemonic = false;
            // 
            // PlayPauseButton
            // 
            this.PlayPauseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayPauseButton.BackColor = System.Drawing.Color.Black;
            this.PlayPauseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PlayPauseButton.Location = new System.Drawing.Point(561, 388);
            this.PlayPauseButton.Name = "PlayPauseButton";
            this.PlayPauseButton.Size = new System.Drawing.Size(50, 50);
            this.PlayPauseButton.TabIndex = 2;
            this.PlayPauseButton.UseVisualStyleBackColor = false;
            this.PlayPauseButton.Click += new System.EventHandler(this.PlayPauseButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NextButton.BackColor = System.Drawing.Color.Black;
            this.NextButton.ForeColor = System.Drawing.Color.White;
            this.NextButton.Location = new System.Drawing.Point(617, 388);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(50, 50);
            this.NextButton.TabIndex = 3;
            this.NextButton.Text = "--->";
            this.NextButton.UseVisualStyleBackColor = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PreviousButton
            // 
            this.PreviousButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PreviousButton.BackColor = System.Drawing.Color.Black;
            this.PreviousButton.ForeColor = System.Drawing.Color.White;
            this.PreviousButton.Location = new System.Drawing.Point(506, 388);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(50, 50);
            this.PreviousButton.TabIndex = 4;
            this.PreviousButton.Text = "<---";
            this.PreviousButton.UseVisualStyleBackColor = false;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // LoopButton
            // 
            this.LoopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LoopButton.BackColor = System.Drawing.Color.Black;
            this.LoopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LoopButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.LoopButton.FlatAppearance.BorderSize = 3;
            this.LoopButton.Location = new System.Drawing.Point(672, 388);
            this.LoopButton.Name = "LoopButton";
            this.LoopButton.Size = new System.Drawing.Size(50, 50);
            this.LoopButton.TabIndex = 5;
            this.LoopButton.UseVisualStyleBackColor = false;
            this.LoopButton.Click += new System.EventHandler(this.LoopButton_Click);
            // 
            // ShuffleButton
            // 
            this.ShuffleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ShuffleButton.BackColor = System.Drawing.Color.Black;
            this.ShuffleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ShuffleButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.ShuffleButton.FlatAppearance.BorderSize = 3;
            this.ShuffleButton.Location = new System.Drawing.Point(451, 388);
            this.ShuffleButton.Name = "ShuffleButton";
            this.ShuffleButton.Size = new System.Drawing.Size(50, 50);
            this.ShuffleButton.TabIndex = 6;
            this.ShuffleButton.UseVisualStyleBackColor = false;
            this.ShuffleButton.Click += new System.EventHandler(this.ShuffleButton_Click);
            // 
            // VolumeBar
            // 
            this.VolumeBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.VolumeBar.Location = new System.Drawing.Point(727, 388);
            this.VolumeBar.Margin = new System.Windows.Forms.Padding(2);
            this.VolumeBar.Maximum = 100;
            this.VolumeBar.Name = "VolumeBar";
            this.VolumeBar.Size = new System.Drawing.Size(115, 45);
            this.VolumeBar.TabIndex = 7;
            this.VolumeBar.Value = 100;
            this.VolumeBar.ValueChanged += new System.EventHandler(this.VolumeBar_ValueChanged);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressBar.Location = new System.Drawing.Point(451, 338);
            this.ProgressBar.Margin = new System.Windows.Forms.Padding(2);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(391, 45);
            this.ProgressBar.TabIndex = 8;
            this.ProgressBar.MouseCaptureChanged += new System.EventHandler(this.ProgressBar_MouseCaptureChanged);
            this.ProgressBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBar_MouseDown);
            this.ProgressBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProgressBar_MouseUp);
            // 
            // ArtistPanel
            // 
            this.ArtistPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ArtistPanel.Controls.Add(this.ArtistLabel);
            this.ArtistPanel.Location = new System.Drawing.Point(445, 60);
            this.ArtistPanel.Name = "ArtistPanel";
            this.ArtistPanel.Size = new System.Drawing.Size(541, 30);
            this.ArtistPanel.TabIndex = 2;
            // 
            // ArtistLabel
            // 
            this.ArtistLabel.AutoSize = true;
            this.ArtistLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArtistLabel.ForeColor = System.Drawing.Color.White;
            this.ArtistLabel.Location = new System.Drawing.Point(0, 4);
            this.ArtistLabel.Name = "ArtistLabel";
            this.ArtistLabel.Size = new System.Drawing.Size(49, 20);
            this.ArtistLabel.TabIndex = 0;
            this.ArtistLabel.Text = "Artist";
            this.ArtistLabel.UseMnemonic = false;
            // 
            // CurrentTimeLabel
            // 
            this.CurrentTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentTimeLabel.AutoSize = true;
            this.CurrentTimeLabel.ForeColor = System.Drawing.Color.White;
            this.CurrentTimeLabel.Location = new System.Drawing.Point(458, 369);
            this.CurrentTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CurrentTimeLabel.Name = "CurrentTimeLabel";
            this.CurrentTimeLabel.Size = new System.Drawing.Size(34, 13);
            this.CurrentTimeLabel.TabIndex = 9;
            this.CurrentTimeLabel.Text = "00:00";
            // 
            // TotalLengthLabel
            // 
            this.TotalLengthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalLengthLabel.AutoSize = true;
            this.TotalLengthLabel.ForeColor = System.Drawing.Color.White;
            this.TotalLengthLabel.Location = new System.Drawing.Point(815, 369);
            this.TotalLengthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalLengthLabel.Name = "TotalLengthLabel";
            this.TotalLengthLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TotalLengthLabel.Size = new System.Drawing.Size(34, 13);
            this.TotalLengthLabel.TabIndex = 10;
            this.TotalLengthLabel.Text = "00:00";
            this.TotalLengthLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MiniPlayerButton
            // 
            this.MiniPlayerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MiniPlayerButton.BackColor = System.Drawing.Color.Black;
            this.MiniPlayerButton.ForeColor = System.Drawing.Color.White;
            this.MiniPlayerButton.Location = new System.Drawing.Point(936, 388);
            this.MiniPlayerButton.Name = "MiniPlayerButton";
            this.MiniPlayerButton.Size = new System.Drawing.Size(50, 50);
            this.MiniPlayerButton.TabIndex = 12;
            this.MiniPlayerButton.Text = "Mini Player";
            this.MiniPlayerButton.UseVisualStyleBackColor = false;
            this.MiniPlayerButton.Click += new System.EventHandler(this.MiniPlayerButton_Click);
            // 
            // LockButton
            // 
            this.LockButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LockButton.BackColor = System.Drawing.Color.Black;
            this.LockButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LockButton.Location = new System.Drawing.Point(881, 388);
            this.LockButton.Name = "LockButton";
            this.LockButton.Size = new System.Drawing.Size(50, 50);
            this.LockButton.TabIndex = 11;
            this.LockButton.UseVisualStyleBackColor = false;
            this.LockButton.Click += new System.EventHandler(this.LockButton_Click);
            // 
            // AlbumLabel
            // 
            this.AlbumLabel.AutoSize = true;
            this.AlbumLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlbumLabel.ForeColor = System.Drawing.Color.White;
            this.AlbumLabel.Location = new System.Drawing.Point(0, 4);
            this.AlbumLabel.Name = "AlbumLabel";
            this.AlbumLabel.Size = new System.Drawing.Size(59, 20);
            this.AlbumLabel.TabIndex = 0;
            this.AlbumLabel.Text = "Album";
            this.AlbumLabel.UseMnemonic = false;
            // 
            // AlbumPanel
            // 
            this.AlbumPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AlbumPanel.Controls.Add(this.AlbumLabel);
            this.AlbumPanel.Location = new System.Drawing.Point(445, 96);
            this.AlbumPanel.Name = "AlbumPanel";
            this.AlbumPanel.Size = new System.Drawing.Size(541, 30);
            this.AlbumPanel.TabIndex = 3;
            // 
            // GenrePanel
            // 
            this.GenrePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GenrePanel.Controls.Add(this.GenreLabel);
            this.GenrePanel.Location = new System.Drawing.Point(445, 132);
            this.GenrePanel.Name = "GenrePanel";
            this.GenrePanel.Size = new System.Drawing.Size(541, 30);
            this.GenrePanel.TabIndex = 4;
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreLabel.ForeColor = System.Drawing.Color.White;
            this.GenreLabel.Location = new System.Drawing.Point(0, 4);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(45, 17);
            this.GenreLabel.TabIndex = 0;
            this.GenreLabel.Text = "Genre";
            this.GenreLabel.UseMnemonic = false;
            // 
            // PlaylistButton
            // 
            this.PlaylistButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PlaylistButton.BackColor = System.Drawing.Color.Black;
            this.PlaylistButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PlaylistButton.ForeColor = System.Drawing.Color.White;
            this.PlaylistButton.Location = new System.Drawing.Point(936, 332);
            this.PlaylistButton.Name = "PlaylistButton";
            this.PlaylistButton.Size = new System.Drawing.Size(50, 50);
            this.PlaylistButton.TabIndex = 13;
            this.PlaylistButton.Text = "Show Queue";
            this.PlaylistButton.UseVisualStyleBackColor = false;
            this.PlaylistButton.Click += new System.EventHandler(this.PlaylistButton_Click);
            // 
            // TagEditorButton
            // 
            this.TagEditorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TagEditorButton.BackColor = System.Drawing.Color.Black;
            this.TagEditorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TagEditorButton.ForeColor = System.Drawing.Color.White;
            this.TagEditorButton.Location = new System.Drawing.Point(881, 332);
            this.TagEditorButton.Name = "TagEditorButton";
            this.TagEditorButton.Size = new System.Drawing.Size(50, 50);
            this.TagEditorButton.TabIndex = 14;
            this.TagEditorButton.Text = "Edit Tags";
            this.TagEditorButton.UseVisualStyleBackColor = false;
            this.TagEditorButton.Click += new System.EventHandler(this.TagEditorButton_Click);
            // 
            // wplayer
            // 
            this.wplayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wplayer.Enabled = true;
            this.wplayer.Location = new System.Drawing.Point(0, 0);
            this.wplayer.Margin = new System.Windows.Forms.Padding(2);
            this.wplayer.MaximumSize = new System.Drawing.Size(9999, 9999);
            this.wplayer.MinimumSize = new System.Drawing.Size(425, 425);
            this.wplayer.Name = "wplayer";
            this.wplayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wplayer.OcxState")));
            this.wplayer.Size = new System.Drawing.Size(425, 425);
            this.wplayer.TabIndex = 15;
            this.wplayer.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.wplayer);
            this.panel1.Controls.Add(this.AlbumArtBox);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 425);
            this.panel1.TabIndex = 16;
            // 
            // AddToPlaylistButton
            // 
            this.AddToPlaylistButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddToPlaylistButton.BackColor = System.Drawing.Color.Black;
            this.AddToPlaylistButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddToPlaylistButton.ForeColor = System.Drawing.Color.White;
            this.AddToPlaylistButton.Location = new System.Drawing.Point(936, 276);
            this.AddToPlaylistButton.Name = "AddToPlaylistButton";
            this.AddToPlaylistButton.Size = new System.Drawing.Size(50, 50);
            this.AddToPlaylistButton.TabIndex = 17;
            this.AddToPlaylistButton.Text = "Add to Playlist";
            this.AddToPlaylistButton.UseVisualStyleBackColor = false;
            this.AddToPlaylistButton.Click += new System.EventHandler(this.AddToPlaylistButton_Click);
            // 
            // AddToPlaylistStrip
            // 
            this.AddToPlaylistStrip.Name = "AddToPlaylistStrip";
            this.AddToPlaylistStrip.Size = new System.Drawing.Size(61, 4);
            // 
            // AudioVideoButton
            // 
            this.AudioVideoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AudioVideoButton.BackColor = System.Drawing.Color.Black;
            this.AudioVideoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AudioVideoButton.ForeColor = System.Drawing.Color.White;
            this.AudioVideoButton.Location = new System.Drawing.Point(881, 276);
            this.AudioVideoButton.Name = "AudioVideoButton";
            this.AudioVideoButton.Size = new System.Drawing.Size(50, 50);
            this.AudioVideoButton.TabIndex = 18;
            this.AudioVideoButton.Text = "Audio";
            this.AudioVideoButton.UseVisualStyleBackColor = false;
            this.AudioVideoButton.Click += new System.EventHandler(this.AudioVideoButton_Click);
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(998, 450);
            this.Controls.Add(this.AudioVideoButton);
            this.Controls.Add(this.AddToPlaylistButton);
            this.Controls.Add(this.TagEditorButton);
            this.Controls.Add(this.PlaylistButton);
            this.Controls.Add(this.GenrePanel);
            this.Controls.Add(this.AlbumPanel);
            this.Controls.Add(this.MiniPlayerButton);
            this.Controls.Add(this.LockButton);
            this.Controls.Add(this.TotalLengthLabel);
            this.Controls.Add(this.CurrentTimeLabel);
            this.Controls.Add(this.ArtistPanel);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.VolumeBar);
            this.Controls.Add(this.ShuffleButton);
            this.Controls.Add(this.LoopButton);
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.PlayPauseButton);
            this.Controls.Add(this.TitlePanel);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Player";
            this.Text = "Player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Player_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.AlbumArtBox)).EndInit();
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBar)).EndInit();
            this.ArtistPanel.ResumeLayout(false);
            this.ArtistPanel.PerformLayout();
            this.AlbumPanel.ResumeLayout(false);
            this.AlbumPanel.PerformLayout();
            this.GenrePanel.ResumeLayout(false);
            this.GenrePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wplayer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox AlbumArtBox;
        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button PlayPauseButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Button LoopButton;
        private System.Windows.Forms.Button ShuffleButton;
        private System.Windows.Forms.TrackBar VolumeBar;
        private System.Windows.Forms.TrackBar ProgressBar;
        private System.Windows.Forms.Panel ArtistPanel;
        private System.Windows.Forms.Label ArtistLabel;
        private System.Windows.Forms.Label CurrentTimeLabel;
        private System.Windows.Forms.Label TotalLengthLabel;
        private System.Windows.Forms.Button MiniPlayerButton;
        private System.Windows.Forms.Button LockButton;
        private System.Windows.Forms.Label AlbumLabel;
        private System.Windows.Forms.Panel AlbumPanel;
        private System.Windows.Forms.Panel GenrePanel;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.Button PlaylistButton;
        private System.Windows.Forms.Button TagEditorButton;
        public AxWMPLib.AxWindowsMediaPlayer wplayer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddToPlaylistButton;
        private System.Windows.Forms.ContextMenuStrip AddToPlaylistStrip;
        private System.Windows.Forms.Button AudioVideoButton;
    }
}