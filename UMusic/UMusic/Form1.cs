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

namespace UMusic
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            GetFiles();
        }
        
        private void GetFiles()
        {
            string[] files = Directory.GetFiles("music");

            string[] tableArray = new string[files.Length];

            string[] titles = new string[files.Length];

            TagLib.File currentFile;
            for (int index = 0; index < titles.Length; index++)
            {
                currentFile = TagLib.File.Create(files[index]);
                titles[index] = currentFile.Tag.Title;
                tableArray[index] = titles[index];
            }

            string[,] twoD = new string[files.Length, 2];

            int height = twoD.GetLength(0);
            int width = twoD.GetLength(1);

            DGV.ColumnCount = width;
            DGV.Columns[0].HeaderText = "Title";
            DGV.Columns[1].HeaderText = "File";

            for (int r = 0; r < height; r++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(this.DGV);

                twoD[r, 0] = titles[r];
                twoD[r, 1] = files[r];

                for (int c = 0; c < width; c++)
                {
                    row.Cells[c].Value = twoD[r, c];
                    row.Cells[1].Value = twoD[r, 1];
                }

                this.DGV.Rows.Add(row);
            }
        }

        private void DGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            string filePath = DGV.Rows[rowIndex].Cells[1].Value.ToString();
            Player player = new Player(filePath);
            player.Show();
        }
    }
}
