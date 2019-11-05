using System;
using System.Collections.Generic;
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
        MainForm refer;

        WaveOutEvent outputDevice;

        public List<AudioFileReader> playlist = new List<AudioFileReader>();
        public int playlistIndex = 0;
        
        public bool playing = false;
        bool loop = false;

        Timer positionTimer;

        public Player(MainForm refer)
        {
            this.refer = refer;

            

            positionTimer = new Timer();
            positionTimer.Interval = 500;
            positionTimer.Elapsed += PositionTimer_Elapsed;

            positionTimer.Start();
        }

        private void PositionTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine(playlist.Count);
            SetProgressBarValue(Convert.ToInt32(playlist[playlistIndex].CurrentTime.TotalSeconds));

            // refer.BarProgressSlider.Value = Convert.ToInt32(playlist[playlistIndex].CurrentTime.TotalSeconds);
        }

        public void Play()
        {
            try
            {
                outputDevice.Play();
                playing = true;
            }
            catch
            {
                InitializeSong();
                outputDevice.Play();
                playing = true;
            }

            refer.BarPausePlayButton.Text = "||";
        }

        public void Pause()
        {
            outputDevice.Pause();
            playing = false;
            refer.BarPausePlayButton.Text = ">";
        }

        public void LoopToggle()
        {
            //
        }

        public void PreviousTrack()
        {
            playlistIndex -= 2;
            NextSong();
        }

        public void NextTrack()
        {
            NextSong();
        }

        public void ShuffleToggle()
        {
            //
        }

        private void InitializeSong()
        {
            outputDevice.Init(playlist[playlistIndex]);
            if (playing)
                outputDevice.Play();

            // Set progress bar value and maximum
            SetProgressBarValue(0);
            SetProgressBarMaximum(Convert.ToInt32(playlist[playlistIndex].TotalTime.TotalSeconds));

            // Fill out title and artist labels
            TagLib.File currentFile = TagLib.File.Create(playlist[playlistIndex].FileName);

            SetTitleLabels(currentFile.Tag.Title);
            SetArtistLabels(currentFile.Tag.FirstPerformer);

            // Set current and max label positions
        }


        public void NewPlaylist(string[] files)
        {
            for (int index = 0; index < files.Length; index++)
                playlist.Add(new AudioFileReader(files[index]));

            playlistIndex = 0;
        }

        public void NextSong()
        {
            outputDevice = new WaveOutEvent();
            outputDevice.PlaybackStopped += OnPlaybackStopped;

            if (!playing)
                InitializeSong();

            if (playlistIndex < playlist.Count)
            {
                playlistIndex++;
                InitializeSong();
            }
            else if (loop)
            {
                playlistIndex = 0;
                InitializeSong();
            }
            else
            {
                outputDevice.Stop();
            }
        }

        private void OnPlaybackStopped(object sender, StoppedEventArgs e)
        {
            NextSong();
        }

        delegate void SetValueCallback(int value);
        delegate void SetTextCallback(string text);

        private void SetProgressBarValue(int value)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.refer.BarProgressSlider.InvokeRequired)
            {
                SetValueCallback d = new SetValueCallback(SetProgressBarValue);
                this.refer.BarProgressSlider.Invoke(d, new object[] { value });
            }
            else
            {
                this.refer.BarProgressSlider.Value = value;
            }
        }

        private void SetProgressBarMaximum(int value)
        {
            if (this.refer.BarProgressSlider.InvokeRequired)
            {
                SetValueCallback d = new SetValueCallback(SetProgressBarMaximum);
                this.refer.BarProgressSlider.Invoke(d, new object[] { value });
            }
            else
            {
                this.refer.BarProgressSlider.Maximum = value;
            }
        }

        private void SetTitleLabels(string text)
        {
            if (this.refer.BarTitleLabel.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetTitleLabels);
                refer.BarTitleLabel.Invoke(d, new object[] { text });
                // refer.FullTitleLabel.Invoke(d, new object[] { text });
            }
            else
            {
                refer.BarTitleLabel.Text = text;
                // refer.FullTitleLabel.Text = text;
            }
        }

        private void SetArtistLabels(string text)
        {
            if (this.refer.BarArtistLabel.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetArtistLabels);
                refer.BarArtistLabel.Invoke(d, new object[] { text });
                // refer.FullArtistLabel.Invoke(d, new object[] { text });
            }
            else
            {
                refer.BarArtistLabel.Text = text;
                // refer.FullArtistLabel.Text = text;
            }
        }
    }
}
