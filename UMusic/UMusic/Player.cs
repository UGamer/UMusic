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
        public bool exist = true;

        public WMPLib.WindowsMediaPlayer wplayer;
        public WMPLib.IWMPPlaylist playlist;
        Timer positionTimer;

        string filePath;
        public TagLib.File currentFile;

        Timer scrollingTimer;
        int titleLabelWidth;
        int titleLabelXPos = 0;
        
        Timer scrollingTimerArtist;
        int artistLabelWidth;
        int artistLabelXPos = 0;

        Timer scrollingTimerAlbum;
        int albumLabelWidth;
        int albumLabelXPos = 0;

        Timer scrollingTimerGenre;
        int genreLabelWidth;
        int genreLabelXPos = 0;

        public bool playing = false;
        bool looping = false;
        bool shuffle = false;
        bool locked = false;

        bool grabbed = false;

        MiniPlayer miniPlayer;

        public Player(string filePath)
        {
            InitializeComponent();

            LockButton.BackgroundImage = Image.FromFile("Resources\\Unlock.png");

            PlayPauseButton.BackgroundImage = Image.FromFile("Resources\\Pause.png");

            LoopButton.BackgroundImage = Image.FromFile("Resources\\Loop.png");
            ShuffleButton.BackgroundImage = Image.FromFile("Resources\\Shuffle.png");

            globalKeyboardHook gkh = new globalKeyboardHook();

            gkh.HookedKeys.Add(Keys.MediaPlayPause);
            gkh.KeyDown += new KeyEventHandler(gkh_KeyDown);

            this.filePath = filePath;
            PlaySong(filePath);
        }

        public void PlaySong(string filePath)
        {
            try
            {
                wplayer.controls.stop();
            }
            catch
            {

            }

            playing = true;
            
            wplayer = new WMPLib.WindowsMediaPlayer();
            playlist = wplayer.playlistCollection.newPlaylist("myplaylist");
            WMPLib.IWMPMedia currentSong = wplayer.newMedia(filePath);
            
            playlist.appendItem(currentSong);
            wplayer.currentPlaylist = playlist;

            WMPLib.IWMPMedia playlistItem = playlist.Item[0];

            wplayer.controls.play();

            wplayer.MediaChange += wplayer_MediaChange;
            wplayer.PlayStateChange += wplayer_PlayStateChange;

            positionTimer = new Timer();
            positionTimer.Interval = 1;
            positionTimer.Tick += positionTimer_Tick;
            positionTimer.Start();
            
            DisplayInfo();
        }

        private void wplayer_PlayStateChange(int NewState)
        {
            string playState = wplayer.playState.ToString();

            if (playState == "wmppsStopped")
            {
                PlayPauseButton.BackgroundImage = Image.FromFile("Resources\\Play.png");
                playing = false;
            }
        }

        private void wplayer_MediaChange(object Item)
        {
            DisplayInfo();
        }

        public void DisplayInfo()
        {
            string currentMedia = wplayer.currentMedia.sourceURL;

            currentFile = TagLib.File.Create(currentMedia);

            if (currentFile.Tag.Pictures.Length >= 1)
            {
                var bin = (byte[])(currentFile.Tag.Pictures[0].Data.Data);
                AlbumArtBox.BackgroundImage = Image.FromStream(new MemoryStream(bin)).GetThumbnailImage(500, 500, null, IntPtr.Zero);
            }
            else
                AlbumArtBox.BackgroundImage = Image.FromFile("Resources\\Unknown Album Art.png");

            TitleLabel.Text = currentFile.Tag.Title;

            if (currentFile.Tag.Title == null)
            {
                string fileName = currentFile.Name;
                for (bool ready = false; ready == false; )
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

                TitleLabel.Text = fileName;
            }

            ArtistLabel.Text = currentFile.Tag.FirstAlbumArtist;

            AlbumLabel.Text = "Album: " + currentFile.Tag.Album;
            if (currentFile.Tag.Album == null)
                AlbumLabel.Text = "";

            GenreLabel.Text = "Genre: " + currentFile.Tag.FirstGenre;
            if (currentFile.Tag.FirstGenre == null)
                GenreLabel.Text = "";

            // This section is for scrolling timer determinations.
            {
                try
                {
                    scrollingTimer.Stop();
                    TitleLabel.Location = new Point(0, 4);
                }
                catch { }
                try
                {
                    scrollingTimerArtist.Stop();
                    ArtistLabel.Location = new Point(0, 4);
                }
                catch { }
                try
                {
                    scrollingTimerAlbum.Stop();
                    AlbumLabel.Location = new Point(0, 4);
                }
                catch { }
                try
                {
                    scrollingTimerGenre.Stop();
                    GenreLabel.Location = new Point(0, 4);
                }
                catch { }

                if (TitleLabel.Size.Width > TitlePanel.Size.Width)
                {
                    titleLabelWidth = TitleLabel.Size.Width;
                    titleLabelXPos = 0;
                    scrollingTimer = new Timer();
                    scrollingTimer.Interval = 1;
                    scrollingTimer.Tick += scrollingTimer_Tick;
                    scrollingTimer.Start();

                }

                if (ArtistLabel.Size.Width > ArtistPanel.Size.Width)
                {
                    artistLabelWidth = ArtistLabel.Size.Width;
                    artistLabelXPos = 0;
                    scrollingTimerArtist = new Timer();
                    scrollingTimerArtist.Interval = 1;
                    scrollingTimerArtist.Tick += scrollingTimerArtist_Tick;
                    scrollingTimerArtist.Start();
                }

                if (AlbumLabel.Size.Width > AlbumPanel.Size.Width)
                {
                    albumLabelWidth = AlbumLabel.Size.Width;
                    albumLabelXPos = 0;
                    scrollingTimerAlbum = new Timer();
                    scrollingTimerAlbum.Interval = 1;
                    scrollingTimerAlbum.Tick += scrollingTimerAlbum_Tick;
                    scrollingTimerAlbum.Start();
                }

                if (GenreLabel.Size.Width > GenrePanel.Size.Width)
                {
                    genreLabelWidth = GenreLabel.Size.Width;
                    genreLabelXPos = 0;
                    scrollingTimerGenre = new Timer();
                    scrollingTimerGenre.Interval = 1;
                    scrollingTimerGenre.Tick += scrollingTimerGenre_Tick;
                    scrollingTimerGenre.Start();
                }
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
        }

        private void PlayPauseButton_Click(object sender, EventArgs e)
        {
            PlayPause();
        }

        private void gkh_KeyDown(object sender, KeyEventArgs e)
        {
            PlayPause();
        }

        public void PlayPause()
        {
            if (playing == true)
            {
                playing = false;
                wplayer.controls.pause();
                PlayPauseButton.BackgroundImage = Image.FromFile("Resources\\Play.png");

                try
                {
                    miniPlayer.PlayPauseButton.BackgroundImage = Image.FromFile("Resources\\Play.png");
                }
                catch { }
            }
            else
            {
                playing = true;
                wplayer.controls.play();
                PlayPauseButton.BackgroundImage = Image.FromFile("Resources\\Pause.png");

                try
                {
                    miniPlayer.PlayPauseButton.BackgroundImage = Image.FromFile("Resources\\Pause.png");
                }
                catch { }
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
                LoopButton.FlatStyle = FlatStyle.Flat;
            }
            else
            {
                looping = false;
                wplayer.settings.setMode("loop", false);
                LoopButton.FlatStyle = FlatStyle.Standard;
            }
        }
        
        private void ShuffleButton_Click(object sender, EventArgs e)
        {
            if (shuffle == false)
            {
                shuffle = true;
                wplayer.settings.setMode("shuffle", true);
                ShuffleButton.FlatStyle = FlatStyle.Flat;
            }
            else
            {
                shuffle = false;
                wplayer.settings.setMode("shuffle", false);
                ShuffleButton.FlatStyle = FlatStyle.Standard;
            }
        }

        private void positionTimer_Tick(object sender, EventArgs e)
        {
            if (grabbed == false)
            {
                ProgressBar.Value = (int)wplayer.controls.currentPosition;
            }

            int sec = (int)wplayer.controls.currentPosition;

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

            if (grabbed == true)
            {
                sec = ProgressBar.Value;

                min = sec / 60;
                sec %= 60;
                hour = min / 60;
                min %= 60;

                h = hour.ToString("00");
                m = min.ToString("00");
                s = sec.ToString("00");

                if (hour == 0)
                {
                    CurrentTimeLabel.Text = m + ":" + s;
                }
                else
                {
                    CurrentTimeLabel.Text = h + ":" + m + ":" + s;
                }
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

        private void scrollingTimerAlbum_Tick(object sender, EventArgs e)
        {
            if (albumLabelXPos >= albumLabelWidth * -1)
            {
                albumLabelXPos--;
                AlbumLabel.Location = new Point(albumLabelXPos, 4);
            }
            else
            {
                AlbumLabel.Location = new Point(AlbumPanel.Size.Width, 4);
                albumLabelXPos = AlbumPanel.Size.Width;
            }
        }

        private void scrollingTimerGenre_Tick(object sender, EventArgs e)
        {
            if (genreLabelXPos >= genreLabelWidth * -1)
            {
                genreLabelXPos--;
                GenreLabel.Location = new Point(genreLabelXPos, 4);
            }
            else
            {
                GenreLabel.Location = new Point(GenrePanel.Size.Width, 4);
                genreLabelXPos = GenrePanel.Size.Width;
            }
        }

        private void LockButton_Click(object sender, EventArgs e)
        {
            if (locked == false)
            {
                this.TopMost = true;
                locked = true;
                LockButton.BackgroundImage = Image.FromFile("Resources\\Lock.png");
            }
            else
            {
                this.TopMost = false;
                locked = false;
                LockButton.BackgroundImage = Image.FromFile("Resources\\Unlock.png");
            }
        }

        private void MiniPlayerButton_Click(object sender, EventArgs e)
        {
            miniPlayer = new MiniPlayer(this);
            miniPlayer.Show();
        }

        private void Player_FormClosed(object sender, FormClosedEventArgs e)
        {
            wplayer.controls.stop();
            this.Dispose();
        }

        private void ProgressBar_MouseCaptureChanged(object sender, EventArgs e)
        {
            int seconds = ProgressBar.Value;
            wplayer.controls.currentPosition = seconds;
        }

        private void ProgressBar_MouseDown(object sender, MouseEventArgs e)
        {
            grabbed = true;
        }

        private void ProgressBar_MouseUp(object sender, MouseEventArgs e)
        {
            grabbed = false;
        }

        private void PlaylistButton_Click(object sender, EventArgs e)
        {
            Playlist playlistWindow = new Playlist(this);
            playlistWindow.Show();
        }
    }
}
