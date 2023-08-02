using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Infrastructure;

namespace ImmersiveDice.Simulation.AcceptanceTests.StepDefinitions
{
    [Binding]
    public sealed class ChooseQuantityOfPlayersStepDefinitions
    {
        private readonly ISpecFlowOutputHelper _OutputHelper;

        public ChooseQuantityOfPlayersStepDefinitions(ISpecFlowOutputHelper outputHelper)
        {
            _OutputHelper = outputHelper;
        }

        [Given(@"a new simulation is being created")]
        public void GivenANewSimulationIsBeingCreated()
        {
            //TODO: implement arrange (precondition) logic

            throw new PendingStepException();

            _OutputHelper.WriteLine($"A new simulation is being created");
        }

        [Given("the number for the quantity of players is (.*)")]
        public void GivenTheQuantityOfPlayersIs(int number)
        {
            //TODO: implement arrange (precondition) logic

            throw new PendingStepException();

            _OutputHelper.WriteLine($"the number for the quantity of players is {number}");
        }

        [Given("(.*) is within (.*)")]
        public void GivenTheQuantityOfPlayersIsWithin(int number, string range)
        {
            //TODO: implement arrange (precondition) logic

            throw new PendingStepException();

            _OutputHelper.WriteLine($"{number} players is within the allowed range");
        }

        [When("the simulation creation is confirmed")]
        public void WhenTheSimulationCreationIsConfirmed()
        {
            //TODO: implement act (action) logic

            throw new PendingStepException();

            _OutputHelper.WriteLine($"the simulation creation is confirmed");
        }

        [Then("the quantity of players in the simulation configuration should be (.*)")]
        public void ThenTheQuantityOfPlayersInTheConfigurationShouldBe(int result)
        {
            //TODO: implement assert (verification) logic

            throw new PendingStepException();

            _OutputHelper.WriteLine($"the quantity of players in the simulation configuration is {result}");
        }        
    }
}
