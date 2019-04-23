using MetaBrainz.MusicBrainz;
using MetaBrainz.MusicBrainz.Interfaces;
using MetaBrainz.MusicBrainz.Interfaces.Searches;
using MetaBrainz.MusicBrainz.CoverArt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UMusic
{
    public partial class Database : Form
    {
        TagEditor reference;
        public string queryString;

        public Database(TagEditor reference)
        {
            this.reference = reference;
            InitializeComponent();
        }

        public void FillGrid()
        {
            Query query = new Query("merrekdebolt@gmail.com");
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
            string title = DGV.Rows[e.RowIndex].Cells[0].Value.ToString();
            string artist = DGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            string album = DGV.Rows[e.RowIndex].Cells[2].Value.ToString();
            string albumArtist = DGV.Rows[e.RowIndex].Cells[3].Value.ToString();
            string trackNumber = DGV.Rows[e.RowIndex].Cells[4].Value.ToString();
            string trackCount = DGV.Rows[e.RowIndex].Cells[5].Value.ToString();
            string discNumber = DGV.Rows[e.RowIndex].Cells[6].Value.ToString();
            string discCount = DGV.Rows[e.RowIndex].Cells[7].Value.ToString();
            string genre = DGV.Rows[e.RowIndex].Cells[8].Value.ToString();
            string year = DGV.Rows[e.RowIndex].Cells[9].Value.ToString();

            reference.FillFields(title, artist, album, trackNumber, trackCount, discNumber, discCount, genre, year);
        }
    }
}
