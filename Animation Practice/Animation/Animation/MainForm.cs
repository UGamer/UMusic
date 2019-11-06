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

namespace Animation
{
    public partial class MainForm : Form
    {
        public Settings UserSettings;
        public Player Player;

        public List<Song> Library = new List<Song>();

        public MainForm()
        {
            UserSettings = new Settings();

            InitializeComponent();

            ValidateSetup();

            HomePanel.Visible = true;
            ListPanel.Visible = false;
        }

        private void ValidateSetup()
        {
            if (!Directory.Exists(@"music"))
                Directory.CreateDirectory(@"music");

            if (!Directory.Exists(@"music\download"))
                Directory.CreateDirectory(@"music\download");

            if (!Directory.Exists(@"resources"))
                Directory.CreateDirectory(@"resources");

            if (!Directory.Exists(@"resources\artists"))
                Directory.CreateDirectory(@"resources");
        }

        private void DrawerButton_Click(object sender, EventArgs e)
        {
            if (Drawer.Width == 164)
            {
                while (Drawer.Width != 50)
                {
                    Drawer.Width -= 3;

                    MainPanel.Width--;
                    MainPanel.Location = new Point(MainPanel.Location.X - 3, MainPanel.Location.Y);

                    HomeButton.Width -= 3;
                    OnlineButton.Width -= 3;
                    SongsButton.Width -= 3;
                    ArtistsButton.Width -= 3;
                    AlbumsButton.Width -= 3;
                    GenresButton.Width -= 3;
                    PlaylistsButton.Width -= 3;

                    SettingsButton.Width -= 3;
                    AboutButton.Width -= 3;
                }
            }
            else
            {
                while (Drawer.Width != 164)
                {
                    Drawer.Width += 3;

                    MainPanel.Width++;
                    MainPanel.Location = new Point(MainPanel.Location.X + 3, MainPanel.Location.Y);

                    HomeButton.Width += 3;
                    OnlineButton.Width += 3;
                    SongsButton.Width += 3;
                    ArtistsButton.Width += 3;
                    AlbumsButton.Width += 3;
                    GenresButton.Width += 3;
                    PlaylistsButton.Width += 3;

                    SettingsButton.Width += 3;
                    AboutButton.Width += 3;
                } 
            }
        }

        private void SongsButton_Click(object sender, EventArgs e)
        {
            HomePanel.Visible = false;
            ListPanel.Visible = true;

            try { ListArtBox.BackgroundImage = Image.FromFile(@"resources\DefaultAlbumArt.png"); }
            catch { MessageBox.Show("File \"resources\\DefaultAlbumArt.png\" could not be found.", "Error: File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            ListTopLabel.Text = "Songs";
            ListBottomLabel.Text = "";

            LoadingForm loadingForm = new LoadingForm(this);
            try { loadingForm.Show(); } catch { }
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            HomePanel.Visible = true;
            ListPanel.Visible = false;
        }

        private void ListDGV_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                for (int index = 0; index < ListDGV.Rows[e.RowIndex].Cells.Count; index++)
                    ListDGV.Rows[e.RowIndex].Cells[index].Style.BackColor = Color.FromArgb(30, 30, 30);
            }
        }

        private void ListDGV_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                for (int index = 0; index < ListDGV.Rows[e.RowIndex].Cells.Count; index++)
                    ListDGV.Rows[e.RowIndex].Cells[index].Style.BackColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void ListDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NewPlaylist();
            Player.Play();
        }

        private void BarPausePlayButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Player.Playing)
                    Player.Pause();
                else
                    Player.Play();
            }
            catch (NullReferenceException)
            {
                NewPlaylist();
            }
        }

        private void NewPlaylist()
        {
            Player = new Player(this);

            Song[] songs = new Song[ListDGV.Rows.Count];

            for (int index = 0; index < ListDGV.Rows.Count; index++)
            {
                songs[index] = (Song)ListDGV.Rows[index].Cells["Object"].Value;
            }

            Player.NewPlaylist(songs);
        }

        private void BarPreviousButton_Click(object sender, EventArgs e)
        {
            Player.Playlist[Player.PlaylistIndex - 1].Audio.CurrentTime = new TimeSpan(0, 0, 0);
            Player.Playlist[Player.PlaylistIndex].Audio.CurrentTime = new TimeSpan(0, 0, 0);
            Player.PlaylistIndex -= 2;
            Player.OutputDevice.Stop();
        }

        private void BarNextButton_Click(object sender, EventArgs e)
        {
            Player.OutputDevice.Stop();
        }

        private void BarProgressSlider_MouseCaptureChanged(object sender, EventArgs e)
        {
            Player.Playlist[Player.PlaylistIndex].Audio.CurrentTime = new TimeSpan(0, 0, BarProgressSlider.Value);
        }

        private void BarProgressSlider_MouseDown(object sender, MouseEventArgs e)
        {
            Player.ProgressGrabbed = true;
        }

        private void BarProgressSlider_MouseUp(object sender, MouseEventArgs e)
        {
            Player.ProgressGrabbed = false;
        }

        private void ListDGV_Sorted(object sender, EventArgs e)
        {
            UserSettings.SortBy = ListDGV.SortedColumn.HeaderText;
            UserSettings.SortOrder = ListDGV.SortOrder.ToString();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            UserSettings.WriteToDatabase();
        }
    }
}
