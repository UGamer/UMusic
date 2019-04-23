﻿namespace UMusic
{
    partial class PictureEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PictureEditor));
            this.ToolsPanel = new System.Windows.Forms.Panel();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CropBox = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolsPanel
            // 
            this.ToolsPanel.Location = new System.Drawing.Point(13, 13);
            this.ToolsPanel.Name = "ToolsPanel";
            this.ToolsPanel.Size = new System.Drawing.Size(58, 505);
            this.ToolsPanel.TabIndex = 0;
            // 
            // PictureBox
            // 
            this.PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureBox.Location = new System.Drawing.Point(78, 13);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(500, 500);
            this.PictureBox.TabIndex = 1;
            this.PictureBox.TabStop = false;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(78, 525);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(240, 38);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(338, 525);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(240, 38);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // CropBox
            // 
            this.CropBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CropBox.BackColor = System.Drawing.Color.Transparent;
            this.CropBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CropBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CropBox.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.CropBox.ForeColor = System.Drawing.Color.Transparent;
            this.CropBox.Location = new System.Drawing.Point(78, 13);
            this.CropBox.MaximumSize = new System.Drawing.Size(500, 500);
            this.CropBox.MinimumSize = new System.Drawing.Size(10, 10);
            this.CropBox.Name = "CropBox";
            this.CropBox.Size = new System.Drawing.Size(200, 200);
            this.CropBox.TabIndex = 4;
            this.CropBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CropBox_MouseDown);
            this.CropBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CropBox_MouseMove);
            this.CropBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CropBox_MouseUp);
            // 
            // PictureEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 575);
            this.Controls.Add(this.CropBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.ToolsPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PictureEditor";
            this.Text = "Picture Editor";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ToolsPanel;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Panel CropBox;
    }
}