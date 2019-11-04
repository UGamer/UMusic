namespace Animation
{
    partial class LoadingForm
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
            this.CircleBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LoadedBar = new System.Windows.Forms.ProgressBar();
            this.CurrentLoadedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CircleBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CircleBox
            // 
            this.CircleBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CircleBox.Image = global::Animation.Properties.Resources.lg_ring_loading_gif;
            this.CircleBox.Location = new System.Drawing.Point(179, 44);
            this.CircleBox.Name = "CircleBox";
            this.CircleBox.Size = new System.Drawing.Size(70, 70);
            this.CircleBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CircleBox.TabIndex = 0;
            this.CircleBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please wait while we load your music library...";
            // 
            // LoadedBar
            // 
            this.LoadedBar.Location = new System.Drawing.Point(38, 144);
            this.LoadedBar.Name = "LoadedBar";
            this.LoadedBar.Size = new System.Drawing.Size(359, 23);
            this.LoadedBar.TabIndex = 2;
            // 
            // CurrentLoadedLabel
            // 
            this.CurrentLoadedLabel.AutoSize = true;
            this.CurrentLoadedLabel.ForeColor = System.Drawing.Color.White;
            this.CurrentLoadedLabel.Location = new System.Drawing.Point(208, 126);
            this.CurrentLoadedLabel.Name = "CurrentLoadedLabel";
            this.CurrentLoadedLabel.Size = new System.Drawing.Size(13, 13);
            this.CurrentLoadedLabel.TabIndex = 3;
            this.CurrentLoadedLabel.Text = "0";
            this.CurrentLoadedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(429, 179);
            this.Controls.Add(this.CurrentLoadedLabel);
            this.Controls.Add(this.LoadedBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CircleBox);
            this.Name = "LoadingForm";
            this.Text = "LoadingForm";
            ((System.ComponentModel.ISupportInitialize)(this.CircleBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CircleBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar LoadedBar;
        private System.Windows.Forms.Label CurrentLoadedLabel;
    }
}