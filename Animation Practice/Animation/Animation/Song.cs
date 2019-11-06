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
        public AudioFileReader Audio;

        public Image AlbumArt;
        public string Title;
        public string Artist;
        public string Album;
        public string AlbumArtist;
        public string Genre;
        public string DateAdded;
        public string Path;
        public int Duration;

        public Song(string path)
        {
            Audio = new AudioFileReader(path);
        }
    }
}
