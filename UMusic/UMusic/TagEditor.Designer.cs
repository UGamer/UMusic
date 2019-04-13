namespace UMusic
{
    partial class TagEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TagEditor));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.AlbumArtLabel = new System.Windows.Forms.Label();
            this.ExplicitLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.AlbumLabel = new System.Windows.Forms.Label();
            this.ArtistLabel = new System.Windows.Forms.Label();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.ArtistBox = new System.Windows.Forms.TextBox();
            this.AlbumBox = new System.Windows.Forms.TextBox();
            this.GenreBox = new System.Windows.Forms.TextBox();
            this.YearBox = new System.Windows.Forms.TextBox();
            this.ExplicitBox = new System.Windows.Forms.CheckBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.FileNameBox = new System.Windows.Forms.TextBox();
            this.AlbumArtBox = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.AlbumArtDialog = new System.Windows.Forms.OpenFileDialog();
            this.BrowseFileNameButton = new System.Windows.Forms.Button();
            this.FileNameDialog = new System.Windows.Forms.OpenFileDialog();
            this.AlbumArtistLabel = new System.Windows.Forms.Label();
            this.AlbumArtistBox = new System.Windows.Forms.TextBox();
            this.TrackNumberBox = new System.Windows.Forms.TextBox();
            this.TrackNumberLabel = new System.Windows.Forms.Label();
            this.DiscNumberLabel = new System.Windows.Forms.Label();
            this.DiscNumberBox = new System.Windows.Forms.TextBox();
            this.TrackCountBox = new System.Windows.Forms.TextBox();
            this.DiscCountBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(12, 30);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(27, 13);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Title";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DiscNumberLabel);
            this.panel1.Controls.Add(this.TrackNumberLabel);
            this.panel1.Controls.Add(this.FileNameLabel);
            this.panel1.Controls.Add(this.AlbumArtistLabel);
            this.panel1.Controls.Add(this.AlbumArtLabel);
            this.panel1.Controls.Add(this.ExplicitLabel);
            this.panel1.Controls.Add(this.YearLabel);
            this.panel1.Controls.Add(this.GenreLabel);
            this.panel1.Controls.Add(this.AlbumLabel);
            this.panel1.Controls.Add(this.ArtistLabel);
            this.panel1.Controls.Add(this.TitleLabel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 304);
            this.panel1.TabIndex = 1;
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Location = new System.Drawing.Point(12, 3);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(54, 13);
            this.FileNameLabel.TabIndex = 6;
            this.FileNameLabel.Text = "File Name";
            // 
            // AlbumArtLabel
            // 
            this.AlbumArtLabel.AutoSize = true;
            this.AlbumArtLabel.Location = new System.Drawing.Point(15, 274);
            this.AlbumArtLabel.Name = "AlbumArtLabel";
            this.AlbumArtLabel.Size = new System.Drawing.Size(52, 13);
            this.AlbumArtLabel.TabIndex = 7;
            this.AlbumArtLabel.Text = "Album Art";
            // 
            // ExplicitLabel
            // 
            this.ExplicitLabel.AutoSize = true;
            this.ExplicitLabel.Location = new System.Drawing.Point(14, 248);
            this.ExplicitLabel.Name = "ExplicitLabel";
            this.ExplicitLabel.Size = new System.Drawing.Size(40, 13);
            this.ExplicitLabel.TabIndex = 5;
            this.ExplicitLabel.Text = "Explicit";
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Location = new System.Drawing.Point(14, 223);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(29, 13);
            this.YearLabel.TabIndex = 4;
            this.YearLabel.Text = "Year";
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(12, 201);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(36, 13);
            this.GenreLabel.TabIndex = 3;
            this.GenreLabel.Text = "Genre";
            // 
            // AlbumLabel
            // 
            this.AlbumLabel.AutoSize = true;
            this.AlbumLabel.Location = new System.Drawing.Point(12, 92);
            this.AlbumLabel.Name = "AlbumLabel";
            this.AlbumLabel.Size = new System.Drawing.Size(36, 13);
            this.AlbumLabel.TabIndex = 2;
            this.AlbumLabel.Text = "Album";
            // 
            // ArtistLabel
            // 
            this.ArtistLabel.AutoSize = true;
            this.ArtistLabel.Location = new System.Drawing.Point(12, 58);
            this.ArtistLabel.Name = "ArtistLabel";
            this.ArtistLabel.Size = new System.Drawing.Size(41, 13);
            this.ArtistLabel.TabIndex = 1;
            this.ArtistLabel.Text = "Artist(s)";
            // 
            // TitleBox
            // 
            this.TitleBox.Location = new System.Drawing.Point(232, 39);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(249, 20);
            this.TitleBox.TabIndex = 2;
            // 
            // ArtistBox
            // 
            this.ArtistBox.Location = new System.Drawing.Point(232, 67);
            this.ArtistBox.Name = "ArtistBox";
            this.ArtistBox.Size = new System.Drawing.Size(249, 20);
            this.ArtistBox.TabIndex = 3;
            // 
            // AlbumBox
            // 
            this.AlbumBox.Location = new System.Drawing.Point(232, 101);
            this.AlbumBox.Name = "AlbumBox";
            this.AlbumBox.Size = new System.Drawing.Size(249, 20);
            this.AlbumBox.TabIndex = 4;
            // 
            // GenreBox
            // 
            this.GenreBox.Location = new System.Drawing.Point(232, 210);
            this.GenreBox.Name = "GenreBox";
            this.GenreBox.Size = new System.Drawing.Size(249, 20);
            this.GenreBox.TabIndex = 5;
            // 
            // YearBox
            // 
            this.YearBox.Location = new System.Drawing.Point(231, 236);
            this.YearBox.Name = "YearBox";
            this.YearBox.Size = new System.Drawing.Size(249, 20);
            this.YearBox.TabIndex = 6;
            // 
            // ExplicitBox
            // 
            this.ExplicitBox.AutoSize = true;
            this.ExplicitBox.Location = new System.Drawing.Point(320, 264);
            this.ExplicitBox.Name = "ExplicitBox";
            this.ExplicitBox.Size = new System.Drawing.Size(59, 17);
            this.ExplicitBox.TabIndex = 7;
            this.ExplicitBox.Text = "Explicit";
            this.ExplicitBox.UseVisualStyleBackColor = true;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(487, 12);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 304);
            this.SubmitButton.TabIndex = 8;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // FileNameBox
            // 
            this.FileNameBox.Location = new System.Drawing.Point(232, 12);
            this.FileNameBox.Name = "FileNameBox";
            this.FileNameBox.Size = new System.Drawing.Size(195, 20);
            this.FileNameBox.TabIndex = 9;
            // 
            // AlbumArtBox
            // 
            this.AlbumArtBox.Location = new System.Drawing.Point(231, 289);
            this.AlbumArtBox.Name = "AlbumArtBox";
            this.AlbumArtBox.Size = new System.Drawing.Size(195, 20);
            this.AlbumArtBox.TabIndex = 8;
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(423, 287);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(57, 20);
            this.BrowseButton.TabIndex = 10;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseArtButton_Click);
            // 
            // BrowseFileNameButton
            // 
            this.BrowseFileNameButton.Location = new System.Drawing.Point(424, 10);
            this.BrowseFileNameButton.Name = "BrowseFileNameButton";
            this.BrowseFileNameButton.Size = new System.Drawing.Size(57, 20);
            this.BrowseFileNameButton.TabIndex = 11;
            this.BrowseFileNameButton.Text = "Browse";
            this.BrowseFileNameButton.UseVisualStyleBackColor = true;
            this.BrowseFileNameButton.Click += new System.EventHandler(this.BrowseFileNameButton_Click);
            // 
            // AlbumArtistLabel
            // 
            this.AlbumArtistLabel.AutoSize = true;
            this.AlbumArtistLabel.Location = new System.Drawing.Point(12, 121);
            this.AlbumArtistLabel.Name = "AlbumArtistLabel";
            this.AlbumArtistLabel.Size = new System.Drawing.Size(73, 13);
            this.AlbumArtistLabel.TabIndex = 12;
            this.AlbumArtistLabel.Text = "Album Artist(s)";
            // 
            // AlbumArtistBox
            // 
            this.AlbumArtistBox.Location = new System.Drawing.Point(232, 130);
            this.AlbumArtistBox.Name = "AlbumArtistBox";
            this.AlbumArtistBox.Size = new System.Drawing.Size(249, 20);
            this.AlbumArtistBox.TabIndex = 12;
            // 
            // TrackNumberBox
            // 
            this.TrackNumberBox.Location = new System.Drawing.Point(232, 159);
            this.TrackNumberBox.Name = "TrackNumberBox";
            this.TrackNumberBox.Size = new System.Drawing.Size(120, 20);
            this.TrackNumberBox.TabIndex = 14;
            // 
            // TrackNumberLabel
            // 
            this.TrackNumberLabel.AutoSize = true;
            this.TrackNumberLabel.Location = new System.Drawing.Point(12, 150);
            this.TrackNumberLabel.Name = "TrackNumberLabel";
            this.TrackNumberLabel.Size = new System.Drawing.Size(75, 13);
            this.TrackNumberLabel.TabIndex = 15;
            this.TrackNumberLabel.Text = "Track Number";
            // 
            // DiscNumberLabel
            // 
            this.DiscNumberLabel.AutoSize = true;
            this.DiscNumberLabel.Location = new System.Drawing.Point(13, 176);
            this.DiscNumberLabel.Name = "DiscNumberLabel";
            this.DiscNumberLabel.Size = new System.Drawing.Size(68, 13);
            this.DiscNumberLabel.TabIndex = 17;
            this.DiscNumberLabel.Text = "Disc Number";
            // 
            // DiscNumberBox
            // 
            this.DiscNumberBox.Location = new System.Drawing.Point(232, 185);
            this.DiscNumberBox.Name = "DiscNumberBox";
            this.DiscNumberBox.Size = new System.Drawing.Size(120, 20);
            this.DiscNumberBox.TabIndex = 16;
            // 
            // TrackCountBox
            // 
            this.TrackCountBox.Location = new System.Drawing.Point(358, 159);
            this.TrackCountBox.Name = "TrackCountBox";
            this.TrackCountBox.Size = new System.Drawing.Size(123, 20);
            this.TrackCountBox.TabIndex = 17;
            // 
            // DiscCountBox
            // 
            this.DiscCountBox.Location = new System.Drawing.Point(358, 185);
            this.DiscCountBox.Name = "DiscCountBox";
            this.DiscCountBox.Size = new System.Drawing.Size(123, 20);
            this.DiscCountBox.TabIndex = 18;
            // 
            // TagEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 335);
            this.Controls.Add(this.DiscCountBox);
            this.Controls.Add(this.TrackCountBox);
            this.Controls.Add(this.TrackNumberBox);
            this.Controls.Add(this.DiscNumberBox);
            this.Controls.Add(this.AlbumArtistBox);
            this.Controls.Add(this.BrowseFileNameButton);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.AlbumArtBox);
            this.Controls.Add(this.FileNameBox);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.ExplicitBox);
            this.Controls.Add(this.YearBox);
            this.Controls.Add(this.GenreBox);
            this.Controls.Add(this.AlbumBox);
            this.Controls.Add(this.ArtistBox);
            this.Controls.Add(this.TitleBox);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TagEditor";
            this.Text = "Tag Editor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ExplicitLabel;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.Label AlbumLabel;
        private System.Windows.Forms.Label ArtistLabel;
        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.TextBox ArtistBox;
        private System.Windows.Forms.TextBox AlbumBox;
        private System.Windows.Forms.TextBox GenreBox;
        private System.Windows.Forms.TextBox YearBox;
        private System.Windows.Forms.CheckBox ExplicitBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.TextBox FileNameBox;
        private System.Windows.Forms.Label AlbumArtLabel;
        private System.Windows.Forms.TextBox AlbumArtBox;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.OpenFileDialog AlbumArtDialog;
        private System.Windows.Forms.Button BrowseFileNameButton;
        private System.Windows.Forms.OpenFileDialog FileNameDialog;
        private System.Windows.Forms.Label TrackNumberLabel;
        private System.Windows.Forms.Label AlbumArtistLabel;
        private System.Windows.Forms.TextBox AlbumArtistBox;
        private System.Windows.Forms.TextBox TrackNumberBox;
        private System.Windows.Forms.Label DiscNumberLabel;
        private System.Windows.Forms.TextBox DiscNumberBox;
        private System.Windows.Forms.TextBox TrackCountBox;
        private System.Windows.Forms.TextBox DiscCountBox;
    }
}