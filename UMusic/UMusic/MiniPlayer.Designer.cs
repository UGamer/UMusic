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
            this.TopText = new System.Windows.Forms.TextBox();
            this.ControlsPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.ControlsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopText
            // 
            this.TopText.Location = new System.Drawing.Point(13, 13);
            this.TopText.Name = "TopText";
            this.TopText.ReadOnly = true;
            this.TopText.Size = new System.Drawing.Size(209, 20);
            this.TopText.TabIndex = 0;
            this.TopText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TopText.Visible = false;
            // 
            // ControlsPanel
            // 
            this.ControlsPanel.Controls.Add(this.button1);
            this.ControlsPanel.Location = new System.Drawing.Point(13, 156);
            this.ControlsPanel.Name = "ControlsPanel";
            this.ControlsPanel.Size = new System.Drawing.Size(209, 43);
            this.ControlsPanel.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MiniPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(234, 211);
            this.Controls.Add(this.ControlsPanel);
            this.Controls.Add(this.TopText);
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
        private System.Windows.Forms.Button button1;
    }
}