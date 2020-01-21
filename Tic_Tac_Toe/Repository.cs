using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    public class Repository
    {
        private List<ScoreEntity> scores = new List<ScoreEntity>();


        public List<ScoreEntity> GetScore()
        {
            return scores;
        }

        public void AddScore(ScoreEntity score)
        {
            scores.Add(score);
        }


        private Repository() { }
        private static Repository instance = null;
        private static readonly object lockObj = new object();

        public static Repository Instance
        {
            get
            {
                lock (lockObj)
                {
                    if (instance == null)
                    {
                        instance = new Repository();
                    }
                    return instance;
                }
            }
        }
    }

}
