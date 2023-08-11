using FluentAssertions;
using ImmersiveDice.Simulation.Ubiquity.NeonArena.Aggregates.PlaythroughSimulationAggregate;
using ImmersiveDice.Simulation.Ubiquity.NeonArena.Aggregates.PlaythroughSimulationAggregate.ValueObjects;

namespace ImmersiveDice.Simulation.Ubiquity.NeonArena.UnitTests.Aggregates.PlaythroughSimulationAggregate;
public class PlaythroughSimulationTests
{
    [Fact]
    public void Create_GivenNoArgs_ShouldReturnTypePlaythroughSimulation()
    {
        //Given
        PlaythroughSimulation simulation = PlaythroughSimulation.Create();

        //Then
        Assert.IsType<PlaythroughSimulation>(simulation);
    }

    [Fact]
    public void Create_GivenNoArgs_ShouldReturnObjWithPropOfTypePlaythroughSimulationId()
    {
        //Given
        PlaythroughSimulation simulation = PlaythroughSimulation.Create();

        //Then
        Assert.IsType<PlaythroughSimulationId>(simulation.Id);
    }

    [Fact]
    public void Create_GivenNoArgs_ShouldReturnObjWithPropUniqueGuid()
    {
        //Given
        PlaythroughSimulation simulation = PlaythroughSimulation.Create();

        //Then
        simulation.Id.Value.Should().NotBe(Guid.Empty);
        simulation.Id.Value.Should().NotBe(Guid.NewGuid());
    }

    [Fact]
    public void GetConfiguration_GivenObjectCreatedWithoutArgs_ShouldReturnTypeSimulationConfiguration()
    {
        //Given
        PlaythroughSimulation simulation = PlaythroughSimulation.Create();
        SimulationConfiguration configuration = simulation.GetConfiguration();

        //Then
        Assert.IsType<SimulationConfiguration>(configuration);
    }

    [Fact]
    public void GetConfiguration_GivenObjectCreatedWithoutArgs_ShouldReturnObjWithPropOfTypeUInt16()
    {
        //Given
        PlaythroughSimulation simulation = PlaythroughSimulation.Create();
        SimulationConfiguration configuration = simulation.GetConfiguration();

        //Then
        Assert.IsType<UInt16>(configuration.QuantityOfPlayers);
    }

    [Fact]
    public void GetConfiguration_GivenObjectCreatedWithoutArgs_ShouldReturnObjWithPropDefaultValue()
    {
        //Given
        PlaythroughSimulation simulation = PlaythroughSimulation.Create();
        SimulationConfiguration configuration = simulation.GetConfiguration();
        
        UInt16 expectedValue = SimulationConfiguration.DefaultQuantityOfPlayers;

        //Then
        configuration.QuantityOfPlayers.Should().Be(expectedValue);
    }

    [Fact]
    public void GetConfiguration_GivenArgumentNewConfigWithoutParams_ShouldReturnObjWithPropDefaultValue()
    {
        //Given
        SimulationConfiguration argumentValue = new SimulationConfiguration();
        PlaythroughSimulation simulation = PlaythroughSimulation.Create(argumentValue);
        SimulationConfiguration configuration = simulation.GetConfiguration();

        UInt16 expectedValue = SimulationConfiguration.DefaultQuantityOfPlayers;

        //Then
        configuration.QuantityOfPlayers.Should().Be(expectedValue);
    }

    [Fact]
    public void GetConfiguration_GivenArgumentNewConfigWithParam_ShouldReturnObjWithPropParam()
    {
        //Given
        UInt16 paramValue = 4;
        SimulationConfiguration argumentValue = new SimulationConfiguration(paramValue);
        PlaythroughSimulation simulation = PlaythroughSimulation.Create(argumentValue);
        SimulationConfiguration configuration = simulation.GetConfiguration();

        UInt16 expectedValue = paramValue;

        //Then
        configuration.QuantityOfPlayers.Should().Be(expectedValue);
    }

    [Fact]
    public void GetQuantityOfPlayers_GivenObjectCreatedWithoutArgs_ShouldReturnTypeUInt16()
    {
        //Given
        PlaythroughSimulation simulation = PlaythroughSimulation.Create();
        UInt16 quantityOfPlayers = simulation.GetQuantityOfPlayers();

        //Then
        Assert.IsType<UInt16>(quantityOfPlayers);
    }


    [Fact]
    public void GetQuantityOfPlayers_GivenObjectCreatedWithoutArgs_ShouldReturnDefaultValue()
    {
        //Given
        PlaythroughSimulation simulation = PlaythroughSimulation.Create();
        UInt16 quantityOfPlayers = simulation.GetQuantityOfPlayers();

        UInt16 expectedValue = SimulationConfiguration.DefaultQuantityOfPlayers;

        //Then
        quantityOfPlayers.Should().Be(expectedValue);
    }

    [Fact]
    public void GetQuantityOfPlayers_GivenArgumentNewConfigWithoutParams_ShouldReturnObjWithPropDefaultValue()
    {
        //Given
        SimulationConfiguration argumentValue = new SimulationConfiguration();
        PlaythroughSimulation simulation = PlaythroughSimulation.Create(argumentValue);
        UInt16 quantityOfPlayers = simulation.GetQuantityOfPlayers();

        UInt16 expectedValue = SimulationConfiguration.DefaultQuantityOfPlayers;

        //Then
        quantityOfPlayers.Should().Be(expectedValue);
    }

    [Fact]
    public void GetQuantityOfPlayers_GivenArgumentNewConfigWithParam_ShouldReturnParam()
    {
        //Given
        UInt16 paramValue = SimulationConfiguration.MaxQuantityOfPlayers;
        SimulationConfiguration argumentValue = new SimulationConfiguration(paramValue);
        PlaythroughSimulation simulation = PlaythroughSimulation.Create(argumentValue);
        UInt16 quantityOfPlayers = simulation.GetQuantityOfPlayers();

        UInt16 expectedValue = paramValue;

        //Then
        quantityOfPlayers.Should().Be(expectedValue);
    }

    [Fact]
    public void GetQuantityOfPlayers_GivenArgumentNewConfigWithParamSmallerMinQuantity_ShouldBeDefaultValue()
    {
        //Given
        UInt16 argumentValue = UInt16.MinValue;
        SimulationConfiguration configuration = new SimulationConfiguration(argumentValue);
        UInt16 defaultValue = SimulationConfiguration.DefaultQuantityOfPlayers;

        //Then
        configuration.QuantityOfPlayers.Should().Be(defaultValue);
    }

    [Fact]
    public void GetQuantityOfPlayers_GivenArgumentNewConfigWithParamGreaterMaxQuantity_ShouldBeDefaultValue()
    {
        //Given
        UInt16 argumentValue = UInt16.MaxValue;
        SimulationConfiguration configuration = new SimulationConfiguration(argumentValue);
        UInt16 defaultValue = SimulationConfiguration.DefaultQuantityOfPlayers;

        //Then
        configuration.QuantityOfPlayers.Should().Be(defaultValue);
    }
}
