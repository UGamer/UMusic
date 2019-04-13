using System;
using System.Windows.Forms;
using TagLib;

namespace UMusic
{
    public partial class TagEditor : Form
    {
        Player reference;
        Form1 main;

        public TagEditor(Player reference, Form1 main)
        {
            this.reference = reference;
            this.main = main;

            InitializeComponent();
            FillFields(reference.wplayer.currentMedia.sourceURL);
        }

        public TagEditor(string filePath, Form1 main)
        {
            this.main = main;

            InitializeComponent();
            FillFields(filePath);
        }

        private void FillFields(string filePath)
        {
            FileNameBox.Text = filePath;
            File currentFile = File.Create(filePath);

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
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            File currentFile = File.Create(FileNameBox.Text);

            currentFile.Tag.Title = TitleBox.Text;
            currentFile.Tag.Performers = new[] { ArtistBox.Text };

            currentFile.Tag.Album = AlbumBox.Text;
            currentFile.Tag.AlbumArtists = new[] { AlbumArtistBox.Text };
            try { currentFile.Tag.Track = (uint)Convert.ToInt32(TrackNumberBox.Text); } catch { }
            try { currentFile.Tag.TrackCount = (uint)Convert.ToInt32(TrackCountBox.Text); } catch { }
            try { currentFile.Tag.Disc = (uint)Convert.ToInt32(DiscNumberBox.Text); } catch { }
            try { currentFile.Tag.DiscCount = (uint)Convert.ToInt32(DiscCountBox.Text); } catch { }
            currentFile.Tag.Genres = new[] { GenreBox.Text };

            try { currentFile.Tag.Year = (uint)Convert.ToInt32(YearBox.Text); }  catch { }

            try
            {
                currentFile.Tag.Pictures = new[] { new Picture(AlbumArtBox.Text) };
            }
            catch (ArgumentException) { }
            
            if (ExplicitBox.Checked == true)
                currentFile.Tag.Comment = "EXPLICIT";

            try
            {
                currentFile.Save();
                MessageBox.Show("Your file has been successfully tagged.", "Tagging Success");
                main.GetFiles();
            }
            catch (System.IO.IOException)
            {
                string message = "Tagging for \"" + TitleBox.Text + "\" has failed because the song is currently in use. Would you like to clear the queue to tag this song?";
                string caption = "Tagging Failed";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, caption, buttons);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        reference.wplayer.currentPlaylist.clear();
                        reference.wplayer.controls.stop();
                        currentFile.Save();
                    }
                    catch
                    {
                        MessageBox.Show("Could not find queue. Please close the player manually.", "Queue Clear Failed");
                    }
                }
            }
        }

        private void BrowseArtButton_Click(object sender, EventArgs e)
        {
            if (AlbumArtDialog.ShowDialog() == DialogResult.OK)
            {
                AlbumArtBox.Text = AlbumArtDialog.FileName;
            }
        }

        private void BrowseFileNameButton_Click(object sender, EventArgs e)
        {
            if (FileNameDialog.ShowDialog() == DialogResult.OK)
            {
                FileNameBox.Text = FileNameDialog.FileName;

                File currentFile = File.Create(FileNameBox.Text);

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
    }
}
