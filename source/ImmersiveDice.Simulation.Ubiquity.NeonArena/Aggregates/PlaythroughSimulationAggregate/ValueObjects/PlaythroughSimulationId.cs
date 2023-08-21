
using ImmersiveDice.Simulation.Ubiquity.NeonArena.Common.Abstractions;

namespace ImmersiveDice.Simulation.Ubiquity.NeonArena.Aggregates.PlaythroughSimulationAggregate.ValueObjects;

/// <summary>
///     Represent a strongly typed identifier that encapsulate a Guid.
/// </summary>
/// <remarks>
///     This structure is meant to uniquely identify an instance of type <see cref="PlaythroughSimulation"/>.
/// </remarks>
public readonly struct PlaythroughSimulationId : IValueObject, IEquatable<PlaythroughSimulationId>
{
    /// <summary>
    ///     Represent a unique identifier for an instance of <see cref="PlaythroughSimulation"/>.
    /// </summary>
    /// <value>
    ///     Should never be 00000000-0000-0000-0000-000000000000 
    ///     and if it is then something went wrong.
    /// </value>
    public readonly Guid Value { get; } = Guid.Empty;

    /// <summary>
    ///     Initialize a new <see cref="Value"/> with a new <see cref="Guid"/>.
    /// </summary>
    public PlaythroughSimulationId()
    {
        Value = Guid.NewGuid();
    }

    /// <summary>
    ///     Indicates whether <see langword="this object"/> value <see langword="is equal to"/>
    ///     the value of another specified <see langword="object"/> of the same type.
    /// </summary>
    /// <remarks>
    ///     The objects are compared by their <see cref="Value"/>.
    /// </remarks>
    /// <param name="otherId"></param>
    /// <returns>
    ///     <see langword="true"/> if both objects have an equal value; 
    ///     otherwise, <see langword="false"/>.
    /// </returns>
    public bool Equals(PlaythroughSimulationId otherId)
    {
        return Value.Equals(otherId.Value);
    }

    /// <summary>
    ///     Determines whether <see langword="this is equal to"/> 
    ///     another specified <see langword="object"/>.
    /// </summary>
    /// <remarks>
    ///     This is an <see langword="override"/>.
    /// </remarks>
    /// <param name="otherObject"></param>
    /// <returns>
    ///     <see langword="true"/> when <see langword="this is equal to"/> the specified <paramref name="otherObject"/>; 
    ///     otherwise, <see langword="false"/>.
    /// </returns>
    public override bool Equals(object? otherObject)
    {
        return otherObject is PlaythroughSimulationId otherId && this.Equals(otherId);
    }

    /// <summary>
    ///     Returns the hash code for <see langword="this object"/>.
    /// </summary>
    /// <remarks>
    ///     This is an <see langword="override"/>.
    /// </remarks>
    /// <returns>
    ///     A 32-bit signed integer that represents the hash code for <see langword="this object"/> 
    ///     based on its <see cref="Value"/>.
    /// </returns>
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