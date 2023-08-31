Feature: Choose Character Archetypes

As a
	Game designer
I want to
	choose the number of times each character archetypes is included in a play-through simulation
So that I can
	evaluate the effect on simulated data when choosing different character archetype combinations

Background:
	Given a new simulation is being created
	And the quantity of players in the simulation is 4
	And the quantity of players is within the 2 and 6 quantity allowed by the game rules

@tag1
Scenario: User choose the character archetypes for the simulation
	Given the quantity of each unique archetypes chosen is equal to or lower than the number of players in the simulation
	And the total quantity of archetypes chosen is equal to the number of players in the simulation
	When the simulation creation is confirmed
	Then the character archetypes in the simulation configuration should all be an archetype from the chosen combination
	And the total quantity of character archetypes in the simulation configuration should be equal to the number of players in the simulation configuration
