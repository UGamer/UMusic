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
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;

namespace UMusic
{
    public partial class Form1 : Form
    {
        public ChromiumWebBrowser chromeBrowser;
        Player player;

        public Form1()
        {
            InitializeComponent();
            GetFiles();
            InitializeBrowser();
        }

        private void GetFiles()
        {
            DGV.DataSource = null;

            string[] musicFiles = Directory.GetFiles("music");
            string[] downloadFiles;
            try
            {
                downloadFiles = Directory.GetFiles("music\\download");
            }
            catch
            {
                Directory.CreateDirectory("music\\download");
                downloadFiles = Directory.GetFiles("music\\download");
            }

            string[] files = new string[musicFiles.Length + downloadFiles.Length];

            int index = 0;
            for (; index < musicFiles.Length; index++)
            {
                files[index] = musicFiles[index];
            }

            for (; index < downloadFiles.Length + musicFiles.Length; index++)
            {
                files[index] = downloadFiles[index - musicFiles.Length];
            }

            string[] tableArray = new string[files.Length];

            string[] titles = new string[files.Length];
            string[] artists = new string[files.Length];
            string[] albums = new string[files.Length];
            string[] genres = new string[files.Length];

            TagLib.File currentFile;
            for (index = 0; index < titles.Length; index++)
            {
                currentFile = TagLib.File.Create(files[index]);
                titles[index] = currentFile.Tag.Title;
                artists[index] = currentFile.Tag.FirstAlbumArtist;
                albums[index] = currentFile.Tag.Album;
                genres[index] = currentFile.Tag.FirstGenre;
                tableArray[index] = titles[index];
            }

            string[,] twoD = new string[files.Length, 5];

            int height = twoD.GetLength(0);
            int width = twoD.GetLength(1);

            DGV.ColumnCount = width;
            DGV.Columns[0].HeaderText = "Title";
            DGV.Columns[1].HeaderText = "Artist";
            DGV.Columns[2].HeaderText = "Album";
            DGV.Columns[3].HeaderText = "Genre";
            DGV.Columns[4].HeaderText = "File";


            DGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGV.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            for (int r = 0; r < height; r++)
            {
                if (files[r].IndexOf(".jpg") == -1)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(this.DGV);

                    twoD[r, 0] = titles[r];
                    twoD[r, 1] = artists[r];
                    twoD[r, 2] = albums[r];
                    twoD[r, 3] = genres[r];

                    twoD[r, 4] = files[r];

                    if (twoD[r, 0] == null)
                    {
                        string fileName = twoD[r, 4];
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

                    this.DGV.Rows.Add(row);
                }
            }
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
            string filePath = DGV.Rows[rowIndex].Cells[4].Value.ToString();

            try
            {
                player.PlaySong(filePath);
                WMPLib.IWMPMedia newSong = player.wplayer.newMedia(filePath);
                player.playlist.appendItem(newSong);
                player.wplayer.currentPlaylist = player.playlist;
                player.Show();
            }
            catch
            {
                try
                {
                    player.wplayer.controls.stop();
                    player = new Player(filePath);
                    WMPLib.IWMPMedia newSong = player.wplayer.newMedia(filePath);
                    player.playlist.appendItem(newSong);
                    player.wplayer.currentPlaylist = player.playlist;
                    player.Show();
                }
                catch
                {
                    player = new Player(filePath);
                    WMPLib.IWMPMedia newSong = player.wplayer.newMedia(filePath);
                    player.playlist.appendItem(newSong);
                    player.wplayer.currentPlaylist = player.playlist;
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
            object value = DGV.Rows[this.rowIndex].Cells[4].Value;
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
                player = new Player(fileName);
                player.Show();
            }
        }

        private void editTagsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileName;
            object value = DGV.Rows[this.rowIndex].Cells[4].Value;
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

        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            if (chromeBrowser.Address.IndexOf("soundcloud") != -1)
            {

            }
            else if (chromeBrowser.Address.IndexOf("youtube") != -1)
            {
                try
                {
                    var source = @"music\\download\\";
                    var youtube = YouTube.Default;
                    var vid = youtube.GetVideo(chromeBrowser.Address);
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
                        File.Delete("music\\download\\" + vid.FullName);
                    }

                    GetFiles();
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
        }
        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }
    }
}
