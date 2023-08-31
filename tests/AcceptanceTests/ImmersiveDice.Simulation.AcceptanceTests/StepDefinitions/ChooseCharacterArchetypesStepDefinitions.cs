using ImmersiveDice.Simulation.Ubiquity.NeonArena.Aggregates.PlaythroughSimulationAggregate.ValueObjects;
using ImmersiveDice.Simulation.Ubiquity.NeonArena.Aggregates.PlaythroughSimulationAggregate;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Infrastructure;
using ImmersiveDice.Simulation.AcceptanceTests.Drivers;

namespace ImmersiveDice.Simulation.AcceptanceTests.StepDefinitions
{
    [Binding]
    public class ChooseCharacterArchetypesStepDefinitions
    {

        private readonly PlaythroughSimulationDriver _PlaythroughSimulationDriver;
        private readonly ISpecFlowOutputHelper _OutputHelper;

        public ChooseCharacterArchetypesStepDefinitions(PlaythroughSimulationDriver playthroughSimulationDriver, ISpecFlowOutputHelper outputHelper)
        {
            _PlaythroughSimulationDriver = playthroughSimulationDriver;
            _OutputHelper = outputHelper;
        }

        [Given(@"the quantity of each unique archetypes chosen is equal to or lower than the number of players in the simulation")]
        public void GivenTheQuantityOfEachUniqueArchetypesChosenIsEqualToOrLowerThanTheNumberOfPlayersInTheSimulation()
        {
            throw new PendingStepException();
        }

        [Given(@"the total quantity of archetypes chosen is equal to the number of players in the simulation")]
        public void GivenTheTotalQuantityOfArchetypesChosenIsEqualToTheNumberOfPlayersInTheSimulation()
        {
            throw new PendingStepException();
        }

        [Then(@"the character archetypes in the simulation configuration should all be an archetype from the chosen combination")]
        public void ThenTheCharacterArchetypesInTheSimulationConfigurationShouldAllBeAnArchetypeFromTheChosenCombination()
        {
            throw new PendingStepException();
        }

        [Then(@"the total quantity of character archetypes in the simulation configuration should be equal to the number of players in the simulation configuration")]
        public void ThenTheTotalQuantityOfCharacterArchetypesInTheSimulationConfigurationShouldBeEqualToTheNumberOfPlayersInTheSimulationConfiguration()
        {
            throw new PendingStepException();
        }

    }
}
