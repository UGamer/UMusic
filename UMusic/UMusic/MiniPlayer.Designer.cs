﻿namespace UMusic
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
            this.PlayPauseButton = new System.Windows.Forms.Button();
            this.ArtistBox = new System.Windows.Forms.TextBox();
            this.ControlsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopText
            // 
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
            this.ControlsPanel.Controls.Add(this.PlayPauseButton);
            this.ControlsPanel.Location = new System.Drawing.Point(13, 156);
            this.ControlsPanel.Name = "ControlsPanel";
            this.ControlsPanel.Size = new System.Drawing.Size(209, 43);
            this.ControlsPanel.TabIndex = 1;
            this.ControlsPanel.Visible = false;
            this.ControlsPanel.MouseEnter += new System.EventHandler(this.MiniPlayer_MouseEnter);
            this.ControlsPanel.MouseLeave += new System.EventHandler(this.MiniPlayer_MouseLeave);
            // 
            // PlayPauseButton
            // 
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
    }
}