using TechTalk.SpecFlow.Infrastructure;
using ImmersiveDice.Simulation.Ubiquity.NeonArena.Aggregates.PlaythroughSimulationAggregate;
using ImmersiveDice.Simulation.Ubiquity.NeonArena.Aggregates.PlaythroughSimulationAggregate.ValueObjects;
using ImmersiveDice.Simulation.AcceptanceTests.Drivers;

namespace ImmersiveDice.Simulation.AcceptanceTests.StepDefinitions;

[Binding]
public sealed class CreateSimulationStepDefinitions
{

    internal UInt16 QuantityOfPlayers { get; private set; }

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
    public void GivenTheQuantityOfPlayersInTheSimulationIs(UInt16 p0)
    {
        //arrange (precondition) logic
        QuantityOfPlayers = p0;

        _OutputHelper.WriteLine($"the number for the quantity of players is {QuantityOfPlayers}");
    }

    [Given(@"the quantity of players is within the (.*) and (.*) quantity allowed by the game rules")]
    public void GivenTheQuantityOfPlayersIsWithinTheAndQuantityAllowedByTheGameRules(UInt16 p0, UInt16 p1)
    {
        //arrange (precondition) logic
        if (QuantityOfPlayers >= p0 && QuantityOfPlayers <= p1)
        {
            _PlaythroughSimulationDriver.SimulationConfig = new SimulationConfiguration(QuantityOfPlayers);

            _OutputHelper.WriteLine($"{QuantityOfPlayers} players is within the allowed range");
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
