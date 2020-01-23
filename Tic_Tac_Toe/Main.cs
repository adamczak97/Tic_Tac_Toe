using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using SQLitePCL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Data.Sqlite;
using System.Data.SQLite;
using MySql.Data.MySqlClient;
using System.IO;


namespace Tic_Tac_Toe
{
    public class Main 
    {
        // SQLiteConnection con = new SQLiteConnection(string.Format("Data Source={0}", Path.Combine(Application.StartupPath, "scores.db")));
        //SQLiteCommand command;
        //string querySQL = "";

        public static SQLiteConnection _con;
        public static SQLiteConnection Con
        {
            get
            {
                if(!File.Exists(Path.Combine(Application.StartupPath, "scores.db")))
                {
                    _con = new SQLiteConnection(string.Format("Data Source={0}", Path.Combine(Application.StartupPath, "scores.db")));
                    _con.Open();
                    _con.Close();
                }
                else
                {
                    if (_con == null)
                        _con = new SQLiteConnection(string.Format("Data Source = {0}", Path.Combine(Application.StartupPath, "scores.db")));
                }
                return _con;
            }
        }
        public static SQLiteCommand Command;
        public static SQLiteDataReader Reader;
        public static string QuerySQL = "";
    }
}

            /*
            querySQL = string.Format("CREATE TABLE scores(Id integer primary key autoincrement, Date dateTime, Rounds integer, Winner text)");
            command = new SQLiteCommand(querySQL, con);
            command.ExecuteNonQuery();
            MessageBox.Show("Tabele utworzono");
            */