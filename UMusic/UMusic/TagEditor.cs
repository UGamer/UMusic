using MetaBrainz.MusicBrainz;
using MetaBrainz.MusicBrainz.Interfaces;
using MetaBrainz.MusicBrainz.Interfaces.Searches;
using MetaBrainz.MusicBrainz.CoverArt;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using TagLib;

namespace UMusic
{
    public partial class TagEditor : Form
    {
        Player reference;
        Form1 main;

        public bool refresh = false;

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

            try { currentFile.Tag.Year = (uint)Convert.ToInt32(YearBox.Text); } catch { }

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
                        reference.wplayer.Ctlcontrols.stop();
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

        private void SearchDatabaseButton_Click(object sender, EventArgs e)
        {
            Query query = new Query("merrekdebolt@gmail.com");
            string queryString = "\"" + TitleBox.Text + "\"" + "\"" + ArtistBox.Text + "\"" + "\"" + AlbumBox.Text + "\"";
            IReadOnlyList<IFoundRecording> results = query.FindRecordings(queryString).Results;

            string[,] twoDResults = new string[results.Count, 12];

            // Each row is a result. Each column is a value to hold.
            // Title, Artist, Album, Album Artist, Track Number, Track Count, Disc Number, Disc Count, Genre, Year, Explicit, Album Art
            for (int index = 0; index < results.Count; index++)
            {
                // Title
                twoDResults[index, 0] = results[index].Title;

                // Artist
                twoDResults[index, 1] = results[index].ArtistCredit[0].Artist.Name;
                if (results[index].ArtistCredit.Count > 1)
                    for (int x = 1; x < results[index].ArtistCredit.Count; x++)
                        twoDResults[index, 1] += " & " + results[index].ArtistCredit[x].Artist.Name;

                // Album
                try { twoDResults[index, 2] = results[index].Releases[0].Title; }
                catch { twoDResults[index, 2] = ""; }
                

                // Album Artist
                twoDResults[index, 3] = twoDResults[index, 1];

                // Track Number
                try { twoDResults[index, 4] = (results[index].Releases[0].Media[0].TrackOffset + 1).ToString(); }
                catch { twoDResults[index, 4] = ""; }

                // Track Count
                try { twoDResults[index, 5] = results[index].Releases[0].Media[0].TrackCount.ToString(); }
                catch { twoDResults[index, 5] = ""; }

                // Disc Number
                twoDResults[index, 6] = "";

                // Disc Count
                try { twoDResults[index, 7] = results[index].Releases[0].Media.Count.ToString(); }
                catch { twoDResults[index, 7] = ""; }

                // Genre
                // twoDResults[index, 4] = results[index].Releases[0].
                twoDResults[index, 8] = "";

                // Year
                try { twoDResults[index, 9] = results[index].Releases[0].ReleaseEvents[0].Date.Year.Value.ToString(); }
                catch { twoDResults[index, 9] = ""; }

                // Explicit
                twoDResults[index, 10] = "False";

                // Album Art
                /*
                Guid mbid = results[index].MbId;
                string id = results[index].
                CoverArt albumArt = new CoverArt("merrekdebolt@gmail.com");
                RawImage albumArtRaw = albumArt.FetchImage(mbid);
                albumArtPath = results[index];
                
                albumArtPath = "";

                else
                {
                    album = results[index].Collections[0].Name;
                    if (results[index].Collections.Count > 1)
                        for (int x = 1; x < results[index].Collections.Count; x++)
                            album += ", " + results[index].Collections[x].Name;
                    album = "";

                    albumArtist = artist;
                    trackNumber = results[index].Media[0].TrackCount;
                    trackCount = results[index].Media[0].TrackCount;
                    discNumber = 1;
                    discCount = results[index].Media[0].Discs.Count;
                }
                */
            }

            AutoCompleteStringCollection autoFillTitle = new AutoCompleteStringCollection();
            for (int index = 0; index < results.Count; index++)
            {
                autoFillTitle.Add(twoDResults[index, 0]);
            }
            TitleBox.AutoCompleteCustomSource = autoFillTitle;

            AutoCompleteStringCollection autoFillArtist = new AutoCompleteStringCollection();
            for (int index = 0; index < results.Count; index++)
            {
                autoFillArtist.Add(twoDResults[index, 1]);
            }
            ArtistBox.AutoCompleteCustomSource = autoFillArtist;

            AutoCompleteStringCollection autoFillAlbum = new AutoCompleteStringCollection();
            for (int index = 0; index < results.Count; index++)
            {
                autoFillAlbum.Add(twoDResults[index, 2]);
            }
            AlbumBox.AutoCompleteCustomSource = autoFillAlbum;
            
            AutoCompleteStringCollection autoFillAlbumArtist = new AutoCompleteStringCollection();
            for (int index = 0; index < results.Count; index++)
            {
                autoFillArtist.Add(twoDResults[index, 3]);
            }
            AlbumArtistBox.AutoCompleteCustomSource = autoFillAlbumArtist;

            /*
            AutoCompleteStringCollection autoFillTrackNumber = new AutoCompleteStringCollection();
            for (int index = 0; index < results.Count; index++)
            {
                autoFillTrackNumber.Add(twoDResults[index, 4]);
            }
            TrackNumberBox.AutoCompleteCustomSource = autoFillTrackNumber;
            */

            AutoCompleteStringCollection autoFillTrackCount = new AutoCompleteStringCollection();
            for (int index = 0; index < results.Count; index++)
            {
                autoFillTrackCount.Add(twoDResults[index, 5]);
            }
            TrackCountBox.AutoCompleteCustomSource = autoFillTrackCount;

            AutoCompleteStringCollection autoFillYear = new AutoCompleteStringCollection();
            for (int index = 0; index < results.Count; index++)
            {
                autoFillYear.Add(twoDResults[index, 9]);
            }
            YearBox.AutoCompleteCustomSource = autoFillYear;

            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Title");
            dataTable.Columns.Add("Artist(s)");
            dataTable.Columns.Add("Album");
            dataTable.Columns.Add("Album Artist(s)");
            dataTable.Columns.Add("Track Number");
            dataTable.Columns.Add("Track Count");
            dataTable.Columns.Add("Disc Number");
            dataTable.Columns.Add("Disc Count");
            dataTable.Columns.Add("Genre");
            dataTable.Columns.Add("Year");
            dataTable.Columns.Add("Explicit");
            dataTable.Columns.Add("Album Art");

            for (int r = 0; r < results.Count; r++)
            {
                DataRow dRow = dataTable.NewRow();
                dRow[0] = twoDResults[r, 0];
                dRow[1] = twoDResults[r, 1];
                dRow[2] = twoDResults[r, 2];
                dRow[3] = twoDResults[r, 3];
                dRow[4] = twoDResults[r, 4];
                dRow[5] = twoDResults[r, 5];
                dRow[6] = twoDResults[r, 6];
                dRow[7] = twoDResults[r, 7];
                dRow[8] = twoDResults[r, 8];
                dRow[9] = twoDResults[r, 9];
                dRow[10] = twoDResults[r, 10];
                dRow[11] = twoDResults[r, 11];
                dataTable.Rows.Add(dRow);
            }

            DGV.DataSource = dataTable;
        }

        private void DGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Title, Artist, Album, Album Artist, Track Number, Track Count, Disc Number, Disc Count, Genre, Year, Explicit, Album Art
            TitleBox.Text = DGV.Rows[e.RowIndex].Cells[0].Value.ToString();
            ArtistBox.Text = DGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            AlbumBox.Text = DGV.Rows[e.RowIndex].Cells[2].Value.ToString();
            AlbumArtistBox.Text = DGV.Rows[e.RowIndex].Cells[3].Value.ToString();
            TrackNumberBox.Text = DGV.Rows[e.RowIndex].Cells[4].Value.ToString();
            TrackCountBox.Text = DGV.Rows[e.RowIndex].Cells[5].Value.ToString();
            DiscNumberBox.Text = DGV.Rows[e.RowIndex].Cells[6].Value.ToString();
            DiscCountBox.Text = DGV.Rows[e.RowIndex].Cells[7].Value.ToString();
            GenreBox.Text = DGV.Rows[e.RowIndex].Cells[8].Value.ToString();
            YearBox.Text = DGV.Rows[e.RowIndex].Cells[9].Value.ToString();

            if (DGV.Rows[e.RowIndex].Cells[10].Value.ToString() == "True")
                ExplicitBox.Checked = true;
            else
                ExplicitBox.Checked = false;
            
            AlbumArtBox.Text = DGV.Rows[e.RowIndex].Cells[11].Value.ToString();
        }

        private void TagEditor_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}