using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CricketGame.Tests
{
    [TestClass]
    public class CricketGameTests
    {
        [TestMethod]
        public void PlayerScore_NewGame_ShouldBeZero()
        {
            var game = new Cricket();
            Assert.IsTrue(game.PlayerScore == 0);
        }
        [TestMethod]
        public void Score_ValidRuns_ShouldUpdateScore()
        {
            var game = new Cricket();
            game.Score(4);
            Assert.IsTrue(game.PlayerScore == 4);
        }
        [TestMethod]
        public void Score_InvalidRuns_ShouldNotUpdateScore()
        {
            var game = new Cricket();
            game.Score(7);
            Assert.IsTrue(game.PlayerScore == 0);
        }
        [TestMethod]
        public void Score_ValidRuns_ShouldNotUpdateScore()
        {
            var game = new Cricket();
            game.Score(3);
            Assert.IsTrue(game.PlayerScore == 3);
        }
        [TestMethod]
        public void DualGame_Player1_ShouldWin()
        {
            var player1 = new Cricket();
            var player2 = new Cricket();
            player1.Score(4);
            player1.Score(4);
            player1.Score(-1);
            player2.Score(4);
            player2.Score(3);
            player2.Score(-1);
            var win = new CheckWinner(player1, player2);
            Assert.AreEqual(win.Winner, "Player1");
        }
        [TestMethod]
        public void DualGame_Player2_ShouldWin()
        {
            var player1 = new Cricket();
            var player2 = new Cricket();
            player1.Score(4);
            player1.Score(3);
            player1.Score(-1);
            player2.Score(4);
            player2.Score(4);
            player2.Score(-1);
            var win = new CheckWinner(player1, player2);
            Assert.AreEqual(win.Winner, "Player2");
        }
        [TestMethod]
        public void DualGame_Match_ShouldBeTie()
        {
            var player1 = new Cricket();
            var player2 = new Cricket();
            player1.Score(4);
            player1.Score(3);
            player1.Score(4);
            player1.Score(-1);
            player2.Score(4);
            player2.Score(4);
            player2.Score(3);
            player2.Score(-1);
            var win = new CheckWinner(player1, player2);
            Assert.AreEqual(win.Winner, "Draw");
        }
    }
}
