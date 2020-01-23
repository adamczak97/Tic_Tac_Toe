using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe.App;

namespace Tic_Tac_Toe
{
    public partial class Window2 : Score
    {
        public Window2()
        {
            InitializeComponent();
        }
        List<Score> ListOfScores = null;

       void InicjalizacjaDanych()
        {
            ListOfScores = Scores.ScoreList;
        }



        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
