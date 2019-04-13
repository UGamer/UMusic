using CefSharp;
using CefSharp.WinForms;
using MediaToolkit;
using MediaToolkit.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using VideoLibrary;

namespace UMusic
{
    public partial class Form1 : Form
    {
        public ChromiumWebBrowser chromeBrowser;
        Player player;
        string settings;

        private string sortColumn;
        string sortOrder;

        Timer refreshTimer;

        public Form1()
        {
            InitializeComponent();

            settings = File.ReadAllText("settings.txt", Encoding.UTF8);

            GetFiles();
            InitializeBrowser();

            refreshTimer = new Timer();
            refreshTimer.Interval = 1000;

        }

        public void GetFiles()
        {
            do
            {
                foreach (DataGridViewRow row in DGV.Rows)
                {
                    try { DGV.Rows.Remove(row); }
                    catch (Exception) { }
                }
            } while (DGV.Rows.Count > 1);

            string[] musicFiles = Directory.GetFiles("music");
            string[] downloadFiles;
            try  { downloadFiles = Directory.GetFiles("music\\download"); }
            catch
            {
                Directory.CreateDirectory("music\\download");
                downloadFiles = Directory.GetFiles("music\\download");
            }

            string[] files = new string[musicFiles.Length + downloadFiles.Length];

            int index;
            for (index = 0; index < musicFiles.Length; index++)
                files[index] = musicFiles[index];

            for (; index < downloadFiles.Length + musicFiles.Length; index++)
                files[index] = downloadFiles[index - musicFiles.Length];

            string[] titles = new string[files.Length];
            string[] artists = new string[files.Length];
            string[] albums = new string[files.Length];
            string[] albumArtists = new string[files.Length];
            string[] genres = new string[files.Length];

            TagLib.File currentFile;
            for (index = 0; index < titles.Length; index++)
            {
                try
                {
                    currentFile = TagLib.File.Create(files[index]);
                    titles[index] = currentFile.Tag.Title;
                    artists[index] = currentFile.Tag.FirstPerformer;
                    albums[index] = currentFile.Tag.Album;
                    albumArtists[index] = currentFile.Tag.FirstAlbumArtist;
                    genres[index] = currentFile.Tag.FirstGenre;
                }
                catch (TagLib.UnsupportedFormatException) { }
            }

            string[,] twoD = new string[files.Length, 6];

            int height = twoD.GetLength(0);
            int width = twoD.GetLength(1);

            DGV.ColumnCount = width;
            DGV.Columns[0].HeaderText = "Title";
            DGV.Columns[1].HeaderText = "Artist(s)";
            DGV.Columns[2].HeaderText = "Album";
            DGV.Columns[3].HeaderText = "Album Artist(s)";
            DGV.Columns[4].HeaderText = "Genre";
            DGV.Columns[5].HeaderText = "File";
            
            DGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGV.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGV.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGV.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            for (int r = 0; r < height; r++)
            {
                if (files[r].IndexOf(".jpg") == -1)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(this.DGV);

                    twoD[r, 0] = titles[r];
                    twoD[r, 1] = artists[r];
                    twoD[r, 2] = albums[r];
                    twoD[r, 3] = albumArtists[r];
                    twoD[r, 4] = genres[r];
                    twoD[r, 5] = files[r];

                    if (twoD[r, 0] == null)
                    {
                        string fileName = twoD[r, 5];
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
                        twoD[r, 0] = fileName;
                    }

                    row.Cells[0].Value = twoD[r, 0];
                    row.Cells[1].Value = twoD[r, 1];
                    row.Cells[2].Value = twoD[r, 2];
                    row.Cells[3].Value = twoD[r, 3];
                    row.Cells[4].Value = twoD[r, 4];
                    row.Cells[5].Value = twoD[r, 5];

                    this.DGV.Rows.Add(row);
                }

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
        }

        private void DGV_Sorted(object sender, EventArgs e)
        {
            sortColumn = DGV.SortedColumn.HeaderText.ToString();
            sortOrder = DGV.SortOrder.ToString();

            string segment1 = settings.Substring(0, settings.IndexOf("SortBy=") + 8);

            TextWriter tw = new StreamWriter("settings.txt");
            tw.WriteLine(segment1 + sortColumn + "\"");
            tw.WriteLine("Order=\"" + sortOrder + "\"");
            tw.WriteLine();

            string segment2 = settings.Substring(settings.IndexOf("[Folders]"));

            tw.WriteLine(segment2);
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
            int rowIndex = e.RowIndex;
            string filePath = DGV.Rows[rowIndex].Cells[5].Value.ToString();

            try
            {
                player.PlaySong(filePath, true);
                /*
                WMPLib.IWMPMedia newSong = player.wplayer.newMedia(filePath);
                player.playlist.appendItem(newSong);
                player.wplayer.currentPlaylist = player.playlist;
                */
                player.Show();
            }
            catch
            {
                try
                {
                    player.wplayer.controls.stop();
                    player = new Player(filePath, this);
                    /*
                    WMPLib.IWMPMedia newSong = player.wplayer.newMedia(filePath);
                    player.playlist.appendItem(newSong);
                    player.wplayer.currentPlaylist = player.playlist;
                    */
                    player.Show();
                }
                catch
                {
                    player = new Player(filePath, this);
                    /*
                    WMPLib.IWMPMedia newSong = player.wplayer.newMedia(filePath);
                    player.playlist.appendItem(newSong);
                    player.wplayer.currentPlaylist = player.playlist;
                    */
                    player.Show();
                }
            }
        }

        int rowIndex;

        private void DGV_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.DGV.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.DGV.CurrentCell = this.DGV.Rows[e.RowIndex].Cells[0];
                this.LocalContextMenu.Show(this.DGV, e.Location);
                LocalContextMenu.Show(Cursor.Position);
            }
        }

        private void addToQueueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileName;
            object value = DGV.Rows[this.rowIndex].Cells[5].Value;
            fileName = value.ToString();

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

        private void editTagsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileName;
            object value = DGV.Rows[this.rowIndex].Cells[5].Value;
            fileName = value.ToString();

            TagEditor tagEditor = new TagEditor(fileName, this);
            tagEditor.Show();
        }

        private void UMusicPic_Click(object sender, EventArgs e)
        {
            BrowserDock.Visible = false;
            DGV.Visible = true;
            chromeBrowser.Load("google.com");
        }

        private void YouTubeMusicPic_Click(object sender, EventArgs e)
        {
            chromeBrowser.Load("https://music.youtube.com/");
            BrowserDock.Visible = true;
            DGV.Visible = false;

            try
            {
                if (player.playing == true)
                    player.PlayPause();
            }
            catch { }
        }

        private void YouTubeBox_Click(object sender, EventArgs e)
        {
            chromeBrowser.Load("https://www.youtube.com/");
            BrowserDock.Visible = true;
            DGV.Visible = false;

            try
            {
                if (player.playing == true)
                    player.PlayPause();
            }
            catch { }
        }

        private void SpotifyPic_Click(object sender, EventArgs e)
        {
            chromeBrowser.Load("https://open.spotify.com");
            BrowserDock.Visible = true;
            DGV.Visible = false;

            try
            {
                if (player.playing == true)
                    player.PlayPause();
            }
            catch { }
        }

        private void SoundCloudPic_Click(object sender, EventArgs e)
        {
            chromeBrowser.Load("https://soundcloud.com/");
            BrowserDock.Visible = true;
            DGV.Visible = false;

            try
            {
                if (player.playing == true)
                    player.PlayPause();
            }
            catch { }
        }
        
        private void CollapseExpandButton_Click(object sender, EventArgs e)
        {
            int originalLinksWidth;
            int originalPanelWidth;
            int originalDGVWidth;

            if (CollapseExtendButton.Text == "^")
            {
                originalLinksWidth = LinksPanel.Width;
                originalPanelWidth = LocalPanel.Width;
                originalDGVWidth = DGV.Width;

                LinksPanel.Size = new Size(originalLinksWidth, 33);
                CollapseExtendButton.Size = new Size(28, 16);
                // LocalPanel.Location = new Point(0, 33);
                DGV.Size = new Size(originalDGVWidth, 421);

                CollapseExtendButton.Text = "...";
            }
            else
            {
                originalLinksWidth = LinksPanel.Width;
                originalPanelWidth = LocalPanel.Width;
                originalDGVWidth = DGV.Width;

                LinksPanel.Size = new Size(originalLinksWidth, 88);
                CollapseExtendButton.Size = new Size(28, 71);
                LocalPanel.Size = new Size(originalPanelWidth, 365);
                DGV.Size = new Size(originalDGVWidth, 365);

                CollapseExtendButton.Text = "^";
            }
        }

        private void GoogleButton_Click(object sender, EventArgs e)
        {
            chromeBrowser.Load("https://www.google.com/");
            BrowserDock.Visible = true;
            DGV.Visible = false;
        }

        Thread downloadThread;

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

                try
                {
                    var source = @"music\\download\\";
                    var youtube = YouTube.Default;
                    var vid = youtube.GetVideo(address);
                    File.WriteAllBytes(source + vid.FullName, vid.GetBytes());

                    var inputFile = new MediaFile { Filename = source + vid.FullName };
                    var outputFile = new MediaFile { Filename = $"{source + vid.FullName}.mp3" };

                    using (var engine = new Engine())
                    {
                        engine.GetMetadata(inputFile);

                        engine.Convert(inputFile, outputFile);
                    }

                    string message = "Your download for \"" + vid.FullName + "\" has completed. Would you like to keep the video file?";
                    string caption = "Download Complete";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, caption, buttons);
                    if (result == DialogResult.Yes)
                    {

                    }
                    else
                    {
                        if (File.Exists("music\\download\\" + vid.FullName))
                        {
                            File.Delete("music\\download\\" + vid.FullName);
                        }
                    }

                    GetFiles();
                }
                catch (System.InvalidOperationException)
                {
                    string message = "Could not refresh DGV.";
                    string caption = "Refresh Failed";
                    MessageBox.Show(message, caption);
                }
                catch
                {
                    try
                    {
                        // This is thrown when the video attempting to be downloaded is either age-restricted or
                        // requires Music Premium.
                        
                        string message = "Your download failed.";
                        string caption = "Download Failed";
                        MessageBox.Show(message, caption);
                    }
                    catch
                    {
                        chromeBrowser.Load("https://www.google.com/");
                    }
                }
            }
            else if (chromeBrowser.Address.IndexOf("spotify") != -1)
            {

            }

            downloadThread.Abort();
        }
        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }
    }
}