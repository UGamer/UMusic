using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animation
{
    public partial class LoadingForm : Form
    {
        MainForm refer;

        public LoadingForm(MainForm refer)
        {
            this.refer = refer;

            string connectionString = "Data Source=user.db;Version=3;";
            SQLiteConnection con = new SQLiteConnection(connectionString);
            SQLiteCommand selectSettingsCmd = new SQLiteCommand("SELECT * FROM Settings", con);
            SQLiteCommand selectFoldersCmd = new SQLiteCommand("SELECT * FROM Folders", con);

            SQLiteDataAdapter da;
            con.Open();

            selectSettingsCmd.CommandType = CommandType.Text;
            da = new SQLiteDataAdapter(selectSettingsCmd);
            DataTable settingsTable = new DataTable();
            da.Fill(settingsTable);

            selectFoldersCmd.CommandType = CommandType.Text;
            da = new SQLiteDataAdapter(selectFoldersCmd);
            DataTable foldersTable = new DataTable();
            da.Fill(foldersTable);

            con.Close();
            
            InitializeComponent();

            DataTable musicTable = CreateMusicTable(foldersTable);

            refer.ListDGV.DataSource = musicTable;
        }

        private DataTable CreateMusicTable(DataTable foldersTable)
        {
            ArrayList files = new ArrayList();
            for (int folderIndex = 0; folderIndex < foldersTable.Rows.Count; folderIndex++)
            {
                try
                {
                    string[] directoryFiles = Directory.GetFiles(foldersTable.Rows[folderIndex][0].ToString());
                    for (int filesIndex = 0; filesIndex < directoryFiles.Length; filesIndex++)
                        files.Add(directoryFiles[filesIndex]);
                }
                catch { }
            }

            LoadedBar.Maximum = files.Count;

            int index;
            DateTime fileCreated;
            TagLib.File currentFile;
            // Image albumArt = Image.FromFile(@"resources\Unknown Album Art.png");
            MemoryStream ms;

            DataTable musicTable = new DataTable();

            // musicTable.Columns.Add("Album Art", typeof(Image));
            musicTable.Columns.Add("Title");
            musicTable.Columns.Add("Artist(s)");
            musicTable.Columns.Add("Album");
            musicTable.Columns.Add("Album Artist(s)");
            musicTable.Columns.Add("Genre");
            musicTable.Columns.Add("Date Added");
            musicTable.Columns.Add("File");

            // Image albumArt2;
            // ArrayList albumArts = new ArrayList();
            for (index = 0; index < files.Count; index++)
            {
                try
                {
                    currentFile = TagLib.File.Create(files[index].ToString());

                    DataRow dRow = musicTable.NewRow();

                    /*
                    if (currentFile.Tag.Pictures.Length > 0)
                    {
                        MemoryStream mStream = new MemoryStream(currentFile.Tag.Pictures[0].Data.Data);
                        // albumArts.Add(Image.FromStream(mStream));
                        albumArt2 = Image.FromStream(mStream);
                        // dRow["Album Art"] = Image.FromStream(mStream);
                        mStream.Dispose();
                    }
                    else */
                    // dRow["Album Art"] = albumArt;

                    string title = currentFile.Tag.Title;
                    if (currentFile.Tag.Title == null)
                    {
                        string fileName = files[index].ToString();
                        for (bool ready = false; ready == false;)
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
                        title = fileName;
                    }

                    fileCreated = File.GetCreationTime(files[index].ToString());

                    dRow["Title"] = title;
                    dRow["Artist(s)"] = currentFile.Tag.FirstPerformer;
                    dRow["Album"] = currentFile.Tag.Album;
                    dRow["Album Artist(s)"] = currentFile.Tag.FirstAlbumArtist;
                    dRow["Genre"] = currentFile.Tag.FirstGenre;
                    dRow["Date Added"] = string.Format("{0:00}/{1:00}/{2:00} {3:00}:{4:00}:{5:00}", fileCreated.Year,
                        fileCreated.Month, fileCreated.Day, fileCreated.Hour, fileCreated.Minute, fileCreated.Second);
                    dRow["File"] = files[index].ToString();

                    musicTable.Rows.Add(dRow);
                }
                catch (TagLib.UnsupportedFormatException) { }

                LoadedBar.Value = index + 1;
                CurrentLoadedLabel.Text = (index + 1).ToString();
            }

            string[,] twoD = new string[files.Count, 8];

            int height = twoD.GetLength(0);
            int width = twoD.GetLength(1);


            // if (settings.IndexOf("[Album Art]\nVisible = True") != -1)
            // dataTable.Columns.Add("Album Art", typeof(byte[]));

            /*
            for (int r = 0; r < height; r++)
            {
                for (int x = 0; x < dataTable.Rows.Count; x++)
                {
                    try
                    {
                        currentFile = TagLib.File.Create(dataTable.Rows[x]["File"].ToString());
                        if (currentFile.Tag.Pictures.Length > 0)
                        {
                            bin = currentFile.Tag.Pictures[0].Data.Data;
                            currentAlbumArt = Image.FromStream(new MemoryStream(bin)).GetThumbnailImage(500, 500, null, IntPtr.Zero);
                            dataTable.Rows[x][0] = imageToByteArray(currentAlbumArt);
                        }
                        else
                            dataTable.Rows[x][0] = imageToByteArray(albumArt);
                    }
                    catch
                    {
                        dataTable.Rows[x][0] = imageToByteArray(albumArt);
                    }
                }
            }
            */

            refer.ListDGV.DataSource = musicTable;

            // DGV.Columns["Album Art"].Width = 50;
            // ((DataGridViewImageColumn)DGV.Columns[0]).ImageLayout = DataGridViewImageCellLayout.Zoom;

            refer.ListDGV.Columns["Title"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            refer.ListDGV.Columns["Artist(s)"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            refer.ListDGV.Columns["Album"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            refer.ListDGV.Columns["Album Artist(s)"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            refer.ListDGV.Columns["Genre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            refer.ListDGV.Columns["Date Added"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            refer.ListDGV.Columns["File"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            /*
            settings = File.ReadAllText("settings.txt", Encoding.UTF8);

            int sortColumnIndex = settings.IndexOf("SortBy=");
            int sortOrderIndex = settings.IndexOf("Order=");

            sortColumn = settings.Substring(sortColumnIndex + 8);
            sortColumn = sortColumn.Substring(0, sortColumn.IndexOf("\""));

            sortOrder = settings.Substring(sortOrderIndex + 7);
            sortOrder = sortOrder.Substring(0, sortOrder.IndexOf("\""));

            bool columnFound = false;
            for (index = 0; index < DGV.Columns.Count && columnFound == false; index++)
            {
                if (DGV.Columns[index].HeaderText == sortColumn)
                {
                    columnFound = true;
                    try
                    {
                        if (sortOrder == "Ascending")
                            refer.ListDGV.Sort(refer.ListDGV.Columns[index], ListSortDirection.Ascending);
                        else
                            refer.ListDGV.Sort(refer.ListDGV.Columns[index], ListSortDirection.Descending);
                    }
                    catch { }
                }
            }
            */

            for (index = 0; index < refer.ListDGV.Rows.Count; index++)
            {
                if (refer.ListDGV.Rows[index].Cells["File"].Value.ToString().IndexOf(".jpg") != -1)
                {
                    refer.ListDGV.Rows.RemoveAt(index);
                    index--;
                }
            }

            this.Close();
            return musicTable;
        }
    }
}
