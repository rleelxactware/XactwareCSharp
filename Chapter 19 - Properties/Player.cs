using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_19___Properties
{
    class Player
    {
        private int score;



        public int Score
        {
            get
            {
                return score;
            }
            set
            {
                score = value;
                if (score < 0)
                    score = 0;
            }
        }




        //public int GetScore()
        //{
        //    return score;
        //}
        //public void SetScore(int score)
        //{
        //    this.score = score;
        //    if (this.score < 0)
        //        score = 0;
        //}
    }


}
