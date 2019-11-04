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
        Settings settingsWindow;
        public string settings;
        public Theme theme;

        bool albumArtVisible;
        bool titleVisible;
        bool artistVisible;
        bool albumVisible;
        bool albumArtistVisible;
        bool genreVisible;
        bool dateAddedVisible;
        bool fileVisible;

        private string sortColumn;
        string sortOrder;

        System.Windows.Forms.Timer refreshTimer;
        public DataTable dataTable;
        
        public string downloadLocation;
        Thread downloadThread;
        System.Timers.Timer promptTimer;
        DownloadPrompt downloadPrompt;
        string videoName;

        TagEditor tagEditor;

        string currentLayout = "List";

        public string[] folders;
        ArrayList files;

        public Form1()
        {
            InitializeComponent();
            settings = File.ReadAllText("settings.txt", Encoding.UTF8);
            InitializeTheme();

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

            int index = 0;
            for (; index < count; index++)
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

            string[] playlistNames = Directory.GetFiles("playlists\\");
            ToolStripMenuItem[] playlistButtons = new ToolStripMenuItem[playlistNames.Length + 1];

            for (index = 0; index < playlistButtons.Length - 1; index++)
            {
                playlistButtons[index] = new ToolStripMenuItem();
                playlistButtons[index].Text = playlistNames[index].Substring(0, playlistNames[index].Length - 4);
                playlistButtons[index].Text = playlistButtons[index].Text.Substring(10);
                playlistButtons[index].Tag = playlistNames[index];
                playlistButtons[index].Click += AddToPlaylistButton_Click;
                AddToPlaylistButton.DropDownItems.Add(playlistButtons[index]);
            }

            playlistButtons[index] = new ToolStripMenuItem();
            playlistButtons[index].Text = "+ New Playlist...";
            playlistButtons[index].Click += NewPlaylistButton;
            AddToPlaylistButton.DropDownItems.Add(playlistButtons[index]);
        }

        private void InitializeTheme()
        {
            string themeType = settings.Substring(settings.IndexOf("Type=") + 5);
            themeType = themeType.Substring(0, themeType.IndexOf("\n"));
            string textColor = settings.Substring(settings.IndexOf("TextColor=") + 11);
            textColor = textColor.Substring(0, textColor.IndexOf("\""));
            string cellColor = settings.Substring(settings.IndexOf("CellColor=") + 11);
            cellColor = cellColor.Substring(0, cellColor.IndexOf("\""));
            string gridColor = settings.Substring(settings.IndexOf("GridColor=") + 11);
            gridColor = gridColor.Substring(0, gridColor.IndexOf("\""));
            string gridBgColor = settings.Substring(settings.IndexOf("GridBgColor=") + 13);
            gridBgColor = gridBgColor.Substring(0, gridBgColor.IndexOf("\""));
            string buttonColor = settings.Substring(settings.IndexOf("ButtonColor=") + 13);
            buttonColor = buttonColor.Substring(0, buttonColor.IndexOf("\""));
            string sidebarColor = settings.Substring(settings.IndexOf("SideBarColor=") + 14);
            sidebarColor = sidebarColor.Substring(0, sidebarColor.IndexOf("\""));
            string stripColor = settings.Substring(settings.IndexOf("ToolStripColor=") + 16);
            stripColor = stripColor.Substring(0, stripColor.IndexOf("\""));

            string colorString = textColor;
            int textColor1 = Convert.ToInt32(colorString.Substring(0, colorString.IndexOf(",")));
            colorString = textColor.Substring(textColor.IndexOf(",") + 2);
            int textColor2 = Convert.ToInt32(colorString.Substring(0, colorString.IndexOf(",")));
            colorString = textColor.Substring(textColor.IndexOf(",") + 2);
            colorString = colorString.Substring(0, colorString.IndexOf(","));
            int textColor3 = Convert.ToInt32(colorString);

            colorString = cellColor;
            int cellColor1 = Convert.ToInt32(colorString.Substring(0, cellColor.IndexOf(",")));
            colorString = cellColor.Substring(cellColor.IndexOf(",") + 2);
            int cellColor2 = Convert.ToInt32(colorString.Substring(0, colorString.IndexOf(",")));
            colorString = cellColor.Substring(cellColor.IndexOf(",") + 2);
            colorString = colorString.Substring(0, colorString.IndexOf(","));
            int cellColor3 = Convert.ToInt32(colorString);

            colorString = gridColor;
            int gridColor1 = Convert.ToInt32(colorString.Substring(0, gridColor.IndexOf(",")));
            colorString = gridColor.Substring(gridColor.IndexOf(",") + 2);
            int gridColor2 = Convert.ToInt32(colorString.Substring(0, colorString.IndexOf(",")));
            colorString = gridColor.Substring(gridColor.IndexOf(",") + 2);
            colorString = colorString.Substring(0, colorString.IndexOf(","));
            int gridColor3 = Convert.ToInt32(colorString);
            
            colorString = gridBgColor;
            int gridBgColor1 = Convert.ToInt32(colorString.Substring(0, gridBgColor.IndexOf(",")));
            colorString = gridBgColor.Substring(gridBgColor.IndexOf(",") + 2);
            int gridBgColor2 = Convert.ToInt32(colorString.Substring(0, colorString.IndexOf(",")));
            colorString = gridBgColor.Substring(gridBgColor.IndexOf(",") + 2);
            colorString = colorString.Substring(0, colorString.IndexOf(","));
            int gridBgColor3 = Convert.ToInt32(colorString);

            colorString = buttonColor;
            int buttonColor1 = Convert.ToInt32(colorString.Substring(0, buttonColor.IndexOf(",")));
            colorString = buttonColor.Substring(buttonColor.IndexOf(",") + 2);
            int buttonColor2 = Convert.ToInt32(colorString.Substring(0, colorString.IndexOf(",")));
            colorString = buttonColor.Substring(buttonColor.IndexOf(",") + 2);
            colorString = colorString.Substring(0, colorString.IndexOf(","));
            int buttonColor3 = Convert.ToInt32(colorString);

            colorString = sidebarColor;
            int sidebarColor1 = Convert.ToInt32(colorString.Substring(0, sidebarColor.IndexOf(",")));
            colorString = sidebarColor.Substring(sidebarColor.IndexOf(",") + 2);
            int sidebarColor2 = Convert.ToInt32(colorString.Substring(0, colorString.IndexOf(",")));
            colorString = sidebarColor.Substring(sidebarColor.IndexOf(",") + 2);
            colorString = colorString.Substring(0, colorString.IndexOf(","));
            int sidebarColor3 = Convert.ToInt32(colorString);

            colorString = stripColor;
            int stripColor1 = Convert.ToInt32(colorString.Substring(0, stripColor.IndexOf(",")));
            colorString = stripColor.Substring(stripColor.IndexOf(",") + 2);
            int stripColor2 = Convert.ToInt32(colorString.Substring(0, colorString.IndexOf(",")));
            colorString = stripColor.Substring(stripColor.IndexOf(",") + 2);
            colorString = colorString.Substring(0, colorString.IndexOf(","));
            int stripColor3 = Convert.ToInt32(colorString);

            theme = new Theme(themeType, textColor1, textColor2, textColor3,
                cellColor1, cellColor2, cellColor3, gridColor1, gridColor2,
                gridColor3, gridBgColor1, gridBgColor2, gridBgColor3, buttonColor1, 
                buttonColor2, buttonColor3, sidebarColor1, sidebarColor2, sidebarColor3,
                stripColor1, stripColor2, stripColor3);

            this.ForeColor = Color.FromArgb(theme.textColor[0], theme.textColor[1], theme.textColor[2]);
            this.DGV.RowsDefaultCellStyle.BackColor = Color.FromArgb(theme.cellColor[0], theme.cellColor[1], theme.cellColor[2]);
            DGV.GridColor = Color.FromArgb(theme.gridColor[0], theme.gridColor[1], theme.gridColor[2]);
            DGV.BackgroundColor = Color.FromArgb(theme.gridBgColor[0], theme.gridBgColor[1], theme.gridBgColor[2]);

            PlayAllButton.BackColor = Color.FromArgb(theme.buttonColor[0], theme.buttonColor[1], theme.buttonColor[2]);
            SongsButton.BackColor = Color.FromArgb(theme.buttonColor[0], theme.buttonColor[1], theme.buttonColor[2]);
            ArtistsButton.BackColor = Color.FromArgb(theme.buttonColor[0], theme.buttonColor[1], theme.buttonColor[2]);
            AlbumsButton.BackColor = Color.FromArgb(theme.buttonColor[0], theme.buttonColor[1], theme.buttonColor[2]);
            GenresButton.BackColor = Color.FromArgb(theme.buttonColor[0], theme.buttonColor[1], theme.buttonColor[2]);
            PlaylistsButton.BackColor = Color.FromArgb(theme.buttonColor[0], theme.buttonColor[1], theme.buttonColor[2]);

            LeftPanel.BackColor = Color.FromArgb(theme.sidebarColor[0], theme.sidebarColor[1], theme.sidebarColor[2]);
            toolStrip1.BackColor = Color.FromArgb(theme.stripColor[0], theme.stripColor[1], theme.stripColor[2]);

            this.DGV.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(theme.cellColor[0], theme.cellColor[1], theme.cellColor[2]);
            this.DGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(theme.textColor[0], theme.textColor[1], theme.textColor[2]);
            this.DGV.EnableHeadersVisualStyles = false;

            if (themeType == "Custom")
            {

            }
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
                try
                {
                    string[] directoryFiles = Directory.GetFiles(folders[folderIndex]);
                    for (int filesIndex = 0; filesIndex < directoryFiles.Length; filesIndex++)
                        files.Add(directoryFiles[filesIndex]);
                }
                catch { }
            }
            
            int index;
            DateTime fileCreated;
            TagLib.File currentFile;
            // Image albumArt = Image.FromFile(@"resources\Unknown Album Art.png");
            MemoryStream ms;

            dataTable = new DataTable();
            // dataTable.Columns.Add("Album Art", typeof(Image));
            dataTable.Columns.Add("Title");
            dataTable.Columns.Add("Artist(s)");
            dataTable.Columns.Add("Album");
            dataTable.Columns.Add("Album Artist(s)");
            dataTable.Columns.Add("Genre");
            dataTable.Columns.Add("Date Added");
            dataTable.Columns.Add("File");

            // Image albumArt2;
            // ArrayList albumArts = new ArrayList();
            for (index = 0; index < files.Count; index++)
            {
                try
                {
                    currentFile = TagLib.File.Create(files[index].ToString());
                    
                    DataRow dRow = dataTable.NewRow();

                    /*
                    if (currentFile.Tag.Pictures.Length > 0)
                    {
                        MemoryStream mStream = new MemoryStream(currentFile.Tag.Pictures[0].Data.Data);
                        // albumArts.Add(Image.FromStream(mStream));
                        albumArt2 = Image.FromStream(mStream);
                        // dRow["Album Art"] = Image.FromStream(mStream);
                        mStream.Dispose();
                    }
                    else */
                        // dRow["Album Art"] = albumArt;
                    
                    string title = currentFile.Tag.Title;
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
                        title = fileName;
                    }

                    fileCreated = File.GetCreationTime(files[index].ToString());

                    dRow["Title"] = title;
                    dRow["Artist(s)"] = currentFile.Tag.FirstPerformer;
                    dRow["Album"] = currentFile.Tag.Album;
                    dRow["Album Artist(s)"] = currentFile.Tag.FirstAlbumArtist;
                    dRow["Genre"] = currentFile.Tag.FirstGenre;
                    dRow["Date Added"] = string.Format("{0:00}/{1:00}/{2:00} {3:00}:{4:00}:{5:00}", fileCreated.Year,
                        fileCreated.Month, fileCreated.Day, fileCreated.Hour, fileCreated.Minute, fileCreated.Second);
                    dRow["File"] = files[index].ToString();

                    dataTable.Rows.Add(dRow);
                }
                catch (TagLib.UnsupportedFormatException) { }
            }

            string[,] twoD = new string[files.Count, 8];

            int height = twoD.GetLength(0);
            int width = twoD.GetLength(1);


            // if (settings.IndexOf("[Album Art]\nVisible = True") != -1)
                // dataTable.Columns.Add("Album Art", typeof(byte[]));
            
            /*
            for (int r = 0; r < height; r++)
            {
                if (files[r].ToString().IndexOf(".jpg") == -1)
                {

                    

                    
                }

                for (int x = 0; x < dataTable.Rows.Count; x++)
                {
                    try
                    {
                        currentFile = TagLib.File.Create(dataTable.Rows[x]["File"].ToString());
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
            }
            */

            DGV.DataSource = dataTable;

            // DGV.Columns["Album Art"].Width = 50;
            // ((DataGridViewImageColumn)DGV.Columns[0]).ImageLayout = DataGridViewImageCellLayout.Zoom;

            DGV.Columns["Title"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGV.Columns["Artist(s)"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGV.Columns["Album"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGV.Columns["Album Artist(s)"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGV.Columns["Genre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGV.Columns["Date Added"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGV.Columns["File"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

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

            for (index = 0; index < DGV.Rows.Count; index++)
            {
                if (DGV.Rows[index].Cells["File"].Value.ToString().IndexOf(".jpg") != -1)
                {
                    DGV.Rows.RemoveAt(index);
                    index--;
                }
            }
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
                //try
                {
                    value[index] = DGV.Rows[index].Cells["File"].Value;
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
                //catch { }
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
                   // this.DGV.Rows[e.RowIndex].Selected = true;
                    this.rowIndex = e.RowIndex;

                    /*
                    if (DGV.SelectedRows.Count <= 1)
                        DGV.CurrentCell = DGV.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    */

                    this.LocalContextMenu.Show(this.DGV, e.Location);
                    LocalContextMenu.Show(Cursor.Position);
                }
                catch { }
            }
        }

        private void addToQueueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileName;
            for (int index = DGV.SelectedRows.Count - 1; index != -1; index--)
            {
                Console.WriteLine("Gamig");
                fileName = DGV.SelectedRows[index].Cells["File"].Value.ToString();

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
        }

        private void editTagsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileName;
            object value = DGV.Rows[this.rowIndex].Cells["File"].Value;
            fileName = value.ToString();

            try
            {
                tagEditor.Close();
                tagEditor = new TagEditor(fileName, this, rowIndex);
                tagEditor.Show();
            }
            catch
            {
                tagEditor = new TagEditor(fileName, this, rowIndex);
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
                if (player.TopMost == false)
                    player.Close();
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
                if (player.TopMost == false)
                    player.Close();
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
                if (player.TopMost == false)
                    player.Close();
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
                if (player.TopMost == false)
                    player.Close();
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
                MessageBox.Show("File starting to download...", "Download Starting");

                string address = chromeBrowser.Address;
                if (address.IndexOf("music") != 1)
                    address = address.Substring(address.IndexOf("music.") + 6);

                string fileName = "";
                try
                {
                    var youtube = YouTube.Default;

                    try
                    {
                        var vid = youtube.GetVideo(address);
                        fileName = vid.FullName.Substring(0, vid.FullName.Length - vid.FileExtension.Length);

                        try
                        {
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

                            mp3File = $"{downloadLocation + fileName}.mp3";
                            using (var reader = new AudioFileReader(wavFile))
                            using (var writer = new LameMP3FileWriter(mp3File, reader.WaveFormat, 320))
                                reader.CopyTo(writer);

                            File.Delete($"{downloadLocation + vid.FullName}.mp3");
                            File.Delete(wavFile);
                            videoName = vid.FullName;

                            downloadPrompt = new DownloadPrompt(this, fileName, videoName);
                            downloadPrompt.ShowDialog();

                            string message = "File successfully downloaded.";
                            string caption = "Download Successful";
                            MessageBox.Show(message, caption);
                        }
                        catch (ArgumentException)
                        {
                            MessageBox.Show("Video could not be downloaded. If you're downloading from YouTube Music, you must be in your Queue.", "Download Failed");
                        }
                    }
                    catch (System.Net.Http.HttpRequestException)
                    {
                        MessageBox.Show("This audio/video is copyrighted material and can not be downloaded.", "Download Failed");
                    }
                    catch
                    {
                        MessageBox.Show("This audio/video could not be downloaded. Please try again.", "Download Failed");
                    }
                }
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
            }
            else if (chromeBrowser.Address.IndexOf("spotify") != -1)
            {

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
                
                bool unknown = false;
                int index = 0;
                foreach (DataGridViewRow row in DGV.Rows)
                {
                    if (row.Cells["Artist(s)"].Value.ToString() == "")
                    {
                        unknown = true;
                        DGV.Rows.Remove(row);
                        index--;
                    }
                    index++;
                }
                
                /*
                if (unknown == true)
                {
                    DataGridViewRow dRow = DGV.Rows[0];
                    dRow.Cells["Artist(s)"].Value = "Unknown Artist";
                    DGV.Rows.Add(dRow);
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
            try { DV.RowFilter = string.Format("Title LIKE '%{0}%' OR [Artist(s)] LIKE '%{0}%' OR Album LIKE '%{0}%' OR [Album Artist(s)] LIKE '%{0}%' OR Genre LIKE '%{0}%'", SearchBox.Text); }
            catch { }

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
                    value[index] = DGV.Rows[index].Cells["File"].Value;
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
            string songTitle = DGV.Rows[rowIndex].Cells["Title"].Value.ToString();
            string filePath = DGV.Rows[rowIndex].Cells["File"].Value.ToString();

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

        private void AddToPlaylistButton_Click(object sender, EventArgs e)
        {
            string filePath = DGV.Rows[rowIndex].Cells["File"].Value.ToString();
            ToolStripMenuItem tempButton = (ToolStripMenuItem)sender;

            string playlistPath = tempButton.Tag.ToString();
            string playlistName = tempButton.Text;

            AddToPlaylist(filePath, playlistPath, playlistName);
        }

        SavePanel savePanel;

        private void NewPlaylistButton(object sender, EventArgs e)
        {
            savePanel = new SavePanel();
            savePanel.Show();
            savePanel.FormClosed += savePanel_FormClosed;
        }

        private void savePanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            string folderPath = "playlists\\";
            string playlistName = savePanel.playlistName + ".txt";
            
            TextWriter tw;
            try
            {
                tw = new StreamWriter(folderPath + playlistName);
            }
            catch
            {
                Directory.CreateDirectory("playlists\\");
                tw = new StreamWriter(folderPath + playlistName);
            }

            string filePath = DGV.Rows[rowIndex].Cells["File"].Value.ToString();

            tw.Write(filePath);

            tw.Close();

            MessageBox.Show("Added \"" + filePath + "\" to \"" + playlistName.Substring(0, playlistName.Length - 4) + "\"", "Added to Playlist", MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }

        public void AddToPlaylist(string filePath, string playlistPath, string playlistName)
        {
            string oldPlaylist = File.ReadAllText(playlistPath, Encoding.UTF8);
            
            TextWriter tw = new StreamWriter(playlistPath);
            tw.Write(oldPlaylist);
            tw.WriteLine();
            tw.Write(filePath);
            tw.Close();
            MessageBox.Show("Added \"" + filePath + "\" to \"" + playlistName + "\"", "Added to Playlist", MessageBoxButtons.OK, MessageBoxIcon.Information);

            /*
            playlistButtons[index] = new ToolStripMenuItem();
            playlistButtons[index].Text = playlistNames[index].Substring(0, playlistNames[index].Length - 4);
            playlistButtons[index].Text = playlistButtons[index].Text.Substring(10);
            playlistButtons[index].Tag = playlistNames[index];
            playlistButtons[index].Click += AddToPlaylistButton_Click;
            AddToPlaylistButton.DropDownItems.Add(playlistButtons[index]);
            */
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }

        private void SettingsDropDown_Click(object sender, EventArgs e)
        {
            settingsWindow = new Settings(this);
            settingsWindow.Show();
        }
    }
}