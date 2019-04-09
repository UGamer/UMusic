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
            ((System.ComponentModel.ISupportInitialize)(this.AlbumArtBox)).BeginInit();
            this.TitlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBar)).BeginInit();
            this.ArtistPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AlbumArtBox
            // 
            this.AlbumArtBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AlbumArtBox.Location = new System.Drawing.Point(20, 20);
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
            this.TitlePanel.Size = new System.Drawing.Size(744, 63);
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
            this.PlayPauseButton.Location = new System.Drawing.Point(842, 597);
            this.PlayPauseButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PlayPauseButton.Name = "PlayPauseButton";
            this.PlayPauseButton.Size = new System.Drawing.Size(75, 77);
            this.PlayPauseButton.TabIndex = 2;
            this.PlayPauseButton.Text = "Pause";
            this.PlayPauseButton.UseVisualStyleBackColor = true;
            this.PlayPauseButton.Click += new System.EventHandler(this.PlayPauseButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(925, 597);
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
            this.LoopButton.Location = new System.Drawing.Point(1008, 597);
            this.LoopButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoopButton.Name = "LoopButton";
            this.LoopButton.Size = new System.Drawing.Size(75, 77);
            this.LoopButton.TabIndex = 5;
            this.LoopButton.Text = "Not Looping";
            this.LoopButton.UseVisualStyleBackColor = true;
            this.LoopButton.Click += new System.EventHandler(this.LoopButton_Click);
            // 
            // ShuffleButton
            // 
            this.ShuffleButton.Location = new System.Drawing.Point(676, 597);
            this.ShuffleButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ShuffleButton.Name = "ShuffleButton";
            this.ShuffleButton.Size = new System.Drawing.Size(75, 77);
            this.ShuffleButton.TabIndex = 6;
            this.ShuffleButton.Text = "Not Shuffling";
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
            this.ProgressBar.MouseCaptureChanged += new System.EventHandler(this.ProgressBar_ValueChanged);
            // 
            // ArtistPanel
            // 
            this.ArtistPanel.Controls.Add(this.ArtistLabel);
            this.ArtistPanel.Location = new System.Drawing.Point(668, 93);
            this.ArtistPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ArtistPanel.Name = "ArtistPanel";
            this.ArtistPanel.Size = new System.Drawing.Size(744, 46);
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
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 692);
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
            this.Controls.Add(this.AlbumArtBox);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox AlbumArtBox;
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
    }
}