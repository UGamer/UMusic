using CefSharp;
using CefSharp.WinForms;
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
            string[] files = Directory.GetFiles("music");

            string[] tableArray = new string[files.Length];

            string[] titles = new string[files.Length];

            TagLib.File currentFile;
            for (int index = 0; index < titles.Length; index++)
            {
                currentFile = TagLib.File.Create(files[index]);
                titles[index] = currentFile.Tag.Title;
                tableArray[index] = titles[index];
            }

            string[,] twoD = new string[files.Length, 2];

            int height = twoD.GetLength(0);
            int width = twoD.GetLength(1);

            DGV.ColumnCount = width;
            DGV.Columns[0].HeaderText = "Title";
            DGV.Columns[1].HeaderText = "File";

            for (int r = 0; r < height; r++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(this.DGV);

                twoD[r, 0] = titles[r];
                twoD[r, 1] = files[r];

                for (int c = 0; c < width; c++)
                {
                    row.Cells[c].Value = twoD[r, c];
                    row.Cells[1].Value = twoD[r, 1];
                }

                this.DGV.Rows.Add(row);
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
            string filePath = DGV.Rows[rowIndex].Cells[1].Value.ToString();
            player = new Player(filePath);
            player.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }

        private void UMusicPic_Click(object sender, EventArgs e)
        {
            BrowserDock.Visible = false;
        }

        private void YouTubeMusicPic_Click(object sender, EventArgs e)
        {
            chromeBrowser.Load("https://music.youtube.com/");
            BrowserDock.Visible = true;

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

            try
            {
                if (player.playing == true)
                    player.PlayPause();
            }
            catch { }
        }
    }
}
