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
            this.BrowserDock = new System.Windows.Forms.Panel();
            this.SoundCloudPic = new System.Windows.Forms.PictureBox();
            this.SpotifyPic = new System.Windows.Forms.PictureBox();
            this.YouTubeMusicPic = new System.Windows.Forms.PictureBox();
            this.UMusicPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.LinksPanel.SuspendLayout();
            this.LocalPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SoundCloudPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpotifyPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YouTubeMusicPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UMusicPic)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(157, 0);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.Size = new System.Drawing.Size(643, 365);
            this.DGV.TabIndex = 0;
            this.DGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellDoubleClick);
            // 
            // LinksPanel
            // 
            this.LinksPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LinksPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LinksPanel.Controls.Add(this.SoundCloudPic);
            this.LinksPanel.Controls.Add(this.SpotifyPic);
            this.LinksPanel.Controls.Add(this.YouTubeMusicPic);
            this.LinksPanel.Controls.Add(this.UMusicPic);
            this.LinksPanel.Location = new System.Drawing.Point(0, 0);
            this.LinksPanel.Margin = new System.Windows.Forms.Padding(2);
            this.LinksPanel.Name = "LinksPanel";
            this.LinksPanel.Size = new System.Drawing.Size(800, 88);
            this.LinksPanel.TabIndex = 1;
            // 
            // LocalPanel
            // 
            this.LocalPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LocalPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LocalPanel.Controls.Add(this.BrowserDock);
            this.LocalPanel.Controls.Add(this.DGV);
            this.LocalPanel.Location = new System.Drawing.Point(0, 85);
            this.LocalPanel.Margin = new System.Windows.Forms.Padding(2);
            this.LocalPanel.Name = "LocalPanel";
            this.LocalPanel.Size = new System.Drawing.Size(798, 365);
            this.LocalPanel.TabIndex = 2;
            // 
            // BrowserDock
            // 
            this.BrowserDock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowserDock.BackColor = System.Drawing.Color.White;
            this.BrowserDock.Location = new System.Drawing.Point(0, 0);
            this.BrowserDock.Name = "BrowserDock";
            this.BrowserDock.Size = new System.Drawing.Size(798, 365);
            this.BrowserDock.TabIndex = 1;
            this.BrowserDock.Visible = false;
            // 
            // SoundCloudPic
            // 
            this.SoundCloudPic.BackgroundImage = global::UMusic.Properties.Resources.SoundCloud;
            this.SoundCloudPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SoundCloudPic.Location = new System.Drawing.Point(293, 8);
            this.SoundCloudPic.Margin = new System.Windows.Forms.Padding(2);
            this.SoundCloudPic.Name = "SoundCloudPic";
            this.SoundCloudPic.Size = new System.Drawing.Size(74, 72);
            this.SoundCloudPic.TabIndex = 3;
            this.SoundCloudPic.TabStop = false;
            this.SoundCloudPic.Click += new System.EventHandler(this.SoundCloudPic_Click);
            // 
            // SpotifyPic
            // 
            this.SpotifyPic.BackgroundImage = global::UMusic.Properties.Resources.Spotify;
            this.SpotifyPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SpotifyPic.Location = new System.Drawing.Point(199, 8);
            this.SpotifyPic.Margin = new System.Windows.Forms.Padding(2);
            this.SpotifyPic.Name = "SpotifyPic";
            this.SpotifyPic.Size = new System.Drawing.Size(74, 72);
            this.SpotifyPic.TabIndex = 2;
            this.SpotifyPic.TabStop = false;
            this.SpotifyPic.Click += new System.EventHandler(this.SpotifyPic_Click);
            // 
            // YouTubeMusicPic
            // 
            this.YouTubeMusicPic.BackgroundImage = global::UMusic.Properties.Resources.YouTube_Music;
            this.YouTubeMusicPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.YouTubeMusicPic.Location = new System.Drawing.Point(104, 8);
            this.YouTubeMusicPic.Margin = new System.Windows.Forms.Padding(2);
            this.YouTubeMusicPic.Name = "YouTubeMusicPic";
            this.YouTubeMusicPic.Size = new System.Drawing.Size(74, 72);
            this.YouTubeMusicPic.TabIndex = 1;
            this.YouTubeMusicPic.TabStop = false;
            this.YouTubeMusicPic.Click += new System.EventHandler(this.YouTubeMusicPic_Click);
            // 
            // UMusicPic
            // 
            this.UMusicPic.BackgroundImage = global::UMusic.Properties.Resources.logo;
            this.UMusicPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UMusicPic.Location = new System.Drawing.Point(10, 8);
            this.UMusicPic.Margin = new System.Windows.Forms.Padding(2);
            this.UMusicPic.Name = "UMusicPic";
            this.UMusicPic.Size = new System.Drawing.Size(74, 72);
            this.UMusicPic.TabIndex = 0;
            this.UMusicPic.TabStop = false;
            this.UMusicPic.Click += new System.EventHandler(this.UMusicPic_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LocalPanel);
            this.Controls.Add(this.LinksPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "UMusic";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.LinksPanel.ResumeLayout(false);
            this.LocalPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SoundCloudPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpotifyPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YouTubeMusicPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UMusicPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Panel LinksPanel;
        private System.Windows.Forms.Panel LocalPanel;
        private System.Windows.Forms.PictureBox UMusicPic;
        private System.Windows.Forms.Panel BrowserDock;
        private System.Windows.Forms.PictureBox SoundCloudPic;
        private System.Windows.Forms.PictureBox SpotifyPic;
        private System.Windows.Forms.PictureBox YouTubeMusicPic;
    }
}

