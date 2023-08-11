using TechTalk.SpecFlow.Infrastructure;
using ImmersiveDice.Simulation.Ubiquity.NeonArena.Aggregates.PlaythroughSimulationAggregate;
using ImmersiveDice.Simulation.Ubiquity.NeonArena.Aggregates.PlaythroughSimulationAggregate.ValueObjects;

namespace ImmersiveDice.Simulation.AcceptanceTests.StepDefinitions;

[Binding]
public sealed class ChooseQuantityOfPlayersStepDefinitions
{    
    internal UInt16 QuantityOfPlayersChosenByUser { get; private set; }
    internal SimulationConfiguration? SimulationConfig { get; private set; }
    internal PlaythroughSimulation? Simulation { get; private set; }

    private readonly ISpecFlowOutputHelper _OutputHelper;

    public ChooseQuantityOfPlayersStepDefinitions(ISpecFlowOutputHelper outputHelper)
    {
        _OutputHelper = outputHelper;
    }

    [Given(@"a new simulation is being created")]
    public void GivenANewSimulationIsBeingCreated()
    {
        //arrange (precondition) logic
        _OutputHelper.WriteLine($"A new simulation is being created");
    }

    [Given("the quantity of players chosen by the user is (.*)")]
    public void GivenTheQuantityOfPlayersIs(UInt16 number)
    {
        //arrange (precondition) logic
        QuantityOfPlayersChosenByUser = number;

        _OutputHelper.WriteLine($"the number for the quantity of players is {QuantityOfPlayersChosenByUser}");
    }

    [Given("the quantity is within the (.*) and (.*) quantity allowed by the game rules")]
    public void GivenTheQuantityOfPlayersIsWithin(
        UInt16 minQuantity = SimulationConfiguration.MinQuantityOfPlayers, 
        UInt16 maxQuantity = SimulationConfiguration.MaxQuantityOfPlayers)
    {
        //arrange (precondition) logic
        if (QuantityOfPlayersChosenByUser >= minQuantity && QuantityOfPlayersChosenByUser <= maxQuantity)
        {
            SimulationConfig = new SimulationConfiguration(QuantityOfPlayersChosenByUser);

            _OutputHelper.WriteLine($"{QuantityOfPlayersChosenByUser} players is within the allowed range");
        }
        else throw new ArgumentOutOfRangeException();
    }

    [When("the simulation creation is confirmed")]
    public void WhenTheSimulationCreationIsConfirmed()
    {
        //act (action) logic
        Simulation = PlaythroughSimulation.Create(SimulationConfig ?? new SimulationConfiguration());

        _OutputHelper.WriteLine($"the simulation creation is confirmed");
    }

    [Then("the quantity of players in the simulation configuration should be (.*)")]
    public void ThenTheQuantityOfPlayersInTheConfigurationShouldBe(UInt16 result)
    {
        //assert (verification) logic
        UInt16 quantityOfPlayersInConfig =  Simulation?.GetQuantityOfPlayers() ?? 0;

        quantityOfPlayersInConfig.Should().Be(QuantityOfPlayersChosenByUser);
        quantityOfPlayersInConfig.Should().Be(result);

        _OutputHelper.WriteLine($"the quantity of players in the simulation configuration is {result}");
    }        
}
