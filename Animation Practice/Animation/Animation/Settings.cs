using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animation
{
    public class Settings
    {
        public string Name;
        public bool DiscordEnabled;
        public string DownloadLocation;
        public string SortBy;
        public string SortOrder;
        public bool Loop;
        public bool Shuffle;
        public int Volume;

        public Settings()
        {
            string connectionString = "Data Source=user.db;Version=3;";
            SQLiteConnection con = new SQLiteConnection(connectionString);
            SQLiteCommand selectSettingsCmd = new SQLiteCommand("SELECT * FROM Settings", con);
            SQLiteDataAdapter da;

            con.Open();

            selectSettingsCmd.CommandType = CommandType.Text;
            da = new SQLiteDataAdapter(selectSettingsCmd);
            DataTable settingsTable = new DataTable();
            da.Fill(settingsTable);

            con.Close();

            Name = settingsTable.Rows[0]["Value"].ToString();
            DiscordEnabled = Convert.ToBoolean(settingsTable.Rows[1]["Value"].ToString());
            DownloadLocation = settingsTable.Rows[2]["Value"].ToString();
            SortBy = settingsTable.Rows[3]["Value"].ToString();
            SortOrder = settingsTable.Rows[4]["Value"].ToString();
            Loop = Convert.ToBoolean(settingsTable.Rows[5]["Value"].ToString());
            Shuffle = Convert.ToBoolean(settingsTable.Rows[6]["Value"].ToString());
            Volume = Convert.ToInt32(settingsTable.Rows[7]["Value"].ToString());
        }

        public void WriteToDatabase()
        {
            string connectionString = "Data Source=user.db;Version=3;";
            SQLiteConnection con = new SQLiteConnection(connectionString);
            SQLiteCommand[] updateCmds = new SQLiteCommand[8];
            string[] categories = { "Name", "DiscordEnabled", "DownloadLocation", "SortBy", "SortOrder", "Loop", "Shuffle", "Volume" };

            con.Open();

            for (int index = 0; index < updateCmds.Length; index++)
            {
                updateCmds[index] = new SQLiteCommand("UPDATE Settings SET Value = @Value WHERE Category = '" + categories[index] + "';", con);
            }

            updateCmds[0].Parameters.AddWithValue("@Value", Name);
            updateCmds[1].Parameters.AddWithValue("@Value", DiscordEnabled.ToString());
            updateCmds[2].Parameters.AddWithValue("@Value", DownloadLocation);
            updateCmds[3].Parameters.AddWithValue("@Value", SortBy);
            updateCmds[4].Parameters.AddWithValue("@Value", SortOrder);
            updateCmds[5].Parameters.AddWithValue("@Value", Loop.ToString());
            updateCmds[6].Parameters.AddWithValue("@Value", Shuffle.ToString());
            updateCmds[7].Parameters.AddWithValue("@Value", Volume);

            for (int index = 0; index < updateCmds.Length; index++)
            {
                updateCmds[index].ExecuteNonQuery();
                updateCmds[index].Parameters.RemoveAt("@Value");
            }

            con.Close();
        }
    }
}
