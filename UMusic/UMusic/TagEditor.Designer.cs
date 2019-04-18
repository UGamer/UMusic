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
            this.DiscNumberLabel = new System.Windows.Forms.Label();
            this.TrackNumberLabel = new System.Windows.Forms.Label();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.AlbumArtistLabel = new System.Windows.Forms.Label();
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
            this.AlbumArtistBox = new System.Windows.Forms.TextBox();
            this.TrackNumberBox = new System.Windows.Forms.TextBox();
            this.DiscNumberBox = new System.Windows.Forms.TextBox();
            this.TrackCountBox = new System.Windows.Forms.TextBox();
            this.DiscCountBox = new System.Windows.Forms.TextBox();
            this.SearchDatabaseButton = new System.Windows.Forms.Button();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
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
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
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
            this.panel1.TabIndex = 0;
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
            // TrackNumberLabel
            // 
            this.TrackNumberLabel.AutoSize = true;
            this.TrackNumberLabel.Location = new System.Drawing.Point(12, 150);
            this.TrackNumberLabel.Name = "TrackNumberLabel";
            this.TrackNumberLabel.Size = new System.Drawing.Size(75, 13);
            this.TrackNumberLabel.TabIndex = 15;
            this.TrackNumberLabel.Text = "Track Number";
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
            // AlbumArtistLabel
            // 
            this.AlbumArtistLabel.AutoSize = true;
            this.AlbumArtistLabel.Location = new System.Drawing.Point(12, 121);
            this.AlbumArtistLabel.Name = "AlbumArtistLabel";
            this.AlbumArtistLabel.Size = new System.Drawing.Size(73, 13);
            this.AlbumArtistLabel.TabIndex = 12;
            this.AlbumArtistLabel.Text = "Album Artist(s)";
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
            this.TitleBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TitleBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TitleBox.Location = new System.Drawing.Point(232, 39);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(249, 20);
            this.TitleBox.TabIndex = 2;
            // 
            // ArtistBox
            // 
            this.ArtistBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ArtistBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ArtistBox.Location = new System.Drawing.Point(232, 67);
            this.ArtistBox.Name = "ArtistBox";
            this.ArtistBox.Size = new System.Drawing.Size(249, 20);
            this.ArtistBox.TabIndex = 3;
            // 
            // AlbumBox
            // 
            this.AlbumBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.AlbumBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.AlbumBox.Location = new System.Drawing.Point(232, 101);
            this.AlbumBox.Name = "AlbumBox";
            this.AlbumBox.Size = new System.Drawing.Size(249, 20);
            this.AlbumBox.TabIndex = 4;
            // 
            // GenreBox
            // 
            this.GenreBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.GenreBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.GenreBox.Location = new System.Drawing.Point(232, 210);
            this.GenreBox.Name = "GenreBox";
            this.GenreBox.Size = new System.Drawing.Size(249, 20);
            this.GenreBox.TabIndex = 10;
            // 
            // YearBox
            // 
            this.YearBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.YearBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.YearBox.Location = new System.Drawing.Point(231, 236);
            this.YearBox.Name = "YearBox";
            this.YearBox.Size = new System.Drawing.Size(249, 20);
            this.YearBox.TabIndex = 11;
            // 
            // ExplicitBox
            // 
            this.ExplicitBox.AutoSize = true;
            this.ExplicitBox.Location = new System.Drawing.Point(320, 264);
            this.ExplicitBox.Name = "ExplicitBox";
            this.ExplicitBox.Size = new System.Drawing.Size(59, 17);
            this.ExplicitBox.TabIndex = 12;
            this.ExplicitBox.Text = "Explicit";
            this.ExplicitBox.UseVisualStyleBackColor = true;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(487, 67);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 249);
            this.SubmitButton.TabIndex = 14;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // FileNameBox
            // 
            this.FileNameBox.Location = new System.Drawing.Point(232, 12);
            this.FileNameBox.Name = "FileNameBox";
            this.FileNameBox.Size = new System.Drawing.Size(195, 20);
            this.FileNameBox.TabIndex = 0;
            this.FileNameBox.TabStop = false;
            // 
            // AlbumArtBox
            // 
            this.AlbumArtBox.Location = new System.Drawing.Point(231, 289);
            this.AlbumArtBox.Name = "AlbumArtBox";
            this.AlbumArtBox.Size = new System.Drawing.Size(195, 20);
            this.AlbumArtBox.TabIndex = 0;
            this.AlbumArtBox.TabStop = false;
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(423, 287);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(57, 20);
            this.BrowseButton.TabIndex = 13;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseArtButton_Click);
            // 
            // BrowseFileNameButton
            // 
            this.BrowseFileNameButton.Location = new System.Drawing.Point(424, 10);
            this.BrowseFileNameButton.Name = "BrowseFileNameButton";
            this.BrowseFileNameButton.Size = new System.Drawing.Size(57, 20);
            this.BrowseFileNameButton.TabIndex = 1;
            this.BrowseFileNameButton.Text = "Browse";
            this.BrowseFileNameButton.UseVisualStyleBackColor = true;
            this.BrowseFileNameButton.Click += new System.EventHandler(this.BrowseFileNameButton_Click);
            // 
            // AlbumArtistBox
            // 
            this.AlbumArtistBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.AlbumArtistBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.AlbumArtistBox.Location = new System.Drawing.Point(232, 130);
            this.AlbumArtistBox.Name = "AlbumArtistBox";
            this.AlbumArtistBox.Size = new System.Drawing.Size(249, 20);
            this.AlbumArtistBox.TabIndex = 5;
            // 
            // TrackNumberBox
            // 
            this.TrackNumberBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TrackNumberBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TrackNumberBox.Location = new System.Drawing.Point(232, 159);
            this.TrackNumberBox.Name = "TrackNumberBox";
            this.TrackNumberBox.Size = new System.Drawing.Size(120, 20);
            this.TrackNumberBox.TabIndex = 6;
            // 
            // DiscNumberBox
            // 
            this.DiscNumberBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.DiscNumberBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.DiscNumberBox.Location = new System.Drawing.Point(232, 185);
            this.DiscNumberBox.Name = "DiscNumberBox";
            this.DiscNumberBox.Size = new System.Drawing.Size(120, 20);
            this.DiscNumberBox.TabIndex = 8;
            // 
            // TrackCountBox
            // 
            this.TrackCountBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TrackCountBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TrackCountBox.Location = new System.Drawing.Point(358, 159);
            this.TrackCountBox.Name = "TrackCountBox";
            this.TrackCountBox.Size = new System.Drawing.Size(123, 20);
            this.TrackCountBox.TabIndex = 7;
            // 
            // DiscCountBox
            // 
            this.DiscCountBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.DiscCountBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.DiscCountBox.Location = new System.Drawing.Point(358, 185);
            this.DiscCountBox.Name = "DiscCountBox";
            this.DiscCountBox.Size = new System.Drawing.Size(123, 20);
            this.DiscCountBox.TabIndex = 9;
            // 
            // SearchDatabaseButton
            // 
            this.SearchDatabaseButton.Location = new System.Drawing.Point(487, 8);
            this.SearchDatabaseButton.Margin = new System.Windows.Forms.Padding(2);
            this.SearchDatabaseButton.Name = "SearchDatabaseButton";
            this.SearchDatabaseButton.Size = new System.Drawing.Size(75, 47);
            this.SearchDatabaseButton.TabIndex = 15;
            this.SearchDatabaseButton.Text = "Search Database";
            this.SearchDatabaseButton.UseVisualStyleBackColor = true;
            this.SearchDatabaseButton.Click += new System.EventHandler(this.SearchDatabaseButton_Click);
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(568, 8);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.Size = new System.Drawing.Size(388, 308);
            this.DGV.TabIndex = 16;
            this.DGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellDoubleClick);
            // 
            // TagEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 335);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.SearchDatabaseButton);
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TagEditor_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
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
        private System.Windows.Forms.Button SearchDatabaseButton;
        private System.Windows.Forms.DataGridView DGV;
    }
}