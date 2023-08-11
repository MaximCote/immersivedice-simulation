using FluentAssertions;
using ImmersiveDice.Simulation.Ubiquity.NeonArena.Aggregates.PlaythroughSimulationAggregate.ValueObjects;

namespace ImmersiveDice.Simulation.Ubiquity.NeonArena.UnitTests.Aggregates.PlaythroughSimulationAggregate;

public class PlaythroughSimulationIdTests
{
    [Fact]
    public void Value_GivenNewObject_ShouldBeTypeGuid()
    {
        //Given
        PlaythroughSimulationId id = new PlaythroughSimulationId();

        //Then
        Assert.IsType<Guid>(id.Value);
    }

    [Fact]
    public void Value_GivenNewObject_ShouldNotBeEmptyGuid()
    {
        //Given
        PlaythroughSimulationId id = new PlaythroughSimulationId();

        //Then
        id.Value.Should().NotBe(Guid.Empty);
    }

    [Fact]
    public void Value_GivenNewObject_ShouldBeUniqueGuid()
    {
        //Given
        PlaythroughSimulationId id = new PlaythroughSimulationId();

        //Then
        id.Value.Should().NotBe(Guid.NewGuid());
    }

    [Fact]
    public void Equals_GivenSameObject_ShouldReturnTrue()
    {
        //Given
        PlaythroughSimulationId leftObject = new PlaythroughSimulationId();
        PlaythroughSimulationId rightObject = leftObject;

        //When
        bool equalityFlag = leftObject.Equals(rightObject);

        //Then
        Assert.True(equalityFlag);
    }

    [Fact]
    public void Equals_GivenDifferentObject_ShouldReturnFalse()
    {
        //Given
        PlaythroughSimulationId leftObject = new PlaythroughSimulationId();
        string rightObject = String.Empty;

        //When
        bool equalityFlag = leftObject.Equals(rightObject);

        //Then
        Assert.False(equalityFlag);
    }

    [Fact]
    public void GetHashCode_GivenSameObjectTwice_ShouldReturnEqualValues()
    {
        //Given
        PlaythroughSimulationId leftObject = new PlaythroughSimulationId();
        PlaythroughSimulationId rightObject = leftObject;

        //When
        int leftHashCode = leftObject.GetHashCode();
        int rightHashCode = rightObject.GetHashCode();

        //Then
        Assert.Equal(leftHashCode, rightHashCode);
    }
}
