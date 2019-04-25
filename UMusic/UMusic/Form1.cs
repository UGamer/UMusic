using CefSharp;
using CefSharp.WinForms;
using MediaToolkit;
using MediaToolkit.Model;
using NAudio.Lame;
using NAudio.Wave;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using VideoLibrary;

namespace UMusic
{
    public partial class Form1 : Form
    {
        public ChromiumWebBrowser chromeBrowser;
        Player player;
        string settings;

        bool albumArtVisible;
        bool titleVisible;
        bool artistVisible;
        bool albumVisible;
        bool albumArtistVisible;
        bool genreVisible;
        bool dateAddedVisible;
        bool fileVisible;

        int albumArtIndex;
        int titleIndex;
        int artistIndex;
        int albumindex;
        int albumArtistIndex;
        int genreIndex;
        int dateAddedIndex;
        int fileIndex;

        private string sortColumn;
        string sortOrder;

        System.Windows.Forms.Timer refreshTimer;
        DataTable dataTable;
        
        string downloadLocation;
        Thread downloadThread;
        System.Timers.Timer promptTimer;
        DownloadPrompt downloadPrompt;
        string videoName;

        TagEditor tagEditor;

        string currentLayout;

        string[] folders;
        ArrayList files;

        public Form1()
        {
            InitializeComponent();

            settings = File.ReadAllText("settings.txt", Encoding.UTF8);

            if (settings.IndexOf("DiscordRichPresence=\"Enabled\"") != -1)
                DiscordRichPresenceButton.Checked = true;

            downloadLocation = settings.Substring(settings.IndexOf("DownloadLocation=") + 18);
            downloadLocation = downloadLocation.Substring(0, downloadLocation.IndexOf("\""));

            // if (settings.IndexOf(""))

            string fullFolderList = settings.Substring(settings.IndexOf("[Folders]") + 11);
            fullFolderList = fullFolderList.Substring(0, fullFolderList.IndexOf("[Local Music]") - 2);

            // Takes the folders list and divides all of the folders up into the string array, "folders".
            int count = 0;
            int i = 0;
            string pattern = "\n";
            while ((i = fullFolderList.IndexOf(pattern, i)) != -1)
            {
                i += pattern.Length;
                count++;
            }

            folders = new string[count];
            string folderListSegment = fullFolderList;
            int newFolderIndex;
            
            for (int index = 0; index < count; index++)
            {
                newFolderIndex = folderListSegment.IndexOf("\n");

                folders[index] = folderListSegment.Substring(folderListSegment.IndexOf("\"") + 1, newFolderIndex);
                folders[index] = folders[index].Substring(0, folders[index].IndexOf("\""));

                folderListSegment = folderListSegment.Substring(newFolderIndex + 1);
            }

            GetFiles();

            InitializeBrowser();

            refreshTimer = new System.Windows.Forms.Timer();
            refreshTimer.Interval = 1000;
        }

        public void GetFiles()
        {
            DGV.DataSource = null;
            DGV.Update();
            DGV.Refresh();

            // Takes the "folders" array and gets all of the files from each folder then puts them into the "files" array.
            files = new ArrayList();
            for (int folderIndex = 0; folderIndex < folders.Length; folderIndex++)
            {
                string[] directoryFiles = Directory.GetFiles(folders[folderIndex]);
                for (int filesIndex = 0; filesIndex < directoryFiles.Length; filesIndex++)
                    files.Add(directoryFiles[filesIndex]);
            }

            string[] titles = new string[files.Count];
            string[] artists = new string[files.Count];
            string[] albums = new string[files.Count];
            string[] albumArtists = new string[files.Count];
            string[] genres = new string[files.Count];
            string[] dateAdded = new string[files.Count];

            int index;
            DateTime fileCreated;
            TagLib.File currentFile;
            for (index = 0; index < titles.Length; index++)
            {
                try
                {
                    currentFile = TagLib.File.Create(files[index].ToString());
                    titles[index] = currentFile.Tag.Title;
                    artists[index] = currentFile.Tag.FirstPerformer;
                    albums[index] = currentFile.Tag.Album;
                    albumArtists[index] = currentFile.Tag.FirstAlbumArtist;
                    genres[index] = currentFile.Tag.FirstGenre;
                    fileCreated = File.GetCreationTime(files[index].ToString());
                    dateAdded[index] = string.Format("{0:00}/{1:00}/{2:00} {3:00}:{4:00}:{5:00}", fileCreated.Year,
                        fileCreated.Month, fileCreated.Day, fileCreated.Hour, fileCreated.Minute, fileCreated.Second);
                }
                catch (TagLib.UnsupportedFormatException) { }
            }

            string[,] twoD = new string[files.Count, 8];

            int height = twoD.GetLength(0);
            int width = twoD.GetLength(1);

            dataTable = new DataTable();

            // if (settings.IndexOf("[Album Art]\nVisible = True") != -1)
                dataTable.Columns.Add("Album Art", typeof(byte[]));
            dataTable.Columns.Add("Title");
            dataTable.Columns.Add("Artist(s)");
            dataTable.Columns.Add("Album");
            dataTable.Columns.Add("Album Artist(s)");
            dataTable.Columns.Add("Genre");
            dataTable.Columns.Add("Date Added");
            dataTable.Columns.Add("File");
            for (int r = 0; r < height; r++)
            {
                if (files[r].ToString().IndexOf(".jpg") == -1)
                {
                    twoD[r, 1] = titles[r];
                    twoD[r, 2] = artists[r];
                    twoD[r, 3] = albums[r];
                    twoD[r, 4] = albumArtists[r];
                    twoD[r, 5] = genres[r];
                    twoD[r, 6] = dateAdded[r];
                    twoD[r, 7] = files[r].ToString();

                    if (twoD[r, 1] == null)
                    {
                        string fileName = twoD[r, 7];
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
                        twoD[r, 1] = fileName;
                    }

                    DataRow dRow = dataTable.NewRow();
                    dRow[1] = twoD[r, 1];
                    dRow[2] = twoD[r, 2];
                    dRow[3] = twoD[r, 3];
                    dRow[4] = twoD[r, 4];
                    dRow[5] = twoD[r, 5];
                    dRow[6] = twoD[r, 6];
                    dRow[7] = twoD[r, 7];

                    dataTable.Rows.Add(dRow);
                }

                /*
                Image albumArt = Image.FromFile(@"resources\Unknown Album Art.png");
                Image currentAlbumArt;
                byte[] bin;
                for (int x = 0; x < dataTable.Rows.Count; x++)
                {
                    try
                    {
                        currentFile = TagLib.File.Create(dataTable.Rows[x][7].ToString());
                        if (currentFile.Tag.Pictures.Length > 0)
                        {
                            bin = currentFile.Tag.Pictures[0].Data.Data;
                            currentAlbumArt = Image.FromStream(new MemoryStream(bin)).GetThumbnailImage(500, 500, null, IntPtr.Zero);
                            dataTable.Rows[x][0] = imageToByteArray(currentAlbumArt);
                        }
                        else
                            dataTable.Rows[x][0] = imageToByteArray(albumArt);
                    }
                    catch
                    {
                        dataTable.Rows[x][0] = imageToByteArray(albumArt);
                    }
                }
                */
            }

            DGV.DataSource = dataTable;

            DGV.Columns[0].Width = 50;
            ((DataGridViewImageColumn)DGV.Columns[0]).ImageLayout = DataGridViewImageCellLayout.Zoom;

            DGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGV.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGV.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGV.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGV.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGV.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            settings = File.ReadAllText("settings.txt", Encoding.UTF8);

            int sortColumnIndex = settings.IndexOf("SortBy=");
            int sortOrderIndex = settings.IndexOf("Order=");

            sortColumn = settings.Substring(sortColumnIndex + 8);
            sortColumn = sortColumn.Substring(0, sortColumn.IndexOf("\""));

            sortOrder = settings.Substring(sortOrderIndex + 7);
            sortOrder = sortOrder.Substring(0, sortOrder.IndexOf("\""));

            bool columnFound = false;
            for (index = 0; index < DGV.Columns.Count && columnFound == false; index++)
            {
                if (DGV.Columns[index].HeaderText == sortColumn)
                {
                    columnFound = true;
                    try
                    {
                        if (sortOrder == "Ascending")
                            DGV.Sort(DGV.Columns[index], ListSortDirection.Ascending);
                        else
                            DGV.Sort(DGV.Columns[index], ListSortDirection.Descending);
                    }
                    catch { }
                }
            }
        }

        public byte[] imageToByteArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        private void DGV_Sorted(object sender, EventArgs e)
        {
            sortColumn = DGV.SortedColumn.HeaderText.ToString();
            sortOrder = DGV.SortOrder.ToString();

            settings = File.ReadAllText("settings.txt", Encoding.UTF8);
            string segment1 = settings.Substring(0, settings.IndexOf("SortBy=") + 8);

            TextWriter tw = new StreamWriter("settings.txt");
            tw.WriteLine(segment1 + sortColumn + "\"");
            tw.WriteLine("Order=\"" + sortOrder + "\"");


            string segment2 = settings.Substring(settings.IndexOf("[Player]"));

            tw.WriteLine();
            tw.Write(segment2);
            tw.Close();
        }

        private void InitializeBrowser()
        {
            chromeBrowser = new ChromiumWebBrowser("https://www.google.com/");
            // Add it to the form and fill it to the form window.
            BrowserDock.Controls.Add(chromeBrowser);
            chromeBrowser.Dock = DockStyle.Fill;
        }

        private void DGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int firstSongIndex = e.RowIndex;
            string[] fileName = new string[dataTable.Rows.Count];
            object[] value = new object[dataTable.Rows.Count];
            int index;

            try { player.wplayer.currentPlaylist.clear(); }
            catch { }

            for (index = 0; index < value.Length; index++)
            {
                try
                {
                    value[index] = DGV.Rows[index].Cells[7].Value;
                    fileName[index] = value[index].ToString();

                    try
                    {
                        player.Show();
                        WMPLib.IWMPMedia newSong = player.wplayer.newMedia(fileName[index]);
                        player.wplayer.currentPlaylist.appendItem(newSong);
                        player.wplayer.Ctlcontrols.play();
                    }
                    catch
                    {
                        try
                        {
                            player.Show();
                            WMPLib.IWMPMedia newSong = player.wplayer.newMedia(fileName[index]);
                            player.playlist.appendItem(newSong);
                            player.wplayer.currentPlaylist = player.playlist;
                            player.wplayer.Ctlcontrols.play();
                        }
                        catch
                        {
                            player = new Player(fileName[index], this);
                            player.Show();
                        }
                    }
                }
                catch { }
            }

            bool wasShuffling = false;
            for (index = 0; index < firstSongIndex; index++)
            {
                if (player.shuffle == true)
                {
                    wasShuffling = true;
                    player.ShuffleMethod();
                }

                player.wplayer.Ctlcontrols.next();
            }

            if (wasShuffling == true)
                player.ShuffleMethod();
        }

        int rowIndex;

        private void DGV_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    this.DGV.Rows[e.RowIndex].Selected = true;
                    this.rowIndex = e.RowIndex;
                    this.DGV.CurrentCell = this.DGV.Rows[e.RowIndex].Cells[1];
                    this.LocalContextMenu.Show(this.DGV, e.Location);
                    LocalContextMenu.Show(Cursor.Position);
                }
                catch { }
            }
        }

        private void addToQueueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileName;
            object value = DGV.Rows[this.rowIndex].Cells[7].Value;
            fileName = value.ToString();

            try
            {
                player.Show();
                WMPLib.IWMPMedia newSong = player.wplayer.newMedia(fileName);
                player.wplayer.currentPlaylist.appendItem(newSong);
            }
            catch
            {
                try
                {
                    player.Show();
                    WMPLib.IWMPMedia newSong = player.wplayer.newMedia(fileName);
                    player.playlist.appendItem(newSong);
                    player.wplayer.currentPlaylist = player.playlist;
                }
                catch
                {
                    player = new Player(fileName, this);
                    player.Show();
                }
            }
        }

        private void editTagsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileName;
            object value = DGV.Rows[this.rowIndex].Cells[7].Value;
            fileName = value.ToString();

            try
            {
                tagEditor.Close();
                tagEditor = new TagEditor(fileName, this);
                tagEditor.Show();
            }
            catch
            {
                tagEditor = new TagEditor(fileName, this);
                tagEditor.Show();
            }
        }

        private void UMusicButton_Click(object sender, EventArgs e)
        {
            BrowserDock.Visible = false;
            DGV.Visible = true;
            LeftPanel.Visible = true;
            chromeBrowser.Load("google.com");
        }
        
        private void SoundCloudButton_Click(object sender, EventArgs e)
        {
            chromeBrowser.Load("https://soundcloud.com/");
            BrowserDock.Visible = true;
            DGV.Visible = false;
            LeftPanel.Visible = false;
            GridPanel.Visible = false;

            try
            {
                if (player.playing == true)
                    player.PlayPause();
            }
            catch { }
        }

        private void SpotifyButton_Click(object sender, EventArgs e)
        {
            chromeBrowser.Load("https://open.spotify.com");
            BrowserDock.Visible = true;
            DGV.Visible = false;
            LeftPanel.Visible = false;
            GridPanel.Visible = false;

            try
            {
                if (player.playing == true)
                    player.PlayPause();
            }
            catch { }
        }

        private void YouTubeButton_Click(object sender, EventArgs e)
        {
            chromeBrowser.Load("https://www.youtube.com/");
            BrowserDock.Visible = true;
            DGV.Visible = false;
            LeftPanel.Visible = false;
            GridPanel.Visible = false;

            try
            {
                if (player.playing == true)
                    player.PlayPause();
            }
            catch { }
        }

        private void YouTubeMusicButton_Click(object sender, EventArgs e)
        {
            chromeBrowser.Load("https://music.youtube.com/");
            BrowserDock.Visible = true;
            DGV.Visible = false;
            LeftPanel.Visible = false;
            GridPanel.Visible = false;

            try
            {
                if (player.playing == true)
                    player.PlayPause();
            }
            catch { }
        }

        private void GoogleButton_Click(object sender, EventArgs e)
        {
            chromeBrowser.Load("https://www.google.com/");
            BrowserDock.Visible = true;
            DGV.Visible = false;
            LeftPanel.Visible = false;
            GridPanel.Visible = false;
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            downloadThread = new Thread(DownloadMethod);
            downloadThread.Start();
        }

        private void DownloadMethod()
        {
            if (chromeBrowser.Address.IndexOf("soundcloud") != -1)
            {

            }
            else if (chromeBrowser.Address.IndexOf("youtube") != -1)
            {
                string address = chromeBrowser.Address;
                if (address.IndexOf("music") != 1)
                    address = address.Substring(address.IndexOf("music.") + 6);

                // try
                {
                    var youtube = YouTube.Default;

                    try
                    {
                        var vid = youtube.GetVideo(address);
                        File.WriteAllBytes(downloadLocation + vid.FullName, vid.GetBytes());

                        var inputFile = new MediaFile { Filename = downloadLocation + vid.FullName };
                        var outputFile = new MediaFile { Filename = $"{downloadLocation + vid.FullName}.mp3" };

                        using (var engine = new Engine())
                        {
                            engine.GetMetadata(inputFile);

                            engine.Convert(inputFile, outputFile);
                        }

                        string mp3File = $"{downloadLocation + vid.FullName}.mp3";
                        string wavFile = $"{downloadLocation + vid.FullName}.wav";

                        using (Mp3FileReader reader = new Mp3FileReader(mp3File))
                        {
                            WaveFileWriter.CreateWaveFile(wavFile, reader);
                        }

                        using (var reader = new AudioFileReader(wavFile))
                        using (var writer = new LameMP3FileWriter(mp3File, reader.WaveFormat, 320))
                            reader.CopyTo(writer);

                        File.Delete(wavFile);
                        videoName = vid.FullName;

                        string message = "File successfully downloaded. Could not refresh DGV.";
                        string caption = "Refresh Failed";
                        MessageBox.Show(message, caption);

                        downloadPrompt = new DownloadPrompt();
                        downloadPrompt.Show();

                        promptTimer = new System.Timers.Timer();
                        promptTimer.Interval = 1;
                        promptTimer.Elapsed += promptTimer_Elapsed;
                        promptTimer.Start();
                    }
                    catch (ArgumentException)
                    {
                        MessageBox.Show("Video could not be downloaded. If you're downloading from YouTube Music, you must be in your Queue.", "Download Failed");
                    }
                    
                }
                /*
                catch (InvalidOperationException)
                {
                    string message = "File successfully downloaded. Could not refresh DGV.";
                    string caption = "Refresh Failed";
                    MessageBox.Show(message, caption);
                }
                catch
                {
                    // This is thrown when the video attempting to be downloaded is either age-restricted or
                    // requires Music Premium.

                    string message = "Your download failed.";
                    string caption = "Download Failed";
                    MessageBox.Show(message, caption);
                }
                */
            }
            else if (chromeBrowser.Address.IndexOf("spotify") != -1)
            {

            }
        }

        private void promptTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (downloadPrompt.exist == false)
            {
                if (downloadPrompt.audio == true && downloadPrompt.video == false)
                {
                    if (File.Exists("music\\download\\" + videoName))
                        File.Delete("music\\download\\" + videoName);
                }
                if (downloadPrompt.audio == false && downloadPrompt.video == true)
                {
                    if (File.Exists("music\\download\\" + videoName + ".mp3"))
                        File.Delete("music\\download\\" + videoName + ".mp3");
                }
                if (downloadPrompt.audio == false && downloadPrompt.video == false)
                {
                    if (File.Exists("music\\download\\" + videoName + ".mp3"))
                        File.Delete("music\\download\\" + videoName + ".mp3");

                    if (File.Exists("music\\download\\" + videoName))
                        File.Delete("music\\download\\" + videoName);
                }

                downloadPrompt.Close();
                promptTimer.Stop();
            }
        }

        private void SongsButton_Click(object sender, EventArgs e)
        {
            GetFiles();
        }

        private void ArtistsButton_Click(object sender, EventArgs e)
        {
            GetFiles();

            if (currentLayout == "List")
            {
                DGV.Columns.Remove("Title");
                DGV.Columns.Remove("Album");
                DGV.Columns.Remove("Album Artist(s)");
                DGV.Columns.Remove("Genre");
                DGV.Columns.Remove("File");

                /*
                bool unknown = false;
                foreach (DataRow row in dataTable.Rows)
                {
                    if (row. == null)
                    {
                        unknown = true;
                        dataTable.Rows.Remove(row);
                    }
                }

                if (unknown == true)
                {
                    DataRow dRow = dataTable.NewRow();
                    dRow[0] = "Unknown Artist";
                    dataTable.Rows.Add();
                }
                */
            }
            else { }
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void Filter()
        {
            DataView DV = new DataView(dataTable);
            DV.RowFilter = string.Format("Title LIKE '%{0}%' OR [Artist(s)] LIKE '%{0}%' OR Album LIKE '%{0}%' OR [Album Artist(s)] LIKE '%{0}%' OR Genre LIKE '%{0}%'", SearchBox.Text);

            DGV.DataSource = DV;

            bool columnFound = false;

            for (int index = 0; index<DGV.Columns.Count && columnFound == false; index++)
            {
                if (DGV.Columns[index].HeaderText == sortColumn)
                {
                    columnFound = true;
                    try
                    {
                        if (sortOrder == "Ascending")
                            DGV.Sort(DGV.Columns[index], ListSortDirection.Ascending);
                        else
                            DGV.Sort(DGV.Columns[index], ListSortDirection.Descending);
                    }
                    catch { }
                }
            }
        }

        private void LayoutListButton_Click(object sender, EventArgs e)
        {
            DGV.Visible = true;
        }

        private void LayoutGridButton_Click(object sender, EventArgs e)
        {
            DGV.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            GetFiles();
        }

        private void PlayAllButton_Click(object sender, EventArgs e)
        {
            string[] fileName = new string[dataTable.Rows.Count];
            object[] value = new object[dataTable.Rows.Count];
            int index;
            for (index = 0; index < value.Length; index++)
            {
                try
                {
                    value[index] = DGV.Rows[index].Cells[7].Value;
                    fileName[index] = value[index].ToString();

                    try
                    {
                        player.Show();
                        WMPLib.IWMPMedia newSong = player.wplayer.newMedia(fileName[index]);
                        player.wplayer.currentPlaylist.appendItem(newSong);
                    }
                    catch
                    {
                        try
                        {
                            player.Show();
                            WMPLib.IWMPMedia newSong = player.wplayer.newMedia(fileName[index]);
                            player.playlist.appendItem(newSong);
                            player.wplayer.currentPlaylist = player.playlist;
                        }
                        catch
                        {
                            player = new Player(fileName[index], this);
                            player.Show();
                        }
                    }
                }
                catch { }
            }
        }

        private void DiscordRichPresenceButton_Click(object sender, EventArgs e)
        {
            settings = File.ReadAllText("settings.txt", Encoding.UTF8);
            string segment1 = settings.Substring(0, settings.IndexOf("DiscordRichPresence=") + 21);
            TextWriter tw = new StreamWriter("settings.txt");

            if (DiscordRichPresenceButton.Checked == true)
            {
                tw.WriteLine(segment1 + "Disabled\"");
                DiscordRichPresenceButton.Checked = false;
            }
            else
            {
                tw.WriteLine(segment1 + "Enabled\"");
                DiscordRichPresenceButton.Checked = true;
            }
            string segment2 = settings.Substring(settings.IndexOf("[Folders]"));

            tw.WriteLine();
            tw.Write(segment2);
            tw.Close();
        }

        private void DeleteSongButton_Click(object sender, EventArgs e)
        {
            string songTitle = DGV.Rows[rowIndex].Cells[1].Value.ToString();
            string filePath = DGV.Rows[rowIndex].Cells[7].Value.ToString();

            string message = "Are you sure you want to delete \"" + songTitle +"\" from your system?";
            string caption = "Are you sure?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.Yes)
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                    MessageBox.Show("File successfully deleted.", "File Deleted");

                    DataGridViewRow rowToDelete = DGV.Rows[rowIndex];
                    DGV.Rows.Remove(rowToDelete);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }
    }
}