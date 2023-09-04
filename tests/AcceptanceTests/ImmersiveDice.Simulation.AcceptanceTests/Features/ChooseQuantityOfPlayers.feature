Feature: Choose Quantity Of Players

As a
	Game designer
I want to
	choose the quantity of players for a play-through simulation
So that I can
	evaluate the effect on simulated data when I input a different quantity of players

Background:
	Given a new simulation is being created
	And the quantity of players in the simulation is 4
	And the quantity of players is within the 2 and 6 quantity allowed by the game rules

Scenario: User choose the quantity of players for the simulation
	Given the quantity of players chosen by the user is 4
	And the quantity of players is within the 2 and 6 quantity allowed by the game rules
	When the simulation creation is confirmed
	Then the quantity of players in the simulation configuration should be 4

#Scenario Outline: User choose the quantity of players for the simulation within the allowed range
#Given the quantity of players chosen by the user is a positive integral <QuantityOfPlayers>
#And the quantity is within the <Minimum> and <Maximum> quantity allowed by the game rules
#When the simulation creation is confirmed
#Then the quantity of players in the simulation configuration should be <QuantityOfPlayers>
