using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TagLib;

namespace UMusic
{
    public partial class TagEditor : Form
    {
        public TagEditor()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            File currentFile = File.Create(FileNameBox.Text);

            currentFile.Tag.Title = TitleBox.Text;
            currentFile.Tag.AlbumArtists = new[] { ArtistBox.Text };
            currentFile.Tag.Album = AlbumBox.Text;
            currentFile.Tag.Genres = new[] { GenreBox.Text };
            currentFile.Tag.Year = (uint) Convert.ToInt32(YearBox.Text);
            currentFile.Tag.Pictures = new[] { new Picture(AlbumArtBox.Text) };

            if (ExplicitBox.Checked == true)
                currentFile.Tag.Comment = "EXPLICIT";

            currentFile.Save();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            if (AlbumArtDialog.ShowDialog() == DialogResult.OK)
            {
                AlbumArtBox.Text = AlbumArtDialog.FileName;
            }
        }

        /*
        public byte[] ExecuteTagging(byte[] inputFile, string title, string artist, string album, string comment, uint year, string copyright, byte[] image)
        {
            var stream = new MemoryStream();
            var writer = new BinaryWriter(stream);
            writer.Write(inputFile);
            using (var audioFile = TagLib.File.Create(new SimpleFileAbstraction(stream)))
            {
                audioFile.Tag.Title = title;
                audioFile.Tag.Performers = new[] { artist };
                audioFile.Tag.Album = album;
                audioFile.Tag.Comment = comment;
                audioFile.Tag.Genres = new[] { "Podcast" };
                audioFile.Tag.Year = year;
                audioFile.Tag.Copyright = copyright;
                audioFile.Tag.Pictures = new[] { new Picture(image) };
                audioFile.Save();
            }

            stream.Position = 0;
            using (var reader = new BinaryReader(stream))
            {
                return reader.ReadBytes((int)stream.Length);
            }
        }
        */
    }
}
