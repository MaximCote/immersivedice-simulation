

namespace ImmersiveDice.Simulation.Ubiquity.NeonArena.Aggregates.PlaythroughSimulationAggregate.ValueObjects;

internal readonly struct PlaythroughSimulationId : IEquatable<PlaythroughSimulationId>
{
    public readonly Guid Value { get; } = Guid.Empty;

    public PlaythroughSimulationId()
    {
        Value = Guid.NewGuid();
    }

    public bool Equals(PlaythroughSimulationId otherObj)
    {
        return Value.Equals(otherObj.Value);
    }

    public override bool Equals(object? otherObj)
    {
        return otherObj is PlaythroughSimulationId && Equals(otherObj);
    }

    public override int GetHashCode()
    {
        return Value.GetHashCode();
    }

    public static bool operator ==(PlaythroughSimulationId left, PlaythroughSimulationId right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(PlaythroughSimulationId left, PlaythroughSimulationId right)
    {
        return !(left == right);
    }
}