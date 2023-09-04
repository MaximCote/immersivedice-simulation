using TechTalk.SpecFlow.Infrastructure;
using ImmersiveDice.Simulation.Ubiquity.NeonArena.Aggregates.PlaythroughSimulationAggregate;
using ImmersiveDice.Simulation.Ubiquity.NeonArena.Aggregates.PlaythroughSimulationAggregate.ValueObjects;
using ImmersiveDice.Simulation.AcceptanceTests.Drivers;

namespace ImmersiveDice.Simulation.AcceptanceTests.StepDefinitions;

[Binding]
public sealed class CreateSimulationStepDefinitions
{

    private readonly PlaythroughSimulationDriver _PlaythroughSimulationDriver;
    private readonly ISpecFlowOutputHelper _OutputHelper;

    public CreateSimulationStepDefinitions(PlaythroughSimulationDriver playthroughSimulationDriver, ISpecFlowOutputHelper outputHelper)
    {
        _PlaythroughSimulationDriver = playthroughSimulationDriver;
        _OutputHelper = outputHelper;
    }

    [Given(@"a new simulation is being created")]
    public void GivenANewSimulationIsBeingCreated()
    {
        //arrange (precondition) logic
        _OutputHelper.WriteLine($"A new simulation is being created");
    }

    [Given(@"the quantity of players in the simulation is (.*)")]
    public void GivenTheQuantityOfPlayersInTheSimulationIs(UInt16 quantityOfPlayers)
    {
        //arrange (precondition) logic
        _PlaythroughSimulationDriver.QuantityOfPlayersChosenByUser = quantityOfPlayers;

        _OutputHelper.WriteLine($"the number for the quantity of players is {_PlaythroughSimulationDriver.QuantityOfPlayersChosenByUser}");
    }

    [Given(@"the quantity of players is within the (.*) and (.*) quantity allowed by the game rules")]
    public void GivenTheQuantityOfPlayersIsWithinTheAndQuantityAllowedByTheGameRules(UInt16 quantityLowerBound, UInt16 quantityUpperBound)
    {
        //arrange (precondition) logic
        if (_PlaythroughSimulationDriver.QuantityOfPlayersChosenByUser >= quantityLowerBound && _PlaythroughSimulationDriver.QuantityOfPlayersChosenByUser <= quantityUpperBound)
        {
            _PlaythroughSimulationDriver.SimulationConfig = new SimulationConfiguration(_PlaythroughSimulationDriver.QuantityOfPlayersChosenByUser);

            _OutputHelper.WriteLine($"{_PlaythroughSimulationDriver.QuantityOfPlayersChosenByUser} players is within the allowed range");
        }
        else throw new ArgumentOutOfRangeException();
    }


    [When("the simulation creation is confirmed")]
    public void WhenTheSimulationCreationIsConfirmed()
    {
        //act (action) logic
        _PlaythroughSimulationDriver.Simulation = PlaythroughSimulation.Create(_PlaythroughSimulationDriver.SimulationConfig ?? new SimulationConfiguration());

        _OutputHelper.WriteLine($"the simulation creation is confirmed");
    }
}
