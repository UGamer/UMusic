using MetaBrainz.MusicBrainz;
using MetaBrainz.MusicBrainz.Interfaces;
using MetaBrainz.MusicBrainz.Interfaces.Searches;
using MetaBrainz.MusicBrainz.CoverArt;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using TagLib;

namespace UMusic
{
    public partial class TagEditor : Form
    {
        Player reference;
        Form1 main;
        Database databaseWindow;
        TagLib.File currentFile;
        public bool refresh = false;

        string originalFilePath;
        public TagEditor(Player reference, Form1 main)
        {
            this.reference = reference;
            this.main = main;

            InitializeComponent();
            FillFields(reference.wplayer.currentMedia.sourceURL);
            FillList();
        }

        public TagEditor(string filePath, Form1 main)
        {
            this.main = main;

            InitializeComponent();
            FillFields(filePath);
            FillList();
        }

        private void FillList()
        {
            DGV.DataSource = main.DGV.DataSource;
        }

        public void FillFields(string filePath)
        {
            FileNameBox.Text = filePath;
            originalFilePath = filePath;

            currentFile = TagLib.File.Create(originalFilePath);

            TitleBox.Text = currentFile.Tag.Title;

            ArtistBox.Text = currentFile.Tag.FirstPerformer;

            AlbumBox.Text = currentFile.Tag.Album;
            AlbumArtistBox.Text = currentFile.Tag.FirstAlbumArtist;
            TrackNumberBox.Text = currentFile.Tag.Track.ToString();
            TrackCountBox.Text = currentFile.Tag.TrackCount.ToString();
            DiscNumberBox.Text = currentFile.Tag.Disc.ToString();
            DiscCountBox.Text = currentFile.Tag.DiscCount.ToString();

            GenreBox.Text = currentFile.Tag.FirstGenre;

            YearBox.Text = currentFile.Tag.Year.ToString();
            if (YearBox.Text == "0")
                YearBox.Text = "";

            try
            {
                if (currentFile.Tag.Comment.IndexOf("EXPLICIT") != -1)
                    ExplicitBox.Checked = true;
            }
            catch { }

            if (currentFile.Tag.Pictures.Length >= 1)
            {
                AlbumArtBox.Enabled = false;
                BrowseButton.Text = "Clear";
                var bin = (byte[])(currentFile.Tag.Pictures[0].Data.Data);
                AlbumArtPic.BackgroundImage = System.Drawing.Image.FromStream(new MemoryStream(bin)).GetThumbnailImage(500, 500, null, IntPtr.Zero);
            }
            else
            {
                AlbumArtBox.Enabled = true;
                BrowseButton.Text = "Browse";
                AlbumArtPic.BackgroundImage = System.Drawing.Image.FromFile("Resources\\Unknown Album Art.png");
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            TagLib.File currentFile = TagLib.File.Create(originalFilePath);

            currentFile.Tag.Title = TitleBox.Text;
            currentFile.Tag.Performers = new[] { ArtistBox.Text };

            currentFile.Tag.Album = AlbumBox.Text;
            currentFile.Tag.AlbumArtists = new[] { AlbumArtistBox.Text };
            try { currentFile.Tag.Track = (uint)Convert.ToInt32(TrackNumberBox.Text); } catch { }
            try { currentFile.Tag.TrackCount = (uint)Convert.ToInt32(TrackCountBox.Text); } catch { }
            try { currentFile.Tag.Disc = (uint)Convert.ToInt32(DiscNumberBox.Text); } catch { }
            try { currentFile.Tag.DiscCount = (uint)Convert.ToInt32(DiscCountBox.Text); } catch { }
            currentFile.Tag.Genres = new[] { GenreBox.Text };

            try { currentFile.Tag.Year = (uint)Convert.ToInt32(YearBox.Text); } catch { }

            if (BrowseButton.Text == "Clear")
            {
                try
                {
                    currentFile.Tag.Pictures = new[] { new Picture(AlbumArtBox.Text) };
                }
                catch (ArgumentException) { }
            }
            else
            {
                currentFile.Tag.Pictures = new IPicture[0];
            }
            
            if (ExplicitBox.Checked == true)
                currentFile.Tag.Comment = "EXPLICIT";

            try
            {
                currentFile.Save();
                MessageBox.Show("Your file has been successfully tagged.", "Tagging Success");
                try
                {
                    System.IO.File.Copy(originalFilePath, FileNameBox.Text);
                    System.IO.File.Delete(originalFilePath);
                }
                catch { }
                main.GetFiles();
                originalFilePath = FileNameBox.Text;
            }
            catch (IOException)
            {
                string message = "Tagging for \"" + TitleBox.Text + "\" has failed. Would you like to try clearing the queue to tag this song?";
                string caption = "Clear the Queue?";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, caption, buttons);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        reference.wplayer.currentPlaylist.clear();
                        reference.wplayer.Ctlcontrols.stop();
                        currentFile.Save();
                        main.GetFiles();
                    }
                    catch
                    {
                        MessageBox.Show("Could not tag file. Please try closing any external applications that could be using the file, or restart UMusic.", "Tagging Failed");
                    }
                }
            }
        }

        private void BrowseArtButton_Click(object sender, EventArgs e)
        {
            if (BrowseButton.Text == "Browse")
            {
                if (AlbumArtDialog.ShowDialog() == DialogResult.OK)
                {
                    AlbumArtBox.Text = AlbumArtDialog.FileName;
                    AlbumArtPic.BackgroundImage = System.Drawing.Image.FromFile(AlbumArtBox.Text);
                    BrowseButton.Text = "Clear";
                    AlbumArtBox.Enabled = false;
                }
            }
            else
            {
                BrowseButton.Text = "Browse";
                AlbumArtBox.Enabled = true;
                AlbumArtPic.BackgroundImage = System.Drawing.Image.FromFile("Resources\\Unknown Album Art.png");
            }
        }

        private void BrowseFileNameButton_Click(object sender, EventArgs e)
        {
            if (FileNameDialog.ShowDialog() == DialogResult.OK)
            {
                FileNameBox.Text = FileNameDialog.FileName;

                TagLib.File currentFile = TagLib.File.Create(FileNameBox.Text);

                TitleBox.Text = currentFile.Tag.Title;

                ArtistBox.Text = currentFile.Tag.FirstPerformer;

                AlbumBox.Text = currentFile.Tag.Album;
                AlbumArtistBox.Text = currentFile.Tag.FirstAlbumArtist;
                TrackNumberBox.Text = currentFile.Tag.Track.ToString();
                TrackCountBox.Text = currentFile.Tag.TrackCount.ToString();
                DiscNumberBox.Text = currentFile.Tag.Disc.ToString();
                DiscCountBox.Text = currentFile.Tag.DiscCount.ToString();

                GenreBox.Text = currentFile.Tag.FirstGenre;

                YearBox.Text = currentFile.Tag.Year.ToString();

                if (currentFile.Tag.Comment.IndexOf("EXPLICIT") != -1)
                    ExplicitBox.Checked = true;
            }
        }

        private void SearchDatabaseButton_Click(object sender, EventArgs e)
        {
            string queryString = "\"" + TitleBox.Text + "\"" + "\"" + ArtistBox.Text + "\"" + "\"" + AlbumBox.Text + "\"";

            try
            {
                databaseWindow.queryString = queryString;
                databaseWindow.Show();
                databaseWindow.FillGrid();
            }
            catch
            {
                databaseWindow = new Database(this);
                databaseWindow.queryString = queryString;
                databaseWindow.Show();
                databaseWindow.FillGrid();
            }
        }

        public void FillFields(string title, string artist, string album, string trackNumber, string trackCount,
            string discNumber, string discCount, string genre, string year)
        {
            TitleBox.Text = title;
            ArtistBox.Text = artist;
            AlbumBox.Text = album;
            AlbumArtistBox.Text = artist;
            TrackNumberBox.Text = trackNumber;
            TrackCountBox.Text = trackCount;
            DiscNumberBox.Text = discNumber;
            DiscCountBox.Text = discCount;
            GenreBox.Text = genre;
            YearBox.Text = year;
        }

        private void DGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string filePath = DGV.Rows[e.RowIndex].Cells[7].Value.ToString();
            TagLib.File currentFile = TagLib.File.Create(filePath);

            TitleBox.Text = currentFile.Tag.Title;

            ArtistBox.Text = currentFile.Tag.FirstPerformer;

            AlbumBox.Text = currentFile.Tag.Album;
            AlbumArtistBox.Text = currentFile.Tag.FirstAlbumArtist;
            TrackNumberBox.Text = currentFile.Tag.Track.ToString();
            TrackCountBox.Text = currentFile.Tag.TrackCount.ToString();
            DiscNumberBox.Text = currentFile.Tag.Disc.ToString();
            DiscCountBox.Text = currentFile.Tag.DiscCount.ToString();

            GenreBox.Text = currentFile.Tag.FirstGenre;

            YearBox.Text = currentFile.Tag.Year.ToString();
            if (YearBox.Text == "0")
                YearBox.Text = "";

            try
            {
                if (currentFile.Tag.Comment.IndexOf("EXPLICIT") != -1)
                    ExplicitBox.Checked = true;
            }
            catch { }

            if (currentFile.Tag.Pictures.Length >= 1)
            {
                var bin = (byte[])(currentFile.Tag.Pictures[0].Data.Data);
                AlbumArtPic.BackgroundImage = System.Drawing.Image.FromStream(new MemoryStream(bin)).GetThumbnailImage(500, 500, null, IntPtr.Zero);
            }
            else
                AlbumArtPic.BackgroundImage = System.Drawing.Image.FromFile("Resources\\Unknown Album Art.png");
        }

        private void AlbumArtPic_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.PictureBoxContextMenu.Show(this.AlbumArtPic, e.Location);
                PictureBoxContextMenu.Show(Cursor.Position);
            }
        }

        private void EditPictureButton_Click(object sender, EventArgs e)
        {
            PictureEditor pictureEditor = new PictureEditor(AlbumArtPic.BackgroundImage);
            pictureEditor.Show();
        }
    }
}