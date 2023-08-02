Feature: Choose Quantity Of Players

As a
Game designer
I want to
choose the quantity of players for a play-through simulation
So that I can
evaluate the effect on simulated data when I input a different quantity of players

Background:
Given a new simulation is being created

Scenario: User choose the quantity of players for the simulation
Given the number for the quantity of players is 2
And 2 is within the allowed range by the game rules
When the simulation creation is confirmed
Then the quantity of players in the simulation configuration should be 2

#Scenario Outline: User choose the quantity of players for the simulation within the allowed range
#Given the number for the quantity of players is <QuantityOfPlayers>
#And <QuantityOfPlayers> is within the allowed <Range> by the game rules
#When the simulation creation is confirmed
#Then the quantity of players in the simulation configuration should be <Result>
