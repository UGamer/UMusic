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
            this.DGV.Location = new System.Drawing.Point(157, 0);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.Size = new System.Drawing.Size(642, 362);
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
            this.LocalContextMenu.Size = new System.Drawing.Size(149, 26);
            // 
            // addToQueueToolStripMenuItem
            // 
            this.addToQueueToolStripMenuItem.Name = "addToQueueToolStripMenuItem";
            this.addToQueueToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
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
            this.LinksPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LinksPanel.Name = "LinksPanel";
            this.LinksPanel.Size = new System.Drawing.Size(800, 88);
            this.LinksPanel.TabIndex = 1;
            // 
            // DownloadButton
            // 
            this.DownloadButton.Location = new System.Drawing.Point(4, 59);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(28, 18);
            this.DownloadButton.TabIndex = 7;
            this.DownloadButton.Text = "DL";
            this.DownloadButton.UseVisualStyleBackColor = true;
            this.DownloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // GoogleButton
            // 
            this.GoogleButton.Location = new System.Drawing.Point(4, 32);
            this.GoogleButton.Name = "GoogleButton";
            this.GoogleButton.Size = new System.Drawing.Size(28, 18);
            this.GoogleButton.TabIndex = 6;
            this.GoogleButton.Text = "Google";
            this.GoogleButton.UseVisualStyleBackColor = true;
            // 
            // YouTubeBox
            // 
            this.YouTubeBox.BackgroundImage = global::UMusic.Properties.Resources.YouTube;
            this.YouTubeBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.YouTubeBox.Location = new System.Drawing.Point(227, 8);
            this.YouTubeBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.YouTubeBox.Name = "YouTubeBox";
            this.YouTubeBox.Size = new System.Drawing.Size(74, 72);
            this.YouTubeBox.TabIndex = 5;
            this.YouTubeBox.TabStop = false;
            this.YouTubeBox.Click += new System.EventHandler(this.YouTubeBox_Click);
            // 
            // CollapseExtendButton
            // 
            this.CollapseExtendButton.Location = new System.Drawing.Point(4, 8);
            this.CollapseExtendButton.Name = "CollapseExtendButton";
            this.CollapseExtendButton.Size = new System.Drawing.Size(28, 18);
            this.CollapseExtendButton.TabIndex = 4;
            this.CollapseExtendButton.Text = "^";
            this.CollapseExtendButton.UseVisualStyleBackColor = true;
            this.CollapseExtendButton.Click += new System.EventHandler(this.CollapseExpandButton_Click);
            // 
            // SoundCloudPic
            // 
            this.SoundCloudPic.BackgroundImage = global::UMusic.Properties.Resources.SoundCloud;
            this.SoundCloudPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SoundCloudPic.Location = new System.Drawing.Point(415, 8);
            this.SoundCloudPic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.SpotifyPic.Location = new System.Drawing.Point(321, 8);
            this.SpotifyPic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.YouTubeMusicPic.Location = new System.Drawing.Point(131, 8);
            this.YouTubeMusicPic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.UMusicPic.Location = new System.Drawing.Point(37, 8);
            this.UMusicPic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UMusicPic.Name = "UMusicPic";
            this.UMusicPic.Size = new System.Drawing.Size(74, 72);
            this.UMusicPic.TabIndex = 0;
            this.UMusicPic.TabStop = false;
            this.UMusicPic.Click += new System.EventHandler(this.UMusicPic_Click);
            // 
            // LocalPanel
            // 
            this.LocalPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LocalPanel.BackColor = System.Drawing.Color.Black;
            this.LocalPanel.Controls.Add(this.DGV);
            this.LocalPanel.Controls.Add(this.BrowserDock);
            this.LocalPanel.Location = new System.Drawing.Point(0, 88);
            this.LocalPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LocalPanel.Name = "LocalPanel";
            this.LocalPanel.Size = new System.Drawing.Size(800, 362);
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
            this.BrowserDock.Size = new System.Drawing.Size(800, 362);
            this.BrowserDock.TabIndex = 1;
            this.BrowserDock.Visible = false;
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
            this.LocalContextMenu.ResumeLayout(false);
            this.LinksPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.YouTubeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoundCloudPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpotifyPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YouTubeMusicPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UMusicPic)).EndInit();
            this.LocalPanel.ResumeLayout(false);
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
        private System.Windows.Forms.ContextMenuStrip LocalContextMenu;
        private System.Windows.Forms.ToolStripMenuItem addToQueueToolStripMenuItem;
        private System.Windows.Forms.Button CollapseExtendButton;
        private System.Windows.Forms.PictureBox YouTubeBox;
        private System.Windows.Forms.Button DownloadButton;
        private System.Windows.Forms.Button GoogleButton;
    }
}

