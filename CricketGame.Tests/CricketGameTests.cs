﻿using System;
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
        public void DualPlayerScore_NewGame_ShouldBeZero()
        {
            var game = new Cricket();
            Assert.IsTrue(game.PlayerScore == 0);
        }


    }
}
