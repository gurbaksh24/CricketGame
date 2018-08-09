Feature: DualPlayerScore
	In order to enjoy the game of cricket
	As a two player game
	I want to be told the winner of the game

@mytag

Scenario: Player1 will win the match
	Given Player1 has started a game of cricket
	And Player1 scores 4 runs
	And Player1 scores 4 runs
	And Player1 gets out
	And Player2 has started a game of cricket
	And Player2 scores 4 runs
	And Player2 scores 3 runs
	When Player2 gets out
	Then the player1 score should win

Scenario: Player2 will win the match
	Given Player1 has started a game of cricket
	And Player1 scores 4 runs
	And Player1 scores 3 runs
	And Player1 gets out
	And Player2 has started a game of cricket
	And Player2 scores 4 runs
	And Player2 scores 4 runs
	When Player2 gets out
	Then the player2 score should win


Scenario: Similar scores will result in tie
	Given Player1 has started a game of cricket
	And Player1 scores 4 runs
	And Player1 scores 3 runs
	And Player1 gets out
	And Player2 has started a game of cricket
	And Player2 scores 4 runs
	And Player2 scores 3 runs
	When Player2 gets out
	Then the match should be tied
