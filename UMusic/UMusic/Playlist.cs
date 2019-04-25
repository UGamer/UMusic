using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace UMusic
{
    public partial class Playlist : Form
    {
        Player reference;
        public IWMPMedia[] items;

        int songIndex = 0;
        string[] files;

        public Playlist(Player reference)
        {
            this.reference = reference;
            InitializeComponent();

            LockButton.BackgroundImage = Image.FromFile("Resources\\Unlock.png");
            SaveButton.BackgroundImage = Image.FromFile("Resources\\Save.png");
            LoadButton.BackgroundImage = Image.FromFile("Resources\\Load.png");

            FillItems();
            FillList();

            int index = 0;
            for (int i = 0; i < reference.playlist.count; i++)
            {
                if (reference.wplayer.currentMedia.isIdentical[reference.playlist.Item[i]])
                {
                    index = i;
                    break;
                }
            }

            this.songIndex = index;

            HighlightSong(index);
        }

        public void FillItems()
        {
            items = new IWMPMedia[reference.playlist.count];

            for (int index = 0; index < items.Length; index++)
                items[index] = reference.playlist.Item[index];
        }

        public void FillList()
        {
            do
            {
                foreach (DataGridViewRow row in DGV.Rows)
                {
                    try { DGV.Rows.Remove(row); }
                    catch (Exception) { }
                }
            } while (DGV.Rows.Count > 0);

            string[] songNames = new string[items.Length];
            files = new string[items.Length];
            
            for (int index = 0; index < songNames.Length; index++)
            {
                songNames[index] = items[index].name;
                files[index] = items[index].sourceURL;
            }

            string[,] twoD = new string[files.Length, 2];

            int height = twoD.GetLength(0);
            int width = twoD.GetLength(1);

            DGV.ColumnCount = width;
            DGV.Columns[0].HeaderText = "Title";
            DGV.Columns[1].HeaderText = "File";


            DGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGV.Columns[1].Visible = false;

            for (int r = 0; r < height; r++)
            {
                if (files[r].IndexOf(".jpg") == -1)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(this.DGV);

                    twoD[r, 0] = songNames[r];
                    twoD[r, 1] = files[r];

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

                    this.DGV.Rows.Add(row);
                }
            }
        }

        public void HighlightSong(int songIndex)
        {
            this.songIndex = songIndex;

            for (int index = 0; index < DGV.Rows.Count; index++)
            {
                DGV.Rows[index].Cells[0].Style = new DataGridViewCellStyle { ForeColor = Color.Black };
            }

            try { DGV.Rows[songIndex].Cells[0].Style = new DataGridViewCellStyle { ForeColor = Color.Blue }; }
            catch { }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            if (LoadFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fullPlaylist = File.ReadAllText(LoadFileDialog.FileName, Encoding.UTF8);
                
                int count = 0;
                int i = 0;
                string pattern = "\n";
                while ((i = fullPlaylist.IndexOf(pattern, i)) != -1)
                {
                    i += pattern.Length;
                    count++;
                }
                
                string[] fileNames = new string[count];
                string playlistSegment = fullPlaylist;
                int newSongIndex;

                for (int index = 0; index < count; index++)
                {
                    newSongIndex = playlistSegment.IndexOf("\n");
                    fileNames[index] = playlistSegment.Substring(0, newSongIndex);
                    playlistSegment = playlistSegment.Substring(newSongIndex + 1);
                }


                reference.wplayer.currentPlaylist.clear();
                // reference.playlist.clear();

                items = new WMPLib.IWMPMedia[count];

                IWMPPlaylist newPlaylist = reference.wplayer.currentPlaylist;

                for (int index = 0; index < items.Length; index++)
                {
                    WMPLib.IWMPMedia newSong = reference.wplayer.newMedia(fileNames[index]);
                    items[index] = newSong;
                }

                for (int index = 0; index < items.Length; index++)
                    newPlaylist.appendItem(items[index]);

                reference.wplayer.currentPlaylist = newPlaylist;

                // this.Text = items[0].name.ToString();
                FillList();
            }
        }

        SavePanel savePanel;

        private void SaveButton_Click(object sender, EventArgs e)
        {
            savePanel = new SavePanel();
            savePanel.Show();
            savePanel.FormClosed += savePanel_FormClosed;
        }

        private void savePanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            string folderPath = "playlists\\";
            string playlistName = savePanel.playlistName + ".txt";

            try
            {
                TextWriter tw = new StreamWriter(folderPath + playlistName);
                for (int index = 0; index < files.Length; index++)
                {
                    tw.WriteLine(files[index]);
                }
                tw.Close();
                MessageBox.Show("Saved.", "Saved Playlist", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                Directory.CreateDirectory("playlists\\");
                TextWriter tw = new StreamWriter(folderPath + playlistName);
                for (int index = 0; index < files.Length; index++)
                {
                    tw.WriteLine(files[index]);
                }
                tw.Close();
                MessageBox.Show("Saved.", "Saved Playlist", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            reference.wplayer.currentPlaylist.clear();

            do
            {
                foreach (DataGridViewRow row in DGV.Rows)
                {
                    try { DGV.Rows.Remove(row); }
                    catch (Exception) { }
                }
            } while (DGV.Rows.Count > 0);
        }

        private void DGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int oldSongIndex = 0;
            for (int i = 0; i < reference.playlist.count; i++)
            {
                if (reference.wplayer.currentMedia.isIdentical[reference.playlist.Item[i]])
                {
                    oldSongIndex = i;
                    break;
                }
            }
            
            songIndex = e.RowIndex;
            
            if (oldSongIndex < songIndex) // If the new song is ahead in the playlist
            {
                for (; oldSongIndex != songIndex; oldSongIndex++)
                {
                    reference.wplayer.Ctlcontrols.next();
                }
            }
            else // If the new song is behind in the playlist
            {
                for (; oldSongIndex != songIndex; oldSongIndex--)
                {
                    reference.wplayer.Ctlcontrols.previous();
                }
            }
        }

        private void RemoveFromQueueButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
