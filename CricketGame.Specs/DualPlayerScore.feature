Feature: DualPlayerScore
	In order to enjoy the game of cricket
	As a two player game
	I want to be told the winner of the game

@mytag
Scenario: Scores of both player will be zero when game starts
	When Players start the game of cricket
	Then the scores of both players will be 0

Scenario: Player1 should be able to score runs
	Given Player1 has started a game of cricket
	When Player1 scores 4 runs
	Then The player1 score should be 4