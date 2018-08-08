using System;
using TechTalk.SpecFlow;

namespace CricketGame.Specs
{
    [Binding]
    public class DualPlayerScoreSteps
    {
        private Cricket _player1;
        private Cricket _player2;

        [When(@"Players start the game of cricket")]
        public void WhenPlayersStartTheGameOfCricket()
        {
            _player1 = new Cricket();
            _player2 = new Cricket();
        }
        
        [Then(@"the scores of both players will be (.*)")]
        public void ThenTheScoresOfBothPlayersWillBe(int p0)
        {
            
        }
        [Given(@"Player(.*) has started a game of cricket")]
        public void GivenPlayerHasStartedAGameOfCricket(int playerNo)
        {
            if(playerNo==1)

        }

        [When(@"Player(.*) scores (.*) runs")]
        public void WhenPlayerScoresRuns(int p0, int p1)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"The player(.*) score should be (.*)")]
        public void ThenThePlayerScoreShouldBe(int p0, int p1)
        {
            ScenarioContext.Current.Pending();
        }


    }
}
