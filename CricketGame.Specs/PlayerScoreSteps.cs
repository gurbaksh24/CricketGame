using FluentAssertions;
using System;
using TechTalk.SpecFlow;

namespace CricketGame.Specs
{
    [Binding]
    public class PlayerScoreSteps
    {
        private Cricket _game;
        private Cricket _player1;
        private Cricket _player2;
        [When(@"Player starts a game of cricket")]
        [Given(@"Player has started a game of cricket")]
        public void WhenPlayerHasStartedAGameOfCricket()
        {
            _game = new Cricket();
        }

        [When(@"Player scores (.*) runs")]
        public void WhenPlayerScoresRuns(int runs)
        {
            _game.Score(runs);
        }
        [Then(@"the player score should be (.*)")]
        public void ThenThePlayerScoreShouldBe(int score)
        {
            _game.PlayerScore.Should().Be(score);
        }
        [Given(@"Player has scored (.*) runs")]
        public void GivenPlayerHasScoredRuns(int p0)
        {
            _game.Score(4);
        }

        [Given(@"Player gets out")]
        public void GivenPlayerGetsOut()
        {
            _game.Score(-1);
        }

    }
}
