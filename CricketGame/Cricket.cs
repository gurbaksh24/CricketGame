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
        public string Winner { get; set; }

        public Cricket()
        {
            PlayerScore = 0;
        }
        

        public void Score(int v)
        {
            int flag = 0;
            if(v==-1)
            {
                flag = 1;
            }
            else if (v < 7 && v>0 && flag==0)
                PlayerScore += v;
            else
                PlayerScore += 0;
        }
    }
}
