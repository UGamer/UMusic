namespace UMusic
{
    partial class DownloadPrompt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DownloadPrompt));
            this.DownloadLabel = new System.Windows.Forms.Label();
            this.AudioButton = new System.Windows.Forms.Button();
            this.VideoButton = new System.Windows.Forms.Button();
            this.NeitherButton = new System.Windows.Forms.Button();
            this.BothButton = new System.Windows.Forms.Button();
            this.DownloadBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DownloadBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DownloadLabel
            // 
            this.DownloadLabel.AutoSize = true;
            this.DownloadLabel.Location = new System.Drawing.Point(88, 24);
            this.DownloadLabel.Name = "DownloadLabel";
            this.DownloadLabel.Size = new System.Drawing.Size(474, 20);
            this.DownloadLabel.TabIndex = 1;
            this.DownloadLabel.Text = "Your download has completed. Which files would you like to keep?";
            // 
            // AudioButton
            // 
            this.AudioButton.Location = new System.Drawing.Point(84, 62);
            this.AudioButton.Name = "AudioButton";
            this.AudioButton.Size = new System.Drawing.Size(115, 29);
            this.AudioButton.TabIndex = 2;
            this.AudioButton.Text = "Audio";
            this.AudioButton.UseVisualStyleBackColor = true;
            this.AudioButton.Click += new System.EventHandler(this.AudioButton_Click);
            // 
            // VideoButton
            // 
            this.VideoButton.Location = new System.Drawing.Point(205, 62);
            this.VideoButton.Name = "VideoButton";
            this.VideoButton.Size = new System.Drawing.Size(115, 29);
            this.VideoButton.TabIndex = 3;
            this.VideoButton.Text = "Video";
            this.VideoButton.UseVisualStyleBackColor = true;
            this.VideoButton.Click += new System.EventHandler(this.VideoButton_Click);
            // 
            // NeitherButton
            // 
            this.NeitherButton.Location = new System.Drawing.Point(447, 62);
            this.NeitherButton.Name = "NeitherButton";
            this.NeitherButton.Size = new System.Drawing.Size(115, 29);
            this.NeitherButton.TabIndex = 5;
            this.NeitherButton.Text = "Neither";
            this.NeitherButton.UseVisualStyleBackColor = true;
            this.NeitherButton.Click += new System.EventHandler(this.NeitherButton_Click);
            // 
            // BothButton
            // 
            this.BothButton.Location = new System.Drawing.Point(326, 62);
            this.BothButton.Name = "BothButton";
            this.BothButton.Size = new System.Drawing.Size(115, 29);
            this.BothButton.TabIndex = 4;
            this.BothButton.Text = "Both";
            this.BothButton.UseVisualStyleBackColor = true;
            this.BothButton.Click += new System.EventHandler(this.BothButton_Click);
            // 
            // DownloadBox
            // 
            this.DownloadBox.BackgroundImage = global::UMusic.Properties.Resources.Load;
            this.DownloadBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DownloadBox.Location = new System.Drawing.Point(12, 24);
            this.DownloadBox.Name = "DownloadBox";
            this.DownloadBox.Size = new System.Drawing.Size(60, 56);
            this.DownloadBox.TabIndex = 0;
            this.DownloadBox.TabStop = false;
            // 
            // DownloadPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 122);
            this.Controls.Add(this.NeitherButton);
            this.Controls.Add(this.BothButton);
            this.Controls.Add(this.VideoButton);
            this.Controls.Add(this.AudioButton);
            this.Controls.Add(this.DownloadLabel);
            this.Controls.Add(this.DownloadBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DownloadPrompt";
            this.Text = "Download Complete";
            ((System.ComponentModel.ISupportInitialize)(this.DownloadBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox DownloadBox;
        private System.Windows.Forms.Label DownloadLabel;
        private System.Windows.Forms.Button AudioButton;
        private System.Windows.Forms.Button VideoButton;
        private System.Windows.Forms.Button NeitherButton;
        private System.Windows.Forms.Button BothButton;
    }
}