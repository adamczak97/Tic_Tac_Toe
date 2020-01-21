using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe.App.Entities
{
    public class ScoreEntity
    {
        public int Id { get; set; }
        public string date { get; set; }
        public int number_of_turns { get; set; }

        public string who_won { get; set; }

        public override string ToString()
        {
            return string.Format("ID:{0}, Date: {1}, Number of turns{2}, Winner: {3}", Id, date, number_of_turns, who_won);
        }
    }
}
