using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace Animation
{
    public class Player
    {
        WaveOutEvent outputDevice;

        List<AudioFileReader> playlist = new List<AudioFileReader>();
        int playlistIndex = 0;

        bool playing = false;

        public Player()
        {
            outputDevice = new WaveOutEvent();
            outputDevice.PlaybackStopped += OnPlaybackStopped;
        }

        private void OnPlaybackStopped(object sender, StoppedEventArgs e)
        {
            if (playlistIndex < playlist.Count)
            {
                playlistIndex++;
                outputDevice.Init(playlist[playlistIndex]);
            }

            throw new NotImplementedException();
        }

        public void PlayPause()
        {
            if (playlist.Count == 0)
            {
                playlist.Add(new AudioFileReader(@"music\Feel Good.mp3"));
                outputDevice.Init(playlist[playlistIndex]);
            }

            if (playing)
            {
                outputDevice.Pause();
                playing = false;
            }
            else
            {
                outputDevice.Play();
                playing = true;
            }
        }
    }
}
