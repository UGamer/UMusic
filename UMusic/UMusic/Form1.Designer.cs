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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DGV = new System.Windows.Forms.DataGridView();
            this.LocalContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToQueueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LinksPanel = new System.Windows.Forms.Panel();
            this.DownloadButton = new System.Windows.Forms.Button();
            this.GoogleButton = new System.Windows.Forms.Button();
            this.YouTubeBox = new System.Windows.Forms.PictureBox();
            this.CollapseExtendButton = new System.Windows.Forms.Button();
            this.SoundCloudPic = new System.Windows.Forms.PictureBox();
            this.SpotifyPic = new System.Windows.Forms.PictureBox();
            this.YouTubeMusicPic = new System.Windows.Forms.PictureBox();
            this.UMusicPic = new System.Windows.Forms.PictureBox();
            this.LocalPanel = new System.Windows.Forms.Panel();
            this.BrowserDock = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.LocalContextMenu.SuspendLayout();
            this.LinksPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YouTubeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoundCloudPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpotifyPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YouTubeMusicPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UMusicPic)).BeginInit();
            this.LocalPanel.SuspendLayout();
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
            this.DGV.ContextMenuStrip = this.LocalContextMenu;
            this.DGV.Location = new System.Drawing.Point(236, 0);
            this.DGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.Size = new System.Drawing.Size(1108, 562);
            this.DGV.TabIndex = 0;
            this.DGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellDoubleClick);
            this.DGV.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_CellMouseUp);
            // 
            // LocalContextMenu
            // 
            this.LocalContextMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.LocalContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToQueueToolStripMenuItem});
            this.LocalContextMenu.Name = "LocalContextMenu";
            this.LocalContextMenu.Size = new System.Drawing.Size(198, 34);
            // 
            // addToQueueToolStripMenuItem
            // 
            this.addToQueueToolStripMenuItem.Name = "addToQueueToolStripMenuItem";
            this.addToQueueToolStripMenuItem.Size = new System.Drawing.Size(197, 30);
            this.addToQueueToolStripMenuItem.Text = "Add to Queue";
            this.addToQueueToolStripMenuItem.Click += new System.EventHandler(this.addToQueueToolStripMenuItem_Click);
            // 
            // LinksPanel
            // 
            this.LinksPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LinksPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LinksPanel.Controls.Add(this.DownloadButton);
            this.LinksPanel.Controls.Add(this.GoogleButton);
            this.LinksPanel.Controls.Add(this.YouTubeBox);
            this.LinksPanel.Controls.Add(this.CollapseExtendButton);
            this.LinksPanel.Controls.Add(this.SoundCloudPic);
            this.LinksPanel.Controls.Add(this.SpotifyPic);
            this.LinksPanel.Controls.Add(this.YouTubeMusicPic);
            this.LinksPanel.Controls.Add(this.UMusicPic);
            this.LinksPanel.Location = new System.Drawing.Point(0, 0);
            this.LinksPanel.Name = "LinksPanel";
            this.LinksPanel.Size = new System.Drawing.Size(1200, 135);
            this.LinksPanel.TabIndex = 1;
            // 
            // DownloadButton
            // 
            this.DownloadButton.Location = new System.Drawing.Point(6, 91);
            this.DownloadButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(42, 28);
            this.DownloadButton.TabIndex = 7;
            this.DownloadButton.Text = "DL";
            this.DownloadButton.UseVisualStyleBackColor = true;
            this.DownloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // GoogleButton
            // 
            this.GoogleButton.Location = new System.Drawing.Point(6, 50);
            this.GoogleButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GoogleButton.Name = "GoogleButton";
            this.GoogleButton.Size = new System.Drawing.Size(42, 28);
            this.GoogleButton.TabIndex = 6;
            this.GoogleButton.Text = "Google";
            this.GoogleButton.UseVisualStyleBackColor = true;
            // 
            // YouTubeBox
            // 
            this.YouTubeBox.BackgroundImage = global::UMusic.Properties.Resources.YouTube;
            this.YouTubeBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.YouTubeBox.Location = new System.Drawing.Point(340, 12);
            this.YouTubeBox.Name = "YouTubeBox";
            this.YouTubeBox.Size = new System.Drawing.Size(111, 111);
            this.YouTubeBox.TabIndex = 5;
            this.YouTubeBox.TabStop = false;
            this.YouTubeBox.Click += new System.EventHandler(this.YouTubeBox_Click);
            // 
            // CollapseExtendButton
            // 
            this.CollapseExtendButton.Location = new System.Drawing.Point(6, 12);
            this.CollapseExtendButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CollapseExtendButton.Name = "CollapseExtendButton";
            this.CollapseExtendButton.Size = new System.Drawing.Size(42, 28);
            this.CollapseExtendButton.TabIndex = 4;
            this.CollapseExtendButton.Text = "^";
            this.CollapseExtendButton.UseVisualStyleBackColor = true;
            this.CollapseExtendButton.Click += new System.EventHandler(this.CollapseExpandButton_Click);
            // 
            // SoundCloudPic
            // 
            this.SoundCloudPic.BackgroundImage = global::UMusic.Properties.Resources.SoundCloud;
            this.SoundCloudPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SoundCloudPic.Location = new System.Drawing.Point(623, 12);
            this.SoundCloudPic.Name = "SoundCloudPic";
            this.SoundCloudPic.Size = new System.Drawing.Size(111, 111);
            this.SoundCloudPic.TabIndex = 3;
            this.SoundCloudPic.TabStop = false;
            this.SoundCloudPic.Click += new System.EventHandler(this.SoundCloudPic_Click);
            // 
            // SpotifyPic
            // 
            this.SpotifyPic.BackgroundImage = global::UMusic.Properties.Resources.Spotify;
            this.SpotifyPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SpotifyPic.Location = new System.Drawing.Point(482, 12);
            this.SpotifyPic.Name = "SpotifyPic";
            this.SpotifyPic.Size = new System.Drawing.Size(111, 111);
            this.SpotifyPic.TabIndex = 2;
            this.SpotifyPic.TabStop = false;
            this.SpotifyPic.Click += new System.EventHandler(this.SpotifyPic_Click);
            // 
            // YouTubeMusicPic
            // 
            this.YouTubeMusicPic.BackgroundImage = global::UMusic.Properties.Resources.YouTube_Music;
            this.YouTubeMusicPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.YouTubeMusicPic.Location = new System.Drawing.Point(196, 12);
            this.YouTubeMusicPic.Name = "YouTubeMusicPic";
            this.YouTubeMusicPic.Size = new System.Drawing.Size(111, 111);
            this.YouTubeMusicPic.TabIndex = 1;
            this.YouTubeMusicPic.TabStop = false;
            this.YouTubeMusicPic.Click += new System.EventHandler(this.YouTubeMusicPic_Click);
            // 
            // UMusicPic
            // 
            this.UMusicPic.BackgroundImage = global::UMusic.Properties.Resources.logo;
            this.UMusicPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UMusicPic.Location = new System.Drawing.Point(56, 12);
            this.UMusicPic.Name = "UMusicPic";
            this.UMusicPic.Size = new System.Drawing.Size(111, 111);
            this.UMusicPic.TabIndex = 0;
            this.UMusicPic.TabStop = false;
            this.UMusicPic.Click += new System.EventHandler(this.UMusicPic_Click);
            // 
            // LocalPanel
            // 
            this.LocalPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LocalPanel.AutoSize = true;
            this.LocalPanel.BackColor = System.Drawing.Color.Black;
            this.LocalPanel.Controls.Add(this.DGV);
            this.LocalPanel.Controls.Add(this.BrowserDock);
            this.LocalPanel.Location = new System.Drawing.Point(0, 131);
            this.LocalPanel.Name = "LocalPanel";
            this.LocalPanel.Size = new System.Drawing.Size(1340, 562);
            this.LocalPanel.TabIndex = 2;
            // 
            // BrowserDock
            // 
            this.BrowserDock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowserDock.BackColor = System.Drawing.Color.White;
            this.BrowserDock.Location = new System.Drawing.Point(0, 0);
            this.BrowserDock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BrowserDock.Name = "BrowserDock";
            this.BrowserDock.Size = new System.Drawing.Size(1340, 557);
            this.BrowserDock.TabIndex = 1;
            this.BrowserDock.Visible = false;
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.LocalContextMenu.ResumeLayout(false);
            this.LinksPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.YouTubeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoundCloudPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpotifyPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YouTubeMusicPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UMusicPic)).EndInit();
            this.LocalPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.ContextMenuStrip LocalContextMenu;
        private System.Windows.Forms.ToolStripMenuItem addToQueueToolStripMenuItem;
        private System.Windows.Forms.Button CollapseExtendButton;
        private System.Windows.Forms.PictureBox YouTubeBox;
        private System.Windows.Forms.Button DownloadButton;
        private System.Windows.Forms.Button GoogleButton;
    }
}

