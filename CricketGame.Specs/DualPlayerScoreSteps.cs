using FluentAssertions;
using System;
using TechTalk.SpecFlow;
using CricketGame;
namespace CricketGame.Specs
{
    [Binding]
    public class DualPlayerScoreSteps
    {
        private Cricket _player1;
        private Cricket _player2;
        private CheckWinner game;
        [Given(@"Player(.*) has started a game of cricket")]
        public void GivenPlayerHasStartedAGameOfCricket(int playerNo)
        {
            if (playerNo == 1)
                _player1 = new Cricket();
            else if (playerNo == 2)
                _player2 = new Cricket();
        }

        [When(@"Player(.*) gets out")]
        public void WhenPlayerGetsOut(int playerNo)
        {
            if (playerNo == 1)
                _player1.Score(-1);
            else if (playerNo == 2)
                _player2.Score(-1);
        }

        [Given(@"Player(.*) scores (.*) runs")]
        public void GivenPlayerScoresRuns(int playerNo, int runs)
        {
            if (playerNo == 1)
                _player1.Score(runs);
            else if (playerNo == 2)
                _player2.Score(runs);
        }
        
        [Given(@"Player(.*) gets out")]
        public void GivenPlayerGetsOut(int playerNo)
        {
            if (playerNo == 1)
                _player1.Score(-1);
            else if (playerNo == 2)
                _player2.Score(-1);
        }
        
        [Then(@"the player(.*) score should win")]
        public void ThenThePlayerScoreShouldWin(int playerNo)
        {
            game = new CheckWinner(_player1,_player2);
            game.Winner.Should().Be("Player"+playerNo);
            
        }
        [Then(@"the match should be tied")]
        public void ThenTheMatchShouldBeTied()
        {
            game = new CheckWinner(_player1, _player2);
            game.Winner.Should().Be("Draw");
        }

    }
}
