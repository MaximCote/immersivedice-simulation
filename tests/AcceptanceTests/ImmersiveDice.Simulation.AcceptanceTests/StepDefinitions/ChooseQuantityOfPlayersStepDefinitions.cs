using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmersiveDice.Simulation.AcceptanceTests.StepDefinitions
{
    [Binding]
    public sealed class ChooseQuantityOfPlayersStepDefinitions
    {
        [Given(@"a new simulation is being created")]
        public void GivenANewSimulationIsBeingCreated()
        {
            //TODO: implement arrange (precondition) logic

            throw new PendingStepException();
        }

        [Given("the number for the quantity of players is (.*)")]
        public void GivenTheQuantityOfPlayersIs(int number)
        {
            //TODO: implement arrange (precondition) logic

            throw new PendingStepException();
        }

        [Given("(.*) is within (.*)")]
        public void GivenTheQuantityOfPlayersIsWithin(int number, Range range)
        {
            //TODO: implement arrange (precondition) logic

            throw new PendingStepException();
        }

        [When("the simulation creation is confirmed")]
        public void WhenTheSimulationCreationIsConfirmed()
        {
            //TODO: implement act (action) logic

            throw new PendingStepException();
        }

        [Then("the quantity of players in the simulation configuration should be (.*)")]
        public void ThenTheQuantityOfPlayersInTheConfigurationShouldBe(int result)
        {
            //TODO: implement assert (verification) logic

            throw new PendingStepException();
        }        
    }
}
