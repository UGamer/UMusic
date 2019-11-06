using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animation
{
    public partial class LoadingForm : Form
    {
        MainForm Refer;

        public LoadingForm(MainForm refer)
        {
            this.Refer = refer;

            try
            {
                string connectionString = "Data Source=user.db;Version=3;";
                SQLiteConnection con = new SQLiteConnection(connectionString);
                SQLiteCommand selectFoldersCmd = new SQLiteCommand("SELECT * FROM Folders", con);

                SQLiteDataAdapter da;
                con.Open();
                
                selectFoldersCmd.CommandType = CommandType.Text;
                da = new SQLiteDataAdapter(selectFoldersCmd);
                DataTable foldersTable = new DataTable();
                da.Fill(foldersTable);

                con.Close();

                InitializeComponent();

                DataTable musicTable = CreateMusicTable(foldersTable);

                refer.ListDGV.DataSource = musicTable;

                int totalSeconds = 0;
                for (int index = 0; index < musicTable.Rows.Count; index++)
                    totalSeconds += Convert.ToInt32(musicTable.Rows[index]["Duration"].ToString());

                int totalMinutes = totalSeconds / 60;
                totalSeconds %= 60;

                string totalMinutesString = "";
                if (totalMinutes < 10)
                    totalMinutesString = "0";
                totalMinutesString += totalMinutes.ToString();

                string totalSecondsString = "";
                if (totalSeconds < 10)
                    totalSecondsString = "0";
                totalSecondsString += totalSeconds.ToString();

                refer.ListDurationTrackLabel.Text = "Duration: " + totalMinutesString + ":" + totalSecondsString + ", " + musicTable.Rows.Count + " tracks";
            }
            catch
            {
                MessageBox.Show("File \"user.db\" could not be found. To get this file, try redownloading the application. Closing the application.", "Error: File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                refer.Close();
            }
        }

        private DataTable CreateMusicTable(DataTable foldersTable)
        {
            ArrayList files = new ArrayList();
            for (int folderIndex = 0; folderIndex < foldersTable.Rows.Count; folderIndex++)
            {
                try
                {
                    string[] directoryFiles = Directory.GetFiles(foldersTable.Rows[folderIndex][0].ToString());
                    for (int filesIndex = 0; filesIndex < directoryFiles.Length; filesIndex++)
                        files.Add(directoryFiles[filesIndex]);
                }
                catch { }
            }

            LoadedBar.Maximum = files.Count;
            
            DateTime fileCreated;
            TagLib.File currentFile;
            Song song;

            DataTable musicTable = new DataTable();

            musicTable.Columns.Add(" ", typeof(Image));
            musicTable.Columns.Add("Title");
            musicTable.Columns.Add("Artist(s)");
            musicTable.Columns.Add("Album");
            musicTable.Columns.Add("Album Artist(s)");
            musicTable.Columns.Add("Genre");
            musicTable.Columns.Add("Date Added");
            musicTable.Columns.Add("File");
            musicTable.Columns.Add("Duration");
            musicTable.Columns.Add("Object", typeof(Song));

            for (int index = 0; index < files.Count; index++)
            {
                try
                {
                    if (files[index].ToString().IndexOf(".jpg") != -1)
                        continue;

                    song = new Song(files[index].ToString());

                    currentFile = TagLib.File.Create(files[index].ToString());

                    DataRow dRow = musicTable.NewRow();
                    
                    if (currentFile.Tag.Pictures.Length > 0)
                    {
                        MemoryStream mStream = new MemoryStream(currentFile.Tag.Pictures[0].Data.Data);
                        song.AlbumArt = Image.FromStream(mStream);
                        mStream.Dispose();
                    }
                    else
                     try { song.AlbumArt = Image.FromFile(@"resources\DefaultAlbumArt.png"); } catch { }

                    song.Title = currentFile.Tag.Title;
                    if (currentFile.Tag.Title == null)
                    {
                        string fileName = files[index].ToString();
                        for (bool ready = false; ready == false;)
                        {
                            int folderIndex = fileName.IndexOf("\\");
                            if (folderIndex != -1)
                            {
                                fileName = fileName.Substring(folderIndex + 1);
                            }
                            else
                            {
                                fileName = fileName.Substring(0, fileName.Length - 4);
                                ready = true;
                            }
                        }
                        song.Title = fileName;
                    }
                    
                    song.Artist = currentFile.Tag.FirstPerformer;
                    if (currentFile.Tag.Performers.Length > 1)
                    {
                        for (int index2 = 1; index2 < currentFile.Tag.Performers.Length; index2++)
                            song.Artist += " & " + currentFile.Tag.Performers[index2];
                    }

                    song.Album = currentFile.Tag.Album;

                    song.AlbumArtist = currentFile.Tag.FirstAlbumArtist;
                    if (currentFile.Tag.AlbumArtists.Length > 1)
                    {
                        for (int index2 = 1; index2 < currentFile.Tag.AlbumArtists.Length; index2++)
                            song.AlbumArtist += " & " + currentFile.Tag.AlbumArtists[index2];
                    }

                    song.Genre = currentFile.Tag.FirstGenre;
                    if (currentFile.Tag.Genres.Length > 1)
                    {
                        for (int index2 = 1; index2 < currentFile.Tag.Genres.Length; index2++)
                            song.Genre += " & " + currentFile.Tag.Genres[index2];
                    }

                    fileCreated = File.GetCreationTime(files[index].ToString());
                    song.DateAdded = string.Format("{0:00}/{1:00}/{2:00} {3:00}:{4:00}:{5:00}", fileCreated.Year, fileCreated.Month, fileCreated.Day, fileCreated.Hour, fileCreated.Minute, fileCreated.Second);

                    song.Path = files[index].ToString();

                    song.Duration = Convert.ToInt32(currentFile.Properties.Duration.TotalSeconds);

                    dRow[0] = song.AlbumArt;
                    dRow["Title"] = song.Title;
                    dRow["Artist(s)"] = song.Artist;
                    dRow["Album"] = song.Album;
                    dRow["Album Artist(s)"] = song.AlbumArtist;
                    dRow["Genre"] = song.Genre;
                    dRow["Date Added"] = song.DateAdded;
                    dRow["File"] = song.Path;
                    dRow["Duration"] = song.Duration;
                    dRow["Object"] = song;

                    musicTable.Rows.Add(dRow);
                }
                catch (TagLib.UnsupportedFormatException) { }

                LoadedBar.Value = index + 1;
                CurrentLoadedLabel.Text = (index + 1).ToString();
            }

            string[,] twoD = new string[files.Count, 8];

            int height = twoD.GetLength(0);
            int width = twoD.GetLength(1);


            // if (settings.IndexOf("[Album Art]\nVisible = True") != -1)
            // dataTable.Columns.Add("Album Art", typeof(byte[]));

            Refer.ListDGV.DataSource = musicTable;

            Refer.ListDGV.Columns[0].Width = 50;
            ((DataGridViewImageColumn)Refer.ListDGV.Columns[0]).ImageLayout = DataGridViewImageCellLayout.Zoom;

            Refer.ListDGV.Columns["Title"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Refer.ListDGV.Columns["Artist(s)"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Refer.ListDGV.Columns["Album"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Refer.ListDGV.Columns["Album Artist(s)"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Refer.ListDGV.Columns["Genre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Refer.ListDGV.Columns["Date Added"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Refer.ListDGV.Columns["File"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Refer.ListDGV.Columns["Duration"].Visible = false;
            Refer.ListDGV.Columns["Object"].Visible = false;
            
            bool columnFound = false;
            for (int index = 0; index < Refer.ListDGV.Columns.Count && columnFound == false; index++)
            {
                if (Refer.ListDGV.Columns[index].HeaderText == Refer.UserSettings.SortBy)
                {
                    columnFound = true;
                    try
                    {
                        if (Refer.UserSettings.SortOrder == "Ascending")
                            Refer.ListDGV.Sort(Refer.ListDGV.Columns[index], ListSortDirection.Ascending);
                        else
                            Refer.ListDGV.Sort(Refer.ListDGV.Columns[index], ListSortDirection.Descending);
                    }
                    catch { }
                }
            }

            for (int index = 0; index < Refer.ListDGV.Rows.Count; index++)
            {
                if (Refer.ListDGV.Rows[index].Cells["File"].Value.ToString().IndexOf(".jpg") != -1)
                {
                    Refer.ListDGV.Rows.RemoveAt(index);
                    index--;
                }
            }

            this.Close();
            return musicTable;
        }
    }
}
