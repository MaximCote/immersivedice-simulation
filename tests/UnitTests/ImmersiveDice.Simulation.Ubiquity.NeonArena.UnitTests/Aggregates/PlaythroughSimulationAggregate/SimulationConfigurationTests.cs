using FluentAssertions;
using ImmersiveDice.Simulation.Ubiquity.NeonArena.Aggregates.PlaythroughSimulationAggregate.ValueObjects;

namespace ImmersiveDice.Simulation.Ubiquity.NeonArena.UnitTests.Aggregates.PlaythroughSimulationAggregate;

public class SimulationConfigurationTests
{
    [Fact]
    public void QuantityOfPlayers_GivenNoArgs_ShouldBeTypeUInt16()
    {
        //Given
        SimulationConfiguration configuration = new SimulationConfiguration();

        //Then
        Assert.IsType<UInt16>(configuration.QuantityOfPlayers);
    }

    [Fact]
    public void QuantityOfPlayers_GivenNoArgs_ShouldBeDefaultValue()
    {
        //Given
        SimulationConfiguration configuration = new SimulationConfiguration();
        UInt16 expectedValue = SimulationConfiguration.DefaultQuantityOfPlayers;

        //Then
        configuration.QuantityOfPlayers.Should().Be(expectedValue);
    }

    [Fact]
    public void QuantityOfPlayers_GivenArgumentIsMinQuantity_ShouldBeArgument()
    {
        //Given
        UInt16 argumentValue = SimulationConfiguration.MinQuantityOfPlayers;
        SimulationConfiguration configuration = new SimulationConfiguration(argumentValue);
        UInt16 expectedValue = argumentValue;

        //Then
        configuration.QuantityOfPlayers.Should().Be(expectedValue);
    }

    [Fact]
    public void QuantityOfPlayers_GivenArgumentIsMaxQuantity_ShouldBeArgument()
    {
        //Given
        UInt16 argumentValue = SimulationConfiguration.MaxQuantityOfPlayers;
        SimulationConfiguration configuration = new SimulationConfiguration(argumentValue);
        UInt16 expectedValue = argumentValue;

        //Then
        configuration.QuantityOfPlayers.Should().Be(expectedValue);
    }

    [Fact]
    public void QuantityOfPlayers_GivenArgumentIsMaxQuantity_ShouldNotBeDefaultValue()
    {
        //Given
        UInt16 argumentValue = SimulationConfiguration.MaxQuantityOfPlayers;
        SimulationConfiguration configuration = new SimulationConfiguration(argumentValue);
        UInt16 defaultValue = SimulationConfiguration.DefaultQuantityOfPlayers;

        //Then
        configuration.QuantityOfPlayers.Should().NotBe(defaultValue);
    }

    [Fact]
    public void QuantityOfPlayers_GivenArgumentSmallerThanMinQuantity_ShouldBeDefaultValue()
    {
        //Given
        UInt16 argumentValue = UInt16.MinValue;
        SimulationConfiguration configuration = new SimulationConfiguration(argumentValue);
        UInt16 defaultValue = SimulationConfiguration.DefaultQuantityOfPlayers;

        //Then
        configuration.QuantityOfPlayers.Should().Be(defaultValue);
    }

    [Fact]
    public void QuantityOfPlayers_GivenArgumentGreaterThanMaxQuantity_ShouldBeDefaultValue()
    {
        //Given
        UInt16 argumentValue = UInt16.MaxValue;
        SimulationConfiguration configuration = new SimulationConfiguration(argumentValue);
        UInt16 defaultValue = SimulationConfiguration.DefaultQuantityOfPlayers;

        //Then
        configuration.QuantityOfPlayers.Should().Be(defaultValue);
    }
}
