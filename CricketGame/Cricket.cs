using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketGame
{
    public class Cricket
    {
        public int PlayerScore { get; set; }

        public Cricket()
        {
            PlayerScore = 0;
        }
        

        public void Score(int v)
        {
            if(v==-1)
            {

            }
            else if (v < 7)
                PlayerScore += v;
            else
                PlayerScore = 0;
        }
    }
}
