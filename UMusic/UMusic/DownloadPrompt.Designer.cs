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
            this.VideoNameBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DownloadBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DownloadLabel
            // 
            this.DownloadLabel.AutoSize = true;
            this.DownloadLabel.Location = new System.Drawing.Point(53, 25);
            this.DownloadLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DownloadLabel.Name = "DownloadLabel";
            this.DownloadLabel.Size = new System.Drawing.Size(323, 13);
            this.DownloadLabel.TabIndex = 1;
            this.DownloadLabel.Text = "Your download has completed. Which files would you like to keep?";
            // 
            // AudioButton
            // 
            this.AudioButton.Location = new System.Drawing.Point(56, 40);
            this.AudioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AudioButton.Name = "AudioButton";
            this.AudioButton.Size = new System.Drawing.Size(77, 19);
            this.AudioButton.TabIndex = 2;
            this.AudioButton.Text = "Audio";
            this.AudioButton.UseVisualStyleBackColor = true;
            this.AudioButton.Click += new System.EventHandler(this.AudioButton_Click);
            // 
            // VideoButton
            // 
            this.VideoButton.Location = new System.Drawing.Point(137, 40);
            this.VideoButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.VideoButton.Name = "VideoButton";
            this.VideoButton.Size = new System.Drawing.Size(77, 19);
            this.VideoButton.TabIndex = 3;
            this.VideoButton.Text = "Video";
            this.VideoButton.UseVisualStyleBackColor = true;
            this.VideoButton.Click += new System.EventHandler(this.VideoButton_Click);
            // 
            // NeitherButton
            // 
            this.NeitherButton.Location = new System.Drawing.Point(298, 40);
            this.NeitherButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NeitherButton.Name = "NeitherButton";
            this.NeitherButton.Size = new System.Drawing.Size(77, 19);
            this.NeitherButton.TabIndex = 5;
            this.NeitherButton.Text = "Neither";
            this.NeitherButton.UseVisualStyleBackColor = true;
            this.NeitherButton.Click += new System.EventHandler(this.NeitherButton_Click);
            // 
            // BothButton
            // 
            this.BothButton.Location = new System.Drawing.Point(217, 40);
            this.BothButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BothButton.Name = "BothButton";
            this.BothButton.Size = new System.Drawing.Size(77, 19);
            this.BothButton.TabIndex = 4;
            this.BothButton.Text = "Both";
            this.BothButton.UseVisualStyleBackColor = true;
            this.BothButton.Click += new System.EventHandler(this.BothButton_Click);
            // 
            // DownloadBox
            // 
            this.DownloadBox.BackgroundImage = global::UMusic.Properties.Resources.Load;
            this.DownloadBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DownloadBox.Location = new System.Drawing.Point(8, 16);
            this.DownloadBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DownloadBox.Name = "DownloadBox";
            this.DownloadBox.Size = new System.Drawing.Size(40, 36);
            this.DownloadBox.TabIndex = 0;
            this.DownloadBox.TabStop = false;
            // 
            // VideoNameBox
            // 
            this.VideoNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VideoNameBox.Location = new System.Drawing.Point(56, 2);
            this.VideoNameBox.Name = "VideoNameBox";
            this.VideoNameBox.ReadOnly = true;
            this.VideoNameBox.Size = new System.Drawing.Size(319, 13);
            this.VideoNameBox.TabIndex = 6;
            this.VideoNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DownloadPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 79);
            this.Controls.Add(this.VideoNameBox);
            this.Controls.Add(this.NeitherButton);
            this.Controls.Add(this.BothButton);
            this.Controls.Add(this.VideoButton);
            this.Controls.Add(this.AudioButton);
            this.Controls.Add(this.DownloadLabel);
            this.Controls.Add(this.DownloadBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.TextBox VideoNameBox;
    }
}