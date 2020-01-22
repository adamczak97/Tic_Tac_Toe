using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using System.Data.SQLite;
using MySql.Data.MySqlClient;
using System.Data;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using SQLitePCL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Tic_Tac_Toe

{
    class GetDate : Window2
    {
        public void getDate(int id, string date, int number_of_turns, string who_won)
        {
            string myCon =
                "Id = " + id + ";" +
                "Date " + date + ";" +
                "Rounds " + number_of_turns + ";" +
                "Winner " + who_won + ";";

            string sql = "SELECT * FROM scores;";

            MySqlConnection con = new MySqlConnection(myCon);

            try
            {
                con.Open();

                using (MySqlCommand cmdSel = new MySqlCommand(sql, con))
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmdSel);
                    da.Fill(dt);
                    dataGrid1.DataSource = dt.DefaultView;
                }
            }

            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Błąd polączenia");
            }
            //Zamknij połączenie po wyświetleniu danych
            con.Close();
        }
    }

}
