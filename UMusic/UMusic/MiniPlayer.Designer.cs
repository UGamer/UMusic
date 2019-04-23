namespace UMusic
{
    partial class MiniPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiniPlayer));
            this.TopText = new System.Windows.Forms.TextBox();
            this.ControlsPanel = new System.Windows.Forms.Panel();
            this.SyncButton = new System.Windows.Forms.Button();
            this.LockButton = new System.Windows.Forms.Button();
            this.PreviousTrackButton = new System.Windows.Forms.Button();
            this.NextTrackButton = new System.Windows.Forms.Button();
            this.PlayPauseButton = new System.Windows.Forms.Button();
            this.ArtistBox = new System.Windows.Forms.TextBox();
            this.ControlsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopText
            // 
            this.TopText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TopText.Enabled = false;
            this.TopText.Location = new System.Drawing.Point(13, 23);
            this.TopText.Name = "TopText";
            this.TopText.ReadOnly = true;
            this.TopText.Size = new System.Drawing.Size(209, 20);
            this.TopText.TabIndex = 0;
            this.TopText.Visible = false;
            this.TopText.MouseEnter += new System.EventHandler(this.MiniPlayer_MouseEnter);
            this.TopText.MouseLeave += new System.EventHandler(this.MiniPlayer_MouseLeave);
            // 
            // ControlsPanel
            // 
            this.ControlsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlsPanel.Controls.Add(this.SyncButton);
            this.ControlsPanel.Controls.Add(this.LockButton);
            this.ControlsPanel.Controls.Add(this.PreviousTrackButton);
            this.ControlsPanel.Controls.Add(this.NextTrackButton);
            this.ControlsPanel.Controls.Add(this.PlayPauseButton);
            this.ControlsPanel.Location = new System.Drawing.Point(13, 156);
            this.ControlsPanel.Name = "ControlsPanel";
            this.ControlsPanel.Size = new System.Drawing.Size(209, 43);
            this.ControlsPanel.TabIndex = 1;
            this.ControlsPanel.Visible = false;
            this.ControlsPanel.MouseEnter += new System.EventHandler(this.MiniPlayer_MouseEnter);
            this.ControlsPanel.MouseLeave += new System.EventHandler(this.MiniPlayer_MouseLeave);
            // 
            // SyncButton
            // 
            this.SyncButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SyncButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SyncButton.BackgroundImage")));
            this.SyncButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SyncButton.Location = new System.Drawing.Point(169, 4);
            this.SyncButton.Name = "SyncButton";
            this.SyncButton.Size = new System.Drawing.Size(36, 36);
            this.SyncButton.TabIndex = 4;
            this.SyncButton.UseVisualStyleBackColor = true;
            this.SyncButton.Click += new System.EventHandler(this.SyncButton_Click);
            // 
            // LockButton
            // 
            this.LockButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LockButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LockButton.Location = new System.Drawing.Point(3, 4);
            this.LockButton.Name = "LockButton";
            this.LockButton.Size = new System.Drawing.Size(36, 36);
            this.LockButton.TabIndex = 3;
            this.LockButton.UseVisualStyleBackColor = true;
            this.LockButton.Click += new System.EventHandler(this.LockButton_Click);
            // 
            // PreviousTrackButton
            // 
            this.PreviousTrackButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PreviousTrackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PreviousTrackButton.Location = new System.Drawing.Point(43, 4);
            this.PreviousTrackButton.Name = "PreviousTrackButton";
            this.PreviousTrackButton.Size = new System.Drawing.Size(36, 36);
            this.PreviousTrackButton.TabIndex = 2;
            this.PreviousTrackButton.Text = "<---";
            this.PreviousTrackButton.UseVisualStyleBackColor = true;
            // 
            // NextTrackButton
            // 
            this.NextTrackButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.NextTrackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NextTrackButton.Location = new System.Drawing.Point(127, 4);
            this.NextTrackButton.Name = "NextTrackButton";
            this.NextTrackButton.Size = new System.Drawing.Size(36, 36);
            this.NextTrackButton.TabIndex = 1;
            this.NextTrackButton.Text = "--->";
            this.NextTrackButton.UseVisualStyleBackColor = true;
            // 
            // PlayPauseButton
            // 
            this.PlayPauseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayPauseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PlayPauseButton.Location = new System.Drawing.Point(85, 4);
            this.PlayPauseButton.Name = "PlayPauseButton";
            this.PlayPauseButton.Size = new System.Drawing.Size(36, 36);
            this.PlayPauseButton.TabIndex = 0;
            this.PlayPauseButton.UseVisualStyleBackColor = true;
            this.PlayPauseButton.Click += new System.EventHandler(this.PlayPauseButton_Click);
            // 
            // ArtistBox
            // 
            this.ArtistBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArtistBox.Enabled = false;
            this.ArtistBox.Location = new System.Drawing.Point(13, 49);
            this.ArtistBox.Name = "ArtistBox";
            this.ArtistBox.ReadOnly = true;
            this.ArtistBox.Size = new System.Drawing.Size(209, 20);
            this.ArtistBox.TabIndex = 2;
            this.ArtistBox.Visible = false;
            this.ArtistBox.MouseEnter += new System.EventHandler(this.MiniPlayer_MouseEnter);
            this.ArtistBox.MouseLeave += new System.EventHandler(this.MiniPlayer_MouseLeave);
            // 
            // MiniPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(234, 211);
            this.Controls.Add(this.ArtistBox);
            this.Controls.Add(this.ControlsPanel);
            this.Controls.Add(this.TopText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MiniPlayer";
            this.Text = "Mini Player";
            this.MouseEnter += new System.EventHandler(this.MiniPlayer_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.MiniPlayer_MouseLeave);
            this.ControlsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TopText;
        private System.Windows.Forms.Panel ControlsPanel;
        public System.Windows.Forms.Button PlayPauseButton;
        private System.Windows.Forms.TextBox ArtistBox;
        public System.Windows.Forms.Button SyncButton;
        public System.Windows.Forms.Button LockButton;
        public System.Windows.Forms.Button PreviousTrackButton;
        public System.Windows.Forms.Button NextTrackButton;
    }
}