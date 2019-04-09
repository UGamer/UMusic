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
using Utilities;

namespace UMusic
{
    public partial class Player : Form
    {
        WMPLib.WindowsMediaPlayer wplayer;

        string filePath;
        TagLib.File currentFile;
        Timer scrollingTimer;
        int titleLabelWidth;
        int titleLabelXPos = 0;

        bool playing = true;

        public Player()
        {
            InitializeComponent();

            filePath = "love it mane.mp3";
            currentFile = TagLib.File.Create(filePath);

            if (currentFile.Tag.Pictures.Length >= 1)
            {
                var bin = (byte[])(currentFile.Tag.Pictures[0].Data.Data);
                AlbumArtBox.BackgroundImage = Image.FromStream(new MemoryStream(bin)).GetThumbnailImage(500, 500, null, IntPtr.Zero);
            }

            TitleLabel.Text = currentFile.Tag.Title;

            if (TitleLabel.Size.Width > TitlePanel.Size.Width)
            {
                titleLabelWidth = TitleLabel.Size.Width;
                scrollingTimer = new Timer();
                scrollingTimer.Interval = 1;
                scrollingTimer.Tick += scrollingTimer_Tick;
                scrollingTimer.Start();
            }
            wplayer = new WMPLib.WindowsMediaPlayer();

            wplayer.URL = filePath;
            wplayer.controls.play();

            globalKeyboardHook gkh = new globalKeyboardHook();

            gkh.HookedKeys.Add(Keys.MediaPlayPause);
            gkh.KeyDown += new KeyEventHandler(gkh_KeyDown);
        }

        private void scrollingTimer_Tick(object sender, EventArgs e)
        {
            if (titleLabelXPos <= titleLabelWidth)
            {
                titleLabelXPos--;
                TitleLabel.Location = new Point(titleLabelXPos, 4);
            }
            else
            {
                TitleLabel.Location = new Point(0, 4);
            }
        }

        private void PlayPauseButton_Click(object sender, EventArgs e)
        {
            PlayPause();
        }

        private void gkh_KeyDown(object sender, KeyEventArgs e)
        {
            PlayPause();
        }

        private void PlayPause()
        {
            if (playing == true)
            {
                playing = false;
                wplayer.controls.pause();
                PlayPauseButton.Text = "Play";
            }
            else
            {
                playing = true;
                wplayer.controls.play();
                PlayPauseButton.Text = "Pause";
            }
        }
    }
}
