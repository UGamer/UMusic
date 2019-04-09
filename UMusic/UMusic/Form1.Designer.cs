namespace UMusic
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DGV = new System.Windows.Forms.DataGridView();
            this.LinksPanel = new System.Windows.Forms.Panel();
            this.LocalPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.LinksPanel.SuspendLayout();
            this.LocalPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(236, 0);
            this.DGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.Size = new System.Drawing.Size(964, 561);
            this.DGV.TabIndex = 0;
            this.DGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellDoubleClick);
            // 
            // LinksPanel
            // 
            this.LinksPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LinksPanel.Controls.Add(this.pictureBox1);
            this.LinksPanel.Location = new System.Drawing.Point(236, 0);
            this.LinksPanel.Name = "LinksPanel";
            this.LinksPanel.Size = new System.Drawing.Size(964, 135);
            this.LinksPanel.TabIndex = 1;
            // 
            // LocalPanel
            // 
            this.LocalPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LocalPanel.Controls.Add(this.DGV);
            this.LocalPanel.Location = new System.Drawing.Point(0, 131);
            this.LocalPanel.Name = "LocalPanel";
            this.LocalPanel.Size = new System.Drawing.Size(1197, 561);
            this.LocalPanel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::UMusic.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(15, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 111);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.LocalPanel);
            this.Controls.Add(this.LinksPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "UMusic";
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.LinksPanel.ResumeLayout(false);
            this.LocalPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Panel LinksPanel;
        private System.Windows.Forms.Panel LocalPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

