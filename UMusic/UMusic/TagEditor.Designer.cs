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
            this.ArtistLabel = new System.Windows.Forms.Label();
            this.AlbumLabel = new System.Windows.Forms.Label();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.ExplicitLabel = new System.Windows.Forms.Label();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.ArtistBox = new System.Windows.Forms.TextBox();
            this.AlbumBox = new System.Windows.Forms.TextBox();
            this.GenreBox = new System.Windows.Forms.TextBox();
            this.YearBox = new System.Windows.Forms.TextBox();
            this.ExplicitBox = new System.Windows.Forms.CheckBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.FileNameBox = new System.Windows.Forms.TextBox();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.AlbumArtBox = new System.Windows.Forms.TextBox();
            this.AlbumArtLabel = new System.Windows.Forms.Label();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.AlbumArtDialog = new System.Windows.Forms.OpenFileDialog();
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
            this.panel1.Controls.Add(this.FileNameLabel);
            this.panel1.Controls.Add(this.AlbumArtLabel);
            this.panel1.Controls.Add(this.ExplicitLabel);
            this.panel1.Controls.Add(this.YearLabel);
            this.panel1.Controls.Add(this.GenreLabel);
            this.panel1.Controls.Add(this.AlbumLabel);
            this.panel1.Controls.Add(this.ArtistLabel);
            this.panel1.Controls.Add(this.TitleLabel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 262);
            this.panel1.TabIndex = 1;
            // 
            // ArtistLabel
            // 
            this.ArtistLabel.AutoSize = true;
            this.ArtistLabel.Location = new System.Drawing.Point(12, 58);
            this.ArtistLabel.Name = "ArtistLabel";
            this.ArtistLabel.Size = new System.Drawing.Size(30, 13);
            this.ArtistLabel.TabIndex = 1;
            this.ArtistLabel.Text = "Artist";
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
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(12, 125);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(36, 13);
            this.GenreLabel.TabIndex = 3;
            this.GenreLabel.Text = "Genre";
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Location = new System.Drawing.Point(12, 158);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(29, 13);
            this.YearLabel.TabIndex = 4;
            this.YearLabel.Text = "Year";
            // 
            // ExplicitLabel
            // 
            this.ExplicitLabel.AutoSize = true;
            this.ExplicitLabel.Location = new System.Drawing.Point(12, 189);
            this.ExplicitLabel.Name = "ExplicitLabel";
            this.ExplicitLabel.Size = new System.Drawing.Size(40, 13);
            this.ExplicitLabel.TabIndex = 5;
            this.ExplicitLabel.Text = "Explicit";
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
            this.GenreBox.Location = new System.Drawing.Point(232, 134);
            this.GenreBox.Name = "GenreBox";
            this.GenreBox.Size = new System.Drawing.Size(249, 20);
            this.GenreBox.TabIndex = 5;
            // 
            // YearBox
            // 
            this.YearBox.Location = new System.Drawing.Point(232, 167);
            this.YearBox.Name = "YearBox";
            this.YearBox.Size = new System.Drawing.Size(249, 20);
            this.YearBox.TabIndex = 6;
            // 
            // ExplicitBox
            // 
            this.ExplicitBox.AutoSize = true;
            this.ExplicitBox.Location = new System.Drawing.Point(321, 201);
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
            this.SubmitButton.Size = new System.Drawing.Size(75, 262);
            this.SubmitButton.TabIndex = 8;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // FileNameBox
            // 
            this.FileNameBox.Location = new System.Drawing.Point(232, 12);
            this.FileNameBox.Name = "FileNameBox";
            this.FileNameBox.Size = new System.Drawing.Size(249, 20);
            this.FileNameBox.TabIndex = 9;
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
            // AlbumArtBox
            // 
            this.AlbumArtBox.Enabled = false;
            this.AlbumArtBox.Location = new System.Drawing.Point(232, 224);
            this.AlbumArtBox.Name = "AlbumArtBox";
            this.AlbumArtBox.Size = new System.Drawing.Size(195, 20);
            this.AlbumArtBox.TabIndex = 8;
            // 
            // AlbumArtLabel
            // 
            this.AlbumArtLabel.AutoSize = true;
            this.AlbumArtLabel.Location = new System.Drawing.Point(13, 215);
            this.AlbumArtLabel.Name = "AlbumArtLabel";
            this.AlbumArtLabel.Size = new System.Drawing.Size(29, 13);
            this.AlbumArtLabel.TabIndex = 7;
            this.AlbumArtLabel.Text = "Year";
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(424, 224);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(57, 20);
            this.BrowseButton.TabIndex = 10;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // TagEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 286);
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
    }
}