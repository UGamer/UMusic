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
            this.AlbumArtBox.Location = new System.Drawing.Point(0, 0);
            this.AlbumArtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AlbumArtBox.Name = "AlbumArtBox";
            this.AlbumArtBox.Size = new System.Drawing.Size(638, 654);
            this.AlbumArtBox.TabIndex = 0;
            this.AlbumArtBox.TabStop = false;
            // 
            // TitlePanel
            // 
            this.TitlePanel.Controls.Add(this.TitleLabel);
            this.TitlePanel.Location = new System.Drawing.Point(668, 20);
            this.TitlePanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(812, 63);
            this.TitlePanel.TabIndex = 1;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(0, 6);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(189, 45);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Song Title";
            this.TitleLabel.UseMnemonic = false;
            // 
            // PlayPauseButton
            // 
            this.PlayPauseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PlayPauseButton.Location = new System.Drawing.Point(842, 597);
            this.PlayPauseButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PlayPauseButton.Name = "PlayPauseButton";
            this.PlayPauseButton.Size = new System.Drawing.Size(75, 77);
            this.PlayPauseButton.TabIndex = 2;
            this.PlayPauseButton.UseVisualStyleBackColor = true;
            this.PlayPauseButton.Click += new System.EventHandler(this.PlayPauseButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(926, 597);
            this.NextButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 77);
            this.NextButton.TabIndex = 3;
            this.NextButton.Text = "--->";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PreviousButton
            // 
            this.PreviousButton.Location = new System.Drawing.Point(759, 597);
            this.PreviousButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(75, 77);
            this.PreviousButton.TabIndex = 4;
            this.PreviousButton.Text = "<---";
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // LoopButton
            // 
            this.LoopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LoopButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.LoopButton.FlatAppearance.BorderSize = 3;
            this.LoopButton.Location = new System.Drawing.Point(1008, 597);
            this.LoopButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoopButton.Name = "LoopButton";
            this.LoopButton.Size = new System.Drawing.Size(75, 77);
            this.LoopButton.TabIndex = 5;
            this.LoopButton.UseVisualStyleBackColor = true;
            this.LoopButton.Click += new System.EventHandler(this.LoopButton_Click);
            // 
            // ShuffleButton
            // 
            this.ShuffleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ShuffleButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.ShuffleButton.FlatAppearance.BorderSize = 3;
            this.ShuffleButton.Location = new System.Drawing.Point(676, 597);
            this.ShuffleButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ShuffleButton.Name = "ShuffleButton";
            this.ShuffleButton.Size = new System.Drawing.Size(75, 77);
            this.ShuffleButton.TabIndex = 6;
            this.ShuffleButton.UseVisualStyleBackColor = true;
            this.ShuffleButton.Click += new System.EventHandler(this.ShuffleButton_Click);
            // 
            // VolumeBar
            // 
            this.VolumeBar.Location = new System.Drawing.Point(1090, 597);
            this.VolumeBar.Maximum = 100;
            this.VolumeBar.Name = "VolumeBar";
            this.VolumeBar.Size = new System.Drawing.Size(172, 69);
            this.VolumeBar.TabIndex = 7;
            this.VolumeBar.Value = 100;
            this.VolumeBar.ValueChanged += new System.EventHandler(this.VolumeBar_ValueChanged);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(676, 520);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(586, 69);
            this.ProgressBar.TabIndex = 8;
            this.ProgressBar.MouseCaptureChanged += new System.EventHandler(this.ProgressBar_MouseCaptureChanged);
            this.ProgressBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBar_MouseDown);
            this.ProgressBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProgressBar_MouseUp);
            // 
            // ArtistPanel
            // 
            this.ArtistPanel.Controls.Add(this.ArtistLabel);
            this.ArtistPanel.Location = new System.Drawing.Point(668, 92);
            this.ArtistPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ArtistPanel.Name = "ArtistPanel";
            this.ArtistPanel.Size = new System.Drawing.Size(812, 46);
            this.ArtistPanel.TabIndex = 2;
            // 
            // ArtistLabel
            // 
            this.ArtistLabel.AutoSize = true;
            this.ArtistLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArtistLabel.Location = new System.Drawing.Point(0, 6);
            this.ArtistLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ArtistLabel.Name = "ArtistLabel";
            this.ArtistLabel.Size = new System.Drawing.Size(74, 30);
            this.ArtistLabel.TabIndex = 0;
            this.ArtistLabel.Text = "Artist";
            this.ArtistLabel.UseMnemonic = false;
            // 
            // CurrentTimeLabel
            // 
            this.CurrentTimeLabel.AutoSize = true;
            this.CurrentTimeLabel.Location = new System.Drawing.Point(687, 568);
            this.CurrentTimeLabel.Name = "CurrentTimeLabel";
            this.CurrentTimeLabel.Size = new System.Drawing.Size(49, 20);
            this.CurrentTimeLabel.TabIndex = 9;
            this.CurrentTimeLabel.Text = "00:00";
            // 
            // TotalLengthLabel
            // 
            this.TotalLengthLabel.AutoSize = true;
            this.TotalLengthLabel.Location = new System.Drawing.Point(1222, 568);
            this.TotalLengthLabel.Name = "TotalLengthLabel";
            this.TotalLengthLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TotalLengthLabel.Size = new System.Drawing.Size(49, 20);
            this.TotalLengthLabel.TabIndex = 10;
            this.TotalLengthLabel.Text = "00:00";
            this.TotalLengthLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MiniPlayerButton
            // 
            this.MiniPlayerButton.Location = new System.Drawing.Point(1404, 597);
            this.MiniPlayerButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MiniPlayerButton.Name = "MiniPlayerButton";
            this.MiniPlayerButton.Size = new System.Drawing.Size(75, 77);
            this.MiniPlayerButton.TabIndex = 12;
            this.MiniPlayerButton.Text = "Mini Player";
            this.MiniPlayerButton.UseVisualStyleBackColor = true;
            this.MiniPlayerButton.Click += new System.EventHandler(this.MiniPlayerButton_Click);
            // 
            // LockButton
            // 
            this.LockButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LockButton.Location = new System.Drawing.Point(1322, 597);
            this.LockButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LockButton.Name = "LockButton";
            this.LockButton.Size = new System.Drawing.Size(75, 77);
            this.LockButton.TabIndex = 11;
            this.LockButton.UseVisualStyleBackColor = true;
            this.LockButton.Click += new System.EventHandler(this.LockButton_Click);
            // 
            // AlbumLabel
            // 
            this.AlbumLabel.AutoSize = true;
            this.AlbumLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlbumLabel.Location = new System.Drawing.Point(0, 6);
            this.AlbumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AlbumLabel.Name = "AlbumLabel";
            this.AlbumLabel.Size = new System.Drawing.Size(88, 30);
            this.AlbumLabel.TabIndex = 0;
            this.AlbumLabel.Text = "Album";
            this.AlbumLabel.UseMnemonic = false;
            // 
            // AlbumPanel
            // 
            this.AlbumPanel.Controls.Add(this.AlbumLabel);
            this.AlbumPanel.Location = new System.Drawing.Point(668, 148);
            this.AlbumPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AlbumPanel.Name = "AlbumPanel";
            this.AlbumPanel.Size = new System.Drawing.Size(812, 46);
            this.AlbumPanel.TabIndex = 3;
            // 
            // GenrePanel
            // 
            this.GenrePanel.Controls.Add(this.GenreLabel);
            this.GenrePanel.Location = new System.Drawing.Point(668, 203);
            this.GenrePanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GenrePanel.Name = "GenrePanel";
            this.GenrePanel.Size = new System.Drawing.Size(812, 46);
            this.GenrePanel.TabIndex = 4;
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreLabel.Location = new System.Drawing.Point(0, 6);
            this.GenreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(68, 25);
            this.GenreLabel.TabIndex = 0;
            this.GenreLabel.Text = "Genre";
            this.GenreLabel.UseMnemonic = false;
            // 
            // PlaylistButton
            // 
            this.PlaylistButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PlaylistButton.Location = new System.Drawing.Point(1404, 511);
            this.PlaylistButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PlaylistButton.Name = "PlaylistButton";
            this.PlaylistButton.Size = new System.Drawing.Size(75, 77);
            this.PlaylistButton.TabIndex = 13;
            this.PlaylistButton.Text = "Show Queue";
            this.PlaylistButton.UseVisualStyleBackColor = true;
            this.PlaylistButton.Click += new System.EventHandler(this.PlaylistButton_Click);
            // 
            // TagEditorButton
            // 
            this.TagEditorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TagEditorButton.Location = new System.Drawing.Point(1322, 511);
            this.TagEditorButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TagEditorButton.Name = "TagEditorButton";
            this.TagEditorButton.Size = new System.Drawing.Size(75, 77);
            this.TagEditorButton.TabIndex = 14;
            this.TagEditorButton.Text = "Tag Editor";
            this.TagEditorButton.UseVisualStyleBackColor = true;
            this.TagEditorButton.Click += new System.EventHandler(this.TagEditorButton_Click);
            // 
            // wplayer
            // 
            this.wplayer.Enabled = true;
            this.wplayer.Location = new System.Drawing.Point(0, 0);
            this.wplayer.MaximumSize = new System.Drawing.Size(638, 654);
            this.wplayer.MinimumSize = new System.Drawing.Size(638, 654);
            this.wplayer.Name = "wplayer";
            this.wplayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wplayer.OcxState")));
            this.wplayer.Size = new System.Drawing.Size(638, 654);
            this.wplayer.TabIndex = 15;
            this.wplayer.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.wplayer);
            this.panel1.Controls.Add(this.AlbumArtBox);
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 654);
            this.panel1.TabIndex = 16;
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1497, 692);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Player";
            this.Text = "Player";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Player_FormClosed);
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
    }
}