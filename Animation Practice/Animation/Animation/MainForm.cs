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
        Player player;

        public MainForm()
        {
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

            ListArtBox.BackgroundImage = Image.FromFile(@"resources\DefaultAlbumArt.png");

            LoadingForm loadingForm = new LoadingForm(this);
            try { loadingForm.Show(); } catch { }
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            HomePanel.Visible = true;
            ListPanel.Visible = false;
        }

        private void ListDGV_MouseEnter(object sender, EventArgs e)
        {

        }
    }
}
