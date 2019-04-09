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
        Timer positionTimer;

        string filePath;
        TagLib.File currentFile;

        Timer scrollingTimer;
        int titleLabelWidth;
        int titleLabelXPos = 0;
        
        Timer scrollingTimerArtist;
        int artistLabelWidth;
        int artistLabelXPos = 0;

        bool playing = true;
        bool looping = false;
        bool shuffle = false;

        public Player(string filePath)
        {
            InitializeComponent();

            globalKeyboardHook gkh = new globalKeyboardHook();

            gkh.HookedKeys.Add(Keys.MediaPlayPause);
            gkh.KeyDown += new KeyEventHandler(gkh_KeyDown);

            this.filePath = filePath;
            PlaySong(filePath);
        }

        private void PlaySong(string filePath)
        {
            currentFile = TagLib.File.Create(filePath);

            if (currentFile.Tag.Pictures.Length >= 1)
            {
                var bin = (byte[])(currentFile.Tag.Pictures[0].Data.Data);
                AlbumArtBox.BackgroundImage = Image.FromStream(new MemoryStream(bin)).GetThumbnailImage(500, 500, null, IntPtr.Zero);
            }

            TitleLabel.Text = currentFile.Tag.Title;
            ArtistLabel.Text = currentFile.Tag.FirstAlbumArtist;

            if (TitleLabel.Size.Width > TitlePanel.Size.Width)
            {
                titleLabelWidth = TitleLabel.Size.Width;
                scrollingTimer = new Timer();
                scrollingTimer.Interval = 1;
                scrollingTimer.Tick += scrollingTimer_Tick;
                scrollingTimer.Start();
            }

            if (ArtistLabel.Size.Width > ArtistPanel.Size.Width)
            {
                artistLabelWidth = ArtistLabel.Size.Width;
                scrollingTimerArtist = new Timer();
                scrollingTimerArtist.Interval = 1;
                scrollingTimerArtist.Tick += scrollingTimerArtist_Tick;
                scrollingTimerArtist.Start();
            }

            TimeSpan fullLength = currentFile.Properties.Duration;
            string fullString = fullLength.ToString();
            string hms = fullString.Substring(0, fullString.IndexOf("."));

            int hourIndex = hms.IndexOf(":");
            string h = hms.Substring(0, hourIndex);
            string m = hms.Substring(hourIndex + 1, 2);
            string s = hms.Substring(hourIndex + 4, 2);

            int hour = Convert.ToInt32(h);
            int min = Convert.ToInt32(m);
            int sec = Convert.ToInt32(s);

            int timeInSecs = (hour * 3600) + (min * 60) + sec;

            ProgressBar.Maximum = timeInSecs;

            if (hour == 0)
            {
                TotalLengthLabel.Text = min.ToString("00") + ":" + sec.ToString("00");
            }
            else
            {
                TotalLengthLabel.Text = hour.ToString("00") + ":" + min.ToString("00") + ":" + sec.ToString("00");
            }

            wplayer = new WMPLib.WindowsMediaPlayer();
            
            wplayer.URL = filePath;
            wplayer.controls.play();

            positionTimer = new Timer();
            positionTimer.Interval = 1000;
            positionTimer.Tick += positionTimer_Tick;
            positionTimer.Start();
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

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            wplayer.controls.previous();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            wplayer.controls.next();
        }

        private void VolumeBar_ValueChanged(object sender, EventArgs e)
        {
            wplayer.settings.volume = VolumeBar.Value;
        }

        private void LoopButton_Click(object sender, EventArgs e)
        {
            if (looping == false)
            {
                looping = true;
                wplayer.settings.setMode("loop", true);
                LoopButton.Text = "Looping";
            }
            else
            {
                looping = false;
                wplayer.settings.setMode("loop", false);
                LoopButton.Text = "Not Looping";
            }
        }
        
        private void Player_FormClosed(object sender, FormClosedEventArgs e)
        {
            wplayer.controls.stop();
        }

        private void ShuffleButton_Click(object sender, EventArgs e)
        {
            if (shuffle == false)
            {
                shuffle = true;
                wplayer.settings.setMode("shuffle", true);
                ShuffleButton.Text = "Shuffling";
            }
            else
            {
                shuffle = false;
                wplayer.settings.setMode("shuffle", false);
                ShuffleButton.Text = "Not Shuffling";
            }
        }

        private void positionTimer_Tick(object sender, EventArgs e)
        {
            ProgressBar.Value = (int)wplayer.controls.currentPosition;
            int sec = ProgressBar.Value;

            int min = sec / 60;
            sec %= 60;
            int hour = min / 60;
            min %= 60;

            string h = hour.ToString("00");
            string m = min.ToString("00");
            string s = sec.ToString("00");

            if (hour == 0)
            {
                CurrentTimeLabel.Text = m + ":" + s;
            }
            else
            {
                CurrentTimeLabel.Text = h + ":" + m + ":" + s;
            }
        }

        private void scrollingTimer_Tick(object sender, EventArgs e)
        {
            if (titleLabelXPos >= titleLabelWidth * -1)
            {
                titleLabelXPos--;
                TitleLabel.Location = new Point(titleLabelXPos, 4);
            }
            else
            {
                TitleLabel.Location = new Point(TitlePanel.Size.Width, 4);
                titleLabelXPos = TitlePanel.Size.Width;
            }
        }

        private void scrollingTimerArtist_Tick(object sender, EventArgs e)
        {
            if (artistLabelXPos >= artistLabelWidth * -1)
            {
                artistLabelXPos--;
                ArtistLabel.Location = new Point(artistLabelXPos, 4);
            }
            else
            {
                ArtistLabel.Location = new Point(ArtistPanel.Size.Width, 4);
                artistLabelXPos = ArtistPanel.Size.Width;
            }
        }

        private void ProgressBar_ValueChanged(object sender, EventArgs e)
        {
            int seconds = ProgressBar.Value;
            wplayer.controls.currentPosition = seconds;
        }
    }
}
