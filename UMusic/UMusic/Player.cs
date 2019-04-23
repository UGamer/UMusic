using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;
using WMPLib;

namespace UMusic
{
    public partial class Player : Form
    {
        public bool exist = true;
        globalKeyboardHook gkh;

        Playlist playlistWindow;
        public IWMPPlaylist playlist;
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
        public bool shuffle = false;
        bool locked = false;
        int volumeValue = 100;
        string settings;

        bool grabbed = false;

        MiniPlayer miniPlayer;
        Form1 main;
        TagEditor tagEditor;

        ProcessStartInfo discordRichPresenceStartInfo = new ProcessStartInfo("easyrp.exe");
        Process discordRichPresence = new Process();
        string richPresenceConfig;
        int richStartTimeStamp;
        int richEndTimeStamp;

        public Player(string filePath, Form1 main)
        {
            this.main = main;
            InitializeComponent();

            LockButton.BackgroundImage = Image.FromFile("Resources\\Unlock.png");

            PlayPauseButton.BackgroundImage = Image.FromFile("Resources\\Pause.png");

            LoopButton.BackgroundImage = Image.FromFile("Resources\\Loop.png");
            ShuffleButton.BackgroundImage = Image.FromFile("Resources\\Shuffle.png");

            gkh = new globalKeyboardHook();

            gkh.HookedKeys.Add(Keys.MediaPlayPause);
            gkh.HookedKeys.Add(Keys.MediaPreviousTrack);
            gkh.HookedKeys.Add(Keys.MediaNextTrack);
            gkh.KeyDown += new KeyEventHandler(gkh_KeyDown);

            this.filePath = filePath;
            wplayer.CurrentPlaylistChange += wplayer_CurrentPlaylistChange;
            playlist = wplayer.playlistCollection.newPlaylist("myplaylist");
            
            PlaySong(filePath, false);

            settings = File.ReadAllText("settings.txt", Encoding.UTF8);

            if (settings.IndexOf("Loop=True") != -1)
                LoopMethod();

            if (settings.IndexOf("Shuffle=True") != -1)
                ShuffleMethod();

            string volume = settings.Substring(settings.IndexOf("Volume=\"") + 8);
            volume = volume.Substring(0, volume.IndexOf("\""));
            volumeValue = Convert.ToInt32(volume);
            wplayer.settings.volume = volumeValue;
            VolumeBar.Value = volumeValue;

            playing = true;

            if (settings.IndexOf("DiscordRichPresence=\"Enabled\"") != -1)
            {
                discordRichPresenceStartInfo.WindowStyle = ProcessWindowStyle.Minimized;
                try { discordRichPresence = Process.Start(discordRichPresenceStartInfo); }
                catch { }
            }
        }

        private void wplayer_CurrentPlaylistChange(object sender, _WMPOCXEvents_CurrentPlaylistChangeEvent e)
        {
            try
            {
                playlistWindow.items = null;
                playlistWindow.FillItems();
                playlistWindow.FillList();
            }
            catch { }

            if (wplayer.currentPlaylist.count == 0)
            {
                wplayer.Visible = false;
                AlbumArtBox.BackgroundImage = Image.FromFile("Resources\\Unknown Album Art.png");
                TitleLabel.Text = "No Song Playing";
                ArtistLabel.Text = "";
                AlbumLabel.Text = "";
                GenreLabel.Text = "";
                TotalLengthLabel.Text = "0:00";
                ProgressBar.Value = 0;
            }
        }

        public void PlaySong(string filePath, bool replace)
        {
            this.filePath = filePath;
            
            try { wplayer.Ctlcontrols.stop(); }
            catch { }

            playing = true;

            WMPLib.IWMPMedia currentSong = wplayer.newMedia(filePath);
            
            if (replace == true)
            {
                wplayer.currentPlaylist.clear();
                playlist.clear();
            }
            
            playlist.appendItem(currentSong);
            wplayer.currentPlaylist = playlist;

            WMPLib.IWMPMedia playlistItem;
            if (playing == false)
                playlistItem = playlist.Item[0];

            wplayer.Ctlcontrols.play();

            wplayer.MediaChange += wplayer_MediaChange;
            wplayer.PlayStateChange += wplayer_PlayStateChange;

            positionTimer = new Timer();
            positionTimer.Interval = 1;
            positionTimer.Tick += positionTimer_Tick;
            positionTimer.Start();

             // DisplayInfo();
        }

        private void wplayer_MediaChange(object sender, _WMPOCXEvents_MediaChangeEvent e)
        {
            DisplayInfo();

            try { miniPlayer.DisplayInfo(); }
            catch { }

            int index = 0;
            for (int i = 0; i < playlist.count; i++)
            {
                if (wplayer.currentMedia.isIdentical[playlist.Item[i]])
                {
                    index = i;
                    break;
                }
            }

            try { playlistWindow.HighlightSong(index); }
            catch { }
        }

        private void wplayer_PlayStateChange(object sender, _WMPOCXEvents_PlayStateChangeEvent e)
        {
            string playState = wplayer.playState.ToString();

            currentFile = null;
            currentFile = TagLib.File.Create(filePath);
            string artist = currentFile.Tag.FirstPerformer;
            string title = currentFile.Tag.Title;
            string fileName = currentFile.Name;
            if (playState == "wmppsPaused")
            {
                PlayPauseButton.BackgroundImage = Image.FromFile("Resources\\Play.png");
                playing = false;

                if (artist != null && title != null)
                    richPresenceConfig = "[Identifiers]\nClientID=566600570509459469\n\n[State]\nState=" + artist + "\nDetails=" + title +
                    "\nStartTimestamp=\nEndTimestamp=\n\n\n[Images]\nLargeImage=logo\nLargeImageTooltip=\nSmallImage=pause\nSmallImageTooltip=";
                else if (artist == null && title != null)
                    richPresenceConfig = "[Identifiers]\nClientID=566600570509459469\n\n[State]\nState=Unknown Artist\nDetails=" + title +
                    "\nStartTimestamp=\nEndTimestamp=\n\n\n[Images]\nLargeImage=logo\nLargeImageTooltip=\nSmallImage=pause\nSmallImageTooltip=";
                else if (artist != null && title == null)
                    richPresenceConfig = "[Identifiers]\nClientID=566600570509459469\n\n[State]\nState=" + artist + "\nDetails=" + fileName +
                    "\nStartTimestamp=\nEndTimestamp=\n\n\n[Images]\nLargeImage=logo\nLargeImageTooltip=\nSmallImage=pause\nSmallImageTooltip=";
                else if (artist == null && title == null)
                    richPresenceConfig = "[Identifiers]\nClientID=566600570509459469\n\n[State]\nState=Unknown Artist\nDetails=" + fileName +
                    "\nStartTimestamp=\nEndTimestamp=\n\n\n[Images]\nLargeImage=logo\nLargeImageTooltip=\nSmallImage=pause\nSmallImageTooltip=";

                TextWriter tw = new StreamWriter("config.ini");
                tw.WriteLine(richPresenceConfig);
                tw.Close();
            }
            else if (playState == "wmppsPlaying")
            {
                PlayPauseButton.BackgroundImage = Image.FromFile("Resources\\Pause.png");
                playing = true;

                TimeSpan t = DateTime.UtcNow - new DateTime(1970, 1, 1);
                richStartTimeStamp = (int)t.TotalSeconds;
                richEndTimeStamp = richStartTimeStamp;
                richEndTimeStamp += (int)currentFile.Properties.Duration.TotalSeconds - ProgressBar.Value;

                if (artist != null && title != null)
                    richPresenceConfig = "[Identifiers]\nClientID=566600570509459469\n\n[State]\nState=" + artist + "\nDetails=" + title +
                    "\nStartTimestamp=" + richStartTimeStamp + "\nEndTimestamp=" + richEndTimeStamp + "\n\n\n[Images]\nLargeImage=logo\nLargeImageTooltip=\nSmallImage=play\nSmallImageTooltip=";
                else if (artist == null && title != null)
                    richPresenceConfig = "[Identifiers]\nClientID=566600570509459469\n\n[State]\nState=Unknown Artist\nDetails=" + title +
                    "\nStartTimestamp=" + richStartTimeStamp + "\nEndTimestamp=" + richEndTimeStamp + "\n\n\n[Images]\nLargeImage=logo\nLargeImageTooltip=\nSmallImage=play\nSmallImageTooltip=";
                else if (artist != null && title == null)
                    richPresenceConfig = "[Identifiers]\nClientID=566600570509459469\n\n[State]\nState=" + artist + "\nDetails=" + fileName +
                    "\nStartTimestamp=" + richStartTimeStamp + "\nEndTimestamp=" + richEndTimeStamp + "\n\n\n[Images]\nLargeImage=logo\nLargeImageTooltip=\nSmallImage=play\nSmallImageTooltip=";
                else if (artist == null && title == null)
                    richPresenceConfig = "[Identifiers]\nClientID=566600570509459469\n\n[State]\nState=Unknown Artist\nDetails=" + fileName +
                    "\nStartTimestamp=" + richStartTimeStamp + "\nEndTimestamp=" + richEndTimeStamp + "\n\n\n[Images]\nLargeImage=logo\nLargeImageTooltip=\nSmallImage=play\nSmallImageTooltip=";

                TextWriter tw = new StreamWriter("config.ini");
                tw.WriteLine(richPresenceConfig);
                tw.Close();
            }
            else if (playState == "wmppsStopped")
            {
                PlayPauseButton.BackgroundImage = Image.FromFile("Resources\\Play.png");
                playing = false;
            }
        }

        public void DisplayInfo()
        {
            string currentMedia = wplayer.currentMedia.sourceURL;

            currentFile = null;
            currentFile = TagLib.File.Create(currentMedia);
            wplayer.Visible = false;

            if (currentMedia.Substring(currentMedia.Length - 4).IndexOf(".mp4") != -1 || currentMedia.Substring(currentMedia.Length - 4).IndexOf(".webm") != -1)
            {
                wplayer.Visible = true;
            }
            else if (currentFile.Tag.Pictures.Length >= 1)
            {
                var bin = (byte[])(currentFile.Tag.Pictures[0].Data.Data);
                AlbumArtBox.BackgroundImage = Image.FromStream(new MemoryStream(bin)).GetThumbnailImage(500, 500, null, IntPtr.Zero);
            }
            else
                AlbumArtBox.BackgroundImage = Image.FromFile("Resources\\Unknown Album Art.png");

            TitleLabel.Text = currentFile.Tag.Title;

            string fileName = currentFile.Name;
            if (currentFile.Tag.Title == null)
            {
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

            ArtistLabel.Text = currentFile.Tag.FirstPerformer;

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

            string artist = currentFile.Tag.FirstPerformer;
            string title = currentFile.Tag.Title;
            
            fileName = fileName.Substring(0, fileName.Length - 4);

            TimeSpan t = DateTime.UtcNow - new DateTime(1970, 1, 1);
            richStartTimeStamp = (int)t.TotalSeconds;
            richEndTimeStamp = richStartTimeStamp;
            richEndTimeStamp += (int)currentFile.Properties.Duration.TotalSeconds - ProgressBar.Value;

            if (artist != null && title != null)
                richPresenceConfig = "[Identifiers]\nClientID=566600570509459469\n\n[State]\nState=" + artist + "\nDetails=" + title +
                "\nStartTimestamp=" + richStartTimeStamp + "\nEndTimestamp=" + richEndTimeStamp + "\n\n\n[Images]\nLargeImage=logo\nLargeImageTooltip=\nSmallImage=play\nSmallImageTooltip=";
            else if (artist == null && title != null)
                richPresenceConfig = "[Identifiers]\nClientID=566600570509459469\n\n[State]\nState=Unknown Artist\nDetails=" + title +
                "\nStartTimestamp=" + richStartTimeStamp + "\nEndTimestamp=" + richEndTimeStamp + "\n\n\n[Images]\nLargeImage=logo\nLargeImageTooltip=\nSmallImage=play\nSmallImageTooltip=";
            else if (artist != null && title == null)
                richPresenceConfig = "[Identifiers]\nClientID=566600570509459469\n\n[State]\nState=" + artist + "\nDetails=" + fileName +
                "\nStartTimestamp=" + richStartTimeStamp + "\nEndTimestamp=" + richEndTimeStamp + "\n\n\n[Images]\nLargeImage=logo\nLargeImageTooltip=\nSmallImage=play\nSmallImageTooltip=";
            else if (artist == null && title == null)
                richPresenceConfig = "[Identifiers]\nClientID=566600570509459469\n\n[State]\nState=Unknown Artist\nDetails=" + fileName +
                "\nStartTimestamp=" + richStartTimeStamp + "\nEndTimestamp=" + richEndTimeStamp + "\n\n\n[Images]\nLargeImage=logo\nLargeImageTooltip=\nSmallImage=play\nSmallImageTooltip=";

            TextWriter tw = new StreamWriter("config.ini");
            tw.WriteLine(richPresenceConfig);
            tw.Close();
        }

        private void PlayPauseButton_Click(object sender, EventArgs e)
        {
            PlayPause();
        }

        private void gkh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.MediaPlayPause)
                PlayPause();
            else if (e.KeyData == Keys.MediaPreviousTrack)
                wplayer.Ctlcontrols.previous();
            else if (e.KeyData == Keys.MediaNextTrack)
                wplayer.Ctlcontrols.next();
        }

        public void PlayPause()
        {
            if (playing == true)
            {
                playing = false;
                wplayer.Ctlcontrols.pause();
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
                wplayer.Ctlcontrols.play();
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
            wplayer.Ctlcontrols.previous();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            wplayer.Ctlcontrols.next();
        }

        private void VolumeBar_ValueChanged(object sender, EventArgs e)
        {
            wplayer.settings.volume = VolumeBar.Value;
            volumeValue = VolumeBar.Value;
        }

        private void LoopButton_Click(object sender, EventArgs e)
        {
            LoopMethod();
        }

        private void LoopMethod()
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
            ShuffleMethod();
        }

        public void ShuffleMethod()
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
                try { ProgressBar.Value = (int)wplayer.Ctlcontrols.currentPosition; }
                catch { this.Close(); }
            }

            int sec = 0;
            try { sec = (int)wplayer.Ctlcontrols.currentPosition; }
            catch { this.Close(); }

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

        private void ProgressBar_MouseCaptureChanged(object sender, EventArgs e)
        {
            int seconds = ProgressBar.Value;
            wplayer.Ctlcontrols.currentPosition = seconds;

            string artist = currentFile.Tag.FirstPerformer;
            string title = currentFile.Tag.Title;
            string fileName = currentFile.Name;
            
            if (playing == false)
            {
                if (artist != null && title != null)
                    richPresenceConfig = "[Identifiers]\nClientID=566600570509459469\n\n[State]\nState=" + artist + "\nDetails=" + title +
                    "\nStartTimestamp=\nEndTimestamp=\n\n\n[Images]\nLargeImage=logo\nLargeImageTooltip=\nSmallImage=pause\nSmallImageTooltip=";
                else if (artist == null && title != null)
                    richPresenceConfig = "[Identifiers]\nClientID=566600570509459469\n\n[State]\nState=Unknown Artist\nDetails=" + title +
                    "\nStartTimestamp=\nEndTimestamp=\n\n\n[Images]\nLargeImage=logo\nLargeImageTooltip=\nSmallImage=pause\nSmallImageTooltip=";
                else if (artist != null && title == null)
                    richPresenceConfig = "[Identifiers]\nClientID=566600570509459469\n\n[State]\nState=" + artist + "\nDetails=" + fileName +
                    "\nStartTimestamp=\nEndTimestamp=\n\n\n[Images]\nLargeImage=logo\nLargeImageTooltip=\nSmallImage=pause\nSmallImageTooltip=";
                else if (artist == null && title == null)
                    richPresenceConfig = "[Identifiers]\nClientID=566600570509459469\n\n[State]\nState=Unknown Artist\nDetails=" + fileName +
                    "\nStartTimestamp=\nEndTimestamp=\n\n\n[Images]\nLargeImage=logo\nLargeImageTooltip=\nSmallImage=pause\nSmallImageTooltip=";

                TextWriter tw = new StreamWriter("config.ini");
                tw.WriteLine(richPresenceConfig);
                tw.Close();
            }
            else
            {
                TimeSpan t = DateTime.UtcNow - new DateTime(1970, 1, 1);
                richStartTimeStamp = (int)t.TotalSeconds;
                richEndTimeStamp = richStartTimeStamp;
                richEndTimeStamp += (int)currentFile.Properties.Duration.TotalSeconds - ProgressBar.Value;

                if (artist != null && title != null)
                    richPresenceConfig = "[Identifiers]\nClientID=566600570509459469\n\n[State]\nState=" + artist + "\nDetails=" + title +
                    "\nStartTimestamp=" + richStartTimeStamp + "\nEndTimestamp=" + richEndTimeStamp + "\n\n\n[Images]\nLargeImage=logo\nLargeImageTooltip=\nSmallImage=play\nSmallImageTooltip=";
                else if (artist == null && title != null)
                    richPresenceConfig = "[Identifiers]\nClientID=566600570509459469\n\n[State]\nState=Unknown Artist\nDetails=" + title +
                    "\nStartTimestamp=" + richStartTimeStamp + "\nEndTimestamp=" + richEndTimeStamp + "\n\n\n[Images]\nLargeImage=logo\nLargeImageTooltip=\nSmallImage=play\nSmallImageTooltip=";
                else if (artist != null && title == null)
                    richPresenceConfig = "[Identifiers]\nClientID=566600570509459469\n\n[State]\nState=" + artist + "\nDetails=" + fileName +
                    "\nStartTimestamp=" + richStartTimeStamp + "\nEndTimestamp=" + richEndTimeStamp + "\n\n\n[Images]\nLargeImage=logo\nLargeImageTooltip=\nSmallImage=play\nSmallImageTooltip=";
                else if (artist == null && title == null)
                    richPresenceConfig = "[Identifiers]\nClientID=566600570509459469\n\n[State]\nState=Unknown Artist\nDetails=" + fileName +
                    "\nStartTimestamp=" + richStartTimeStamp + "\nEndTimestamp=" + richEndTimeStamp + "\n\n\n[Images]\nLargeImage=logo\nLargeImageTooltip=\nSmallImage=play\nSmallImageTooltip=";

                TextWriter tw = new StreamWriter("config.ini");
                tw.WriteLine(richPresenceConfig);
                tw.Close();
            }
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
            playlistWindow = new Playlist(this);
            playlistWindow.Show();
        }

        private void TagEditorButton_Click(object sender, EventArgs e)
        {
            string fileName = wplayer.currentMedia.sourceURL;
            
            try { tagEditor.FillFields(fileName); }
            catch
            {
                tagEditor = new TagEditor(this, main);
                tagEditor.Show();
            }
        }

        private void Player_FormClosed(object sender, FormClosedEventArgs e)
        {
            string segment1 = settings.Substring(0, settings.IndexOf("Loop=") + 5);
            
            TextWriter tw = new StreamWriter("settings.txt");
            tw.WriteLine(segment1 + looping.ToString());
            tw.WriteLine("Shuffle=" + shuffle.ToString());
            tw.WriteLine("Volume=\"" + volumeValue.ToString() + "\"");
            tw.Close();

            wplayer.Ctlcontrols.stop();
            wplayer.settings.volume = 100;

            wplayer.currentPlaylist.clear();
            wplayer.playlistCollection.remove(wplayer.currentPlaylist);

            try
            {
                discordRichPresence.CloseMainWindow();
                discordRichPresence.Close();
            }
            catch { }

            this.Dispose();
        }
    }
}