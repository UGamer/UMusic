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
            this.components = new System.ComponentModel.Container();
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
            this.AlbumArtPic = new System.Windows.Forms.PictureBox();
            this.PictureBoxContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EditPictureButton = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumArtPic)).BeginInit();
            this.PictureBoxContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(18, 46);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(38, 20);
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
            this.panel1.Location = new System.Drawing.Point(18, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 829);
            this.panel1.TabIndex = 0;
            // 
            // DiscNumberLabel
            // 
            this.DiscNumberLabel.AutoSize = true;
            this.DiscNumberLabel.Location = new System.Drawing.Point(20, 271);
            this.DiscNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DiscNumberLabel.Name = "DiscNumberLabel";
            this.DiscNumberLabel.Size = new System.Drawing.Size(100, 20);
            this.DiscNumberLabel.TabIndex = 17;
            this.DiscNumberLabel.Text = "Disc Number";
            // 
            // TrackNumberLabel
            // 
            this.TrackNumberLabel.AutoSize = true;
            this.TrackNumberLabel.Location = new System.Drawing.Point(18, 231);
            this.TrackNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TrackNumberLabel.Name = "TrackNumberLabel";
            this.TrackNumberLabel.Size = new System.Drawing.Size(108, 20);
            this.TrackNumberLabel.TabIndex = 15;
            this.TrackNumberLabel.Text = "Track Number";
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Location = new System.Drawing.Point(18, 5);
            this.FileNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(80, 20);
            this.FileNameLabel.TabIndex = 6;
            this.FileNameLabel.Text = "File Name";
            // 
            // AlbumArtistLabel
            // 
            this.AlbumArtistLabel.AutoSize = true;
            this.AlbumArtistLabel.Location = new System.Drawing.Point(18, 186);
            this.AlbumArtistLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AlbumArtistLabel.Name = "AlbumArtistLabel";
            this.AlbumArtistLabel.Size = new System.Drawing.Size(113, 20);
            this.AlbumArtistLabel.TabIndex = 12;
            this.AlbumArtistLabel.Text = "Album Artist(s)";
            // 
            // AlbumArtLabel
            // 
            this.AlbumArtLabel.AutoSize = true;
            this.AlbumArtLabel.Location = new System.Drawing.Point(22, 422);
            this.AlbumArtLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AlbumArtLabel.Name = "AlbumArtLabel";
            this.AlbumArtLabel.Size = new System.Drawing.Size(79, 20);
            this.AlbumArtLabel.TabIndex = 7;
            this.AlbumArtLabel.Text = "Album Art";
            // 
            // ExplicitLabel
            // 
            this.ExplicitLabel.AutoSize = true;
            this.ExplicitLabel.Location = new System.Drawing.Point(21, 382);
            this.ExplicitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExplicitLabel.Name = "ExplicitLabel";
            this.ExplicitLabel.Size = new System.Drawing.Size(58, 20);
            this.ExplicitLabel.TabIndex = 5;
            this.ExplicitLabel.Text = "Explicit";
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Location = new System.Drawing.Point(21, 343);
            this.YearLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(43, 20);
            this.YearLabel.TabIndex = 4;
            this.YearLabel.Text = "Year";
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(18, 309);
            this.GenreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(54, 20);
            this.GenreLabel.TabIndex = 3;
            this.GenreLabel.Text = "Genre";
            // 
            // AlbumLabel
            // 
            this.AlbumLabel.AutoSize = true;
            this.AlbumLabel.Location = new System.Drawing.Point(18, 142);
            this.AlbumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AlbumLabel.Name = "AlbumLabel";
            this.AlbumLabel.Size = new System.Drawing.Size(54, 20);
            this.AlbumLabel.TabIndex = 2;
            this.AlbumLabel.Text = "Album";
            // 
            // ArtistLabel
            // 
            this.ArtistLabel.AutoSize = true;
            this.ArtistLabel.Location = new System.Drawing.Point(18, 89);
            this.ArtistLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ArtistLabel.Name = "ArtistLabel";
            this.ArtistLabel.Size = new System.Drawing.Size(64, 20);
            this.ArtistLabel.TabIndex = 1;
            this.ArtistLabel.Text = "Artist(s)";
            // 
            // TitleBox
            // 
            this.TitleBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TitleBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TitleBox.Location = new System.Drawing.Point(348, 60);
            this.TitleBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(372, 26);
            this.TitleBox.TabIndex = 2;
            // 
            // ArtistBox
            // 
            this.ArtistBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ArtistBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ArtistBox.Location = new System.Drawing.Point(348, 103);
            this.ArtistBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ArtistBox.Name = "ArtistBox";
            this.ArtistBox.Size = new System.Drawing.Size(372, 26);
            this.ArtistBox.TabIndex = 3;
            // 
            // AlbumBox
            // 
            this.AlbumBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.AlbumBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.AlbumBox.Location = new System.Drawing.Point(348, 155);
            this.AlbumBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AlbumBox.Name = "AlbumBox";
            this.AlbumBox.Size = new System.Drawing.Size(372, 26);
            this.AlbumBox.TabIndex = 4;
            // 
            // GenreBox
            // 
            this.GenreBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.GenreBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.GenreBox.Location = new System.Drawing.Point(348, 323);
            this.GenreBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GenreBox.Name = "GenreBox";
            this.GenreBox.Size = new System.Drawing.Size(372, 26);
            this.GenreBox.TabIndex = 10;
            // 
            // YearBox
            // 
            this.YearBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.YearBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.YearBox.Location = new System.Drawing.Point(346, 363);
            this.YearBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.YearBox.Name = "YearBox";
            this.YearBox.Size = new System.Drawing.Size(372, 26);
            this.YearBox.TabIndex = 11;
            // 
            // ExplicitBox
            // 
            this.ExplicitBox.AutoSize = true;
            this.ExplicitBox.Location = new System.Drawing.Point(480, 406);
            this.ExplicitBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExplicitBox.Name = "ExplicitBox";
            this.ExplicitBox.Size = new System.Drawing.Size(84, 24);
            this.ExplicitBox.TabIndex = 12;
            this.ExplicitBox.Text = "Explicit";
            this.ExplicitBox.UseVisualStyleBackColor = true;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(537, 788);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(184, 60);
            this.SubmitButton.TabIndex = 14;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // FileNameBox
            // 
            this.FileNameBox.Location = new System.Drawing.Point(348, 18);
            this.FileNameBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FileNameBox.Name = "FileNameBox";
            this.FileNameBox.Size = new System.Drawing.Size(290, 26);
            this.FileNameBox.TabIndex = 0;
            this.FileNameBox.TabStop = false;
            // 
            // AlbumArtBox
            // 
            this.AlbumArtBox.Location = new System.Drawing.Point(346, 445);
            this.AlbumArtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AlbumArtBox.Name = "AlbumArtBox";
            this.AlbumArtBox.Size = new System.Drawing.Size(290, 26);
            this.AlbumArtBox.TabIndex = 0;
            this.AlbumArtBox.TabStop = false;
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(634, 442);
            this.BrowseButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(86, 31);
            this.BrowseButton.TabIndex = 13;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseArtButton_Click);
            // 
            // BrowseFileNameButton
            // 
            this.BrowseFileNameButton.Location = new System.Drawing.Point(636, 15);
            this.BrowseFileNameButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BrowseFileNameButton.Name = "BrowseFileNameButton";
            this.BrowseFileNameButton.Size = new System.Drawing.Size(86, 31);
            this.BrowseFileNameButton.TabIndex = 1;
            this.BrowseFileNameButton.Text = "Browse";
            this.BrowseFileNameButton.UseVisualStyleBackColor = true;
            this.BrowseFileNameButton.Click += new System.EventHandler(this.BrowseFileNameButton_Click);
            // 
            // AlbumArtistBox
            // 
            this.AlbumArtistBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.AlbumArtistBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.AlbumArtistBox.Location = new System.Drawing.Point(348, 200);
            this.AlbumArtistBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AlbumArtistBox.Name = "AlbumArtistBox";
            this.AlbumArtistBox.Size = new System.Drawing.Size(372, 26);
            this.AlbumArtistBox.TabIndex = 5;
            // 
            // TrackNumberBox
            // 
            this.TrackNumberBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TrackNumberBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TrackNumberBox.Location = new System.Drawing.Point(348, 245);
            this.TrackNumberBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TrackNumberBox.Name = "TrackNumberBox";
            this.TrackNumberBox.Size = new System.Drawing.Size(178, 26);
            this.TrackNumberBox.TabIndex = 6;
            // 
            // DiscNumberBox
            // 
            this.DiscNumberBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.DiscNumberBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.DiscNumberBox.Location = new System.Drawing.Point(348, 285);
            this.DiscNumberBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DiscNumberBox.Name = "DiscNumberBox";
            this.DiscNumberBox.Size = new System.Drawing.Size(178, 26);
            this.DiscNumberBox.TabIndex = 8;
            // 
            // TrackCountBox
            // 
            this.TrackCountBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TrackCountBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TrackCountBox.Location = new System.Drawing.Point(537, 245);
            this.TrackCountBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TrackCountBox.Name = "TrackCountBox";
            this.TrackCountBox.Size = new System.Drawing.Size(182, 26);
            this.TrackCountBox.TabIndex = 7;
            // 
            // DiscCountBox
            // 
            this.DiscCountBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.DiscCountBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.DiscCountBox.Location = new System.Drawing.Point(537, 285);
            this.DiscCountBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DiscCountBox.Name = "DiscCountBox";
            this.DiscCountBox.Size = new System.Drawing.Size(182, 26);
            this.DiscCountBox.TabIndex = 9;
            // 
            // SearchDatabaseButton
            // 
            this.SearchDatabaseButton.Location = new System.Drawing.Point(348, 788);
            this.SearchDatabaseButton.Name = "SearchDatabaseButton";
            this.SearchDatabaseButton.Size = new System.Drawing.Size(180, 60);
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
            this.DGV.Location = new System.Drawing.Point(730, 12);
            this.DGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.Size = new System.Drawing.Size(704, 835);
            this.DGV.TabIndex = 16;
            this.DGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellDoubleClick);
            // 
            // AlbumArtPic
            // 
            this.AlbumArtPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AlbumArtPic.ContextMenuStrip = this.PictureBoxContextMenu;
            this.AlbumArtPic.Location = new System.Drawing.Point(396, 488);
            this.AlbumArtPic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AlbumArtPic.Name = "AlbumArtPic";
            this.AlbumArtPic.Size = new System.Drawing.Size(285, 292);
            this.AlbumArtPic.TabIndex = 17;
            this.AlbumArtPic.TabStop = false;
            this.AlbumArtPic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AlbumArtPic_MouseUp);
            // 
            // PictureBoxContextMenu
            // 
            this.PictureBoxContextMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.PictureBoxContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditPictureButton});
            this.PictureBoxContextMenu.Name = "PictureBoxContextMenu";
            this.PictureBoxContextMenu.Size = new System.Drawing.Size(241, 67);
            // 
            // EditPictureButton
            // 
            this.EditPictureButton.Name = "EditPictureButton";
            this.EditPictureButton.Size = new System.Drawing.Size(240, 30);
            this.EditPictureButton.Text = "Edit Picture";
            this.EditPictureButton.Click += new System.EventHandler(this.EditPictureButton_Click);
            // 
            // TagEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 877);
            this.Controls.Add(this.AlbumArtPic);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TagEditor";
            this.Text = "Tag Editor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumArtPic)).EndInit();
            this.PictureBoxContextMenu.ResumeLayout(false);
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
        private System.Windows.Forms.PictureBox AlbumArtPic;
        private System.Windows.Forms.ContextMenuStrip PictureBoxContextMenu;
        private System.Windows.Forms.ToolStripMenuItem EditPictureButton;
    }
}