using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace Animation
{
    public class Song
    {
        public AudioFileReader audio;

        public Image albumArt;
        public string title;
        public string artist;
        public string album;
        public string albumArtist;
        public string genre;
        public string dateAdded;
        public string path;

        public Song()
        {

        }
    }
}
