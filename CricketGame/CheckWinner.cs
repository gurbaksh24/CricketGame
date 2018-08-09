using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketGame
{
    public class CheckWinner
    {
        public string Winner { get; set; }
        public CheckWinner(Cricket player1,Cricket player2)
        {
            if (player1.PlayerScore > player2.PlayerScore)
                Winner = "Player1";
            else if (player1.PlayerScore < player2.PlayerScore)
                Winner = "Player2";
            else
                Winner = "Draw";
        }
    }
}
