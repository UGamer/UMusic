using System;
using System.Windows.Forms;
using TagLib;

namespace UMusic
{
    public partial class TagEditor : Form
    {
        Player reference;
        Form1 main;

        public TagEditor(Player reference, Form1 main)
        {
            this.reference = reference;
            this.main = main;
            InitializeComponent();
        }

        public TagEditor(string filePath, Form1 main)
        {
            InitializeComponent();
            FileNameBox.Text = filePath;

            File currentFile = File.Create(FileNameBox.Text);

            TitleBox.Text = currentFile.Tag.Title;
            ArtistBox.Text = currentFile.Tag.AlbumArtists[0];
            AlbumBox.Text = currentFile.Tag.Album;
            GenreBox.Text = currentFile.Tag.Genres[0];
            YearBox.Text = currentFile.Tag.Year.ToString();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            File currentFile = File.Create(FileNameBox.Text);

            currentFile.Tag.Title = TitleBox.Text;
            currentFile.Tag.AlbumArtists = new[] { ArtistBox.Text };
            currentFile.Tag.Album = AlbumBox.Text;
            currentFile.Tag.Genres = new[] { GenreBox.Text };
            currentFile.Tag.Year = (uint) Convert.ToInt32(YearBox.Text);

            try
            {
                currentFile.Tag.Pictures = new[] { new Picture(AlbumArtBox.Text) };
            }
            catch (ArgumentException f) { }
            
            if (ExplicitBox.Checked == true)
                currentFile.Tag.Comment = "EXPLICIT";

            try
            {
                currentFile.Save();
            }
            catch (System.IO.IOException g)
            {
                string message = "Tagging for \"" + TitleBox.Text + "\" has failed because the song is currently in use. Would you like to clear the queue to tag this song?";
                string caption = "Tagging Failed";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, caption, buttons);
                if (result == DialogResult.Yes)
                {
                    reference.wplayer.controls.stop();
                    currentFile.Save();
                }
            }
        }

        private void BrowseArtButton_Click(object sender, EventArgs e)
        {
            if (AlbumArtDialog.ShowDialog() == DialogResult.OK)
            {
                AlbumArtBox.Text = AlbumArtDialog.FileName;
            }
        }

        private void BrowseFileNameButton_Click(object sender, EventArgs e)
        {
            if (FileNameDialog.ShowDialog() == DialogResult.OK)
            {
                FileNameBox.Text = FileNameDialog.FileName;

                File currentFile = File.Create(FileNameBox.Text);

                TitleBox.Text = currentFile.Tag.Title;
                ArtistBox.Text = currentFile.Tag.AlbumArtists[0];
                AlbumBox.Text = currentFile.Tag.Album;
                GenreBox.Text = currentFile.Tag.Genres[0];
                YearBox.Text = currentFile.Tag.Year.ToString();
            }
        }

        /*
        private void FillAutoComplete()
        {
            DataTable dt = new DataTable();
            foreach (DataGridViewColumn col in main.DGV.Columns)
            {
                dt.Columns.Add(col.Name);
            }

            foreach (DataGridViewRow row in main.DGV.Rows)
            {
                DataRow dRow = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                dt.Rows.Add(dRow);
            }
            
            AutoCompleteStringCollection autoFill = new AutoCompleteStringCollection();
            int columnIndex = 4; // File Name column
            string[] table = new string[dt.Rows.Count];
            int index = 0;
            for (index = 0; index < dt.Rows.Count; index++)
            {
                table[index] = dt.Rows[index][columnIndex].ToString();
                autoFill.Add(table[index]);
            }
            FileNameBox.AutoCompleteCustomSource = autoFill;
        }
        */
    }
}
