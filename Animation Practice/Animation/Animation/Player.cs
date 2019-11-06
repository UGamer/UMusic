using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Timers;
// using System.Threading;
using System.Threading.Tasks;

using NAudio.Wave;
using NAudio.Wave.SampleProviders;

using TagLib;

namespace Animation
{
    public class Player
    {
        MainForm Refer;

        public WaveOutEvent OutputDevice;

        public List<Song> Playlist = new List<Song>();
        public int PlaylistIndex = 0;

        public bool ProgressGrabbed = false;
        public bool Playing = false;
        bool Loop = false;

        Timer PositionTimer;

        public Player(MainForm refer)
        {
            this.Refer = refer;

            PositionTimer = new Timer();
            PositionTimer.Interval = 500;
            PositionTimer.Elapsed += PositionTimer_Elapsed;

            PositionTimer.Start();
        }

        private void PositionTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (!ProgressGrabbed)
                try { SetProgressBarValue(Convert.ToInt32(Playlist[PlaylistIndex].Audio.CurrentTime.TotalSeconds)); } catch { }

            // refer.BarProgressSlider.Value = Convert.ToInt32(playlist[playlistIndex].CurrentTime.TotalSeconds);
        }

        public void Play()
        {
            try
            {
                OutputDevice.Play();
                Playing = true;
            }
            catch
            {
                InitializeSong();
                OutputDevice.Play();
                Playing = true;
            }

            Refer.BarPausePlayButton.Text = "||";
        }

        public void Pause()
        {
            OutputDevice.Pause();
            Playing = false;
            Refer.BarPausePlayButton.Text = ">";
        }

        public void LoopToggle()
        {
            //
        }

        public void ShuffleToggle()
        {
            //
        }

        private void InitializeSong()
        {
            OutputDevice = new WaveOutEvent();
            OutputDevice.PlaybackStopped += OnPlaybackStopped;

            OutputDevice.Init(Playlist[PlaylistIndex].Audio);
            if (Playing)
                OutputDevice.Play();

            // Set progress bar value and maximum
            SetProgressBarValue(0);
            SetProgressBarMaximum(Convert.ToInt32(Playlist[PlaylistIndex].Audio.TotalTime.TotalSeconds));

            // Fill out bar labels and album art
            
            SetTitleLabels(Playlist[PlaylistIndex].Title);
            SetArtistLabels(Playlist[PlaylistIndex].Artist);

            SetAlbumArt(Playlist[PlaylistIndex].AlbumArt);

            // Set current and max label positions
        }

        public void NewPlaylist(Song[] songs)
        {
            for (int index = 0; index < songs.Length; index++)
            {
                songs[index].Audio = new AudioFileReader(songs[index].Path);

                Playlist.Add(songs[index]);
            }

            PlaylistIndex = 0;
        }

        public void NextSong()
        {
            OutputDevice.Stop();

            OutputDevice = new WaveOutEvent();
            OutputDevice.PlaybackStopped += OnPlaybackStopped;

            if (PlaylistIndex < Playlist.Count)
            {
                InitializeSong();
            }
            else if (Loop)
            {
                PlaylistIndex = 0;
                InitializeSong();
            }
            else
            {
                OutputDevice.Stop();
            }
        }

        private void OnPlaybackStopped(object sender, StoppedEventArgs e)
        {
            if (Playing)
            {

                PlaylistIndex++;
                NextSong();
            }
        }

        delegate void SetValueCallback(int value);
        delegate void SetTextCallback(string text);
        delegate void SetImageCallback(Image image);

        private void SetProgressBarValue(int value)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.Refer.BarProgressSlider.InvokeRequired)
            {
                SetValueCallback d = new SetValueCallback(SetProgressBarValue);
                this.Refer.BarProgressSlider.Invoke(d, new object[] { value });
            }
            else
            {
                try { this.Refer.BarProgressSlider.Value = value; } catch { }
            }
        }

        private void SetProgressBarMaximum(int value)
        {
            if (this.Refer.BarProgressSlider.InvokeRequired)
            {
                SetValueCallback d = new SetValueCallback(SetProgressBarMaximum);
                this.Refer.BarProgressSlider.Invoke(d, new object[] { value });
            }
            else
            {
                this.Refer.BarProgressSlider.Maximum = value;
            }
        }

        private void SetTitleLabels(string text)
        {
            if (this.Refer.BarTitleLabel.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetTitleLabels);
                Refer.BarTitleLabel.Invoke(d, new object[] { text });
                // Refer.FullTitleLabel.Invoke(d, new object[] { text });
            }
            else
            {
                Refer.BarTitleLabel.Text = text;
                // Refer.FullTitleLabel.Text = text;
            }
        }

        private void SetArtistLabels(string text)
        {
            if (this.Refer.BarArtistLabel.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetArtistLabels);
                Refer.BarArtistLabel.Invoke(d, new object[] { text });
                // Refer.FullArtistLabel.Invoke(d, new object[] { text });
            }
            else
            {
                Refer.BarArtistLabel.Text = text;
                // Refer.FullArtistLabel.Text = text;
            }
        }

        private void SetAlbumArt(Image image)
        {
            if (this.Refer.BarAlbumArt.InvokeRequired)
            {
                SetImageCallback d = new SetImageCallback(SetAlbumArt);
                Refer.BarAlbumArt.Invoke(d, new object[] { image });
                // Refer.FullAlbumArt.Invoke(d, new object[] { image });
            }
            else
            {
                Refer.BarAlbumArt.BackgroundImage = image;
                // Refer.FullAlbumArt.BackgroundImage = image;
            }
        }
    }
}
