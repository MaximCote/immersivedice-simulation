using ImmersiveDice.Simulation.Ubiquity.NeonArena.Common.Abstractions;

namespace ImmersiveDice.Simulation.Ubiquity.NeonArena.Aggregates.PlaythroughSimulationAggregate.ValueObjects;

/// <summary>
///     Describes the configuration details for the current playthrough
///     as well as defining useful constants part of the game rules specification.
/// </summary>
public readonly struct SimulationConfiguration : IValueObject, IEquatable<SimulationConfiguration>
{
    /// <value>
    ///     Describes the minimum quantity of players allowed in a playthrough
    ///     as defined by the rules of the game.
    /// </value>
    public const UInt16 MinQuantityOfPlayers = 2;
    /// <value>
    ///     Describes the maximum quantity of players allowed in a playthrough
    ///     as defined by the rules of the game.
    /// </value>
    public const UInt16 MaxQuantityOfPlayers = 6;
    /// <value>
    ///     Describes a default value when no quantity of players is given.
    /// </value>
    public const UInt16 DefaultQuantityOfPlayers = 2;

    /// <summary>
    ///     Represents a quantity of players to be simulated in a <see cref="PlaythroughSimulation"/>.
    /// </summary>
    /// <value>
    ///     A 16-bit unsigned integer that should be inclusively 
    ///     between <see cref="MinQuantityOfPlayers"/>
    ///     and <see cref="MaxQuantityOfPlayers"/>.
    /// </value>
    public UInt16 QuantityOfPlayers { get; init; }

    /// <summary>
    ///     Initialize a new simulation configuration.
    /// </summary>
    /// <param name="qtyOfPlayers">
    ///     Optional. <see cref="DefaultQuantityOfPlayers"/> will be used if no value is given
    ///     or if the value is lower than <see cref="MinQuantityOfPlayers"/>
    ///     or if the value is greater than <see cref="MaxQuantityOfPlayers"/>.
    /// </param>
    public SimulationConfiguration(UInt16 qtyOfPlayers = DefaultQuantityOfPlayers)
    {
        if (qtyOfPlayers >= MinQuantityOfPlayers && qtyOfPlayers <= MaxQuantityOfPlayers)
            QuantityOfPlayers = qtyOfPlayers;
        else
            QuantityOfPlayers = DefaultQuantityOfPlayers;
    }
    /// <summary>
    ///     Initialize a new simulation configuration with <see cref="DefaultQuantityOfPlayers"/>.
    /// </summary>
    public SimulationConfiguration() 
    {
        QuantityOfPlayers = DefaultQuantityOfPlayers;
    }

    /// <summary>
    ///     Indicates whether <see langword="this object"/> value <see langword="is equal to"/>
    ///     the value of another specified <see langword="object"/> of the same type.
    /// </summary>
    /// <remarks>
    ///     The objects are compared by the value of their <see cref="QuantityOfPlayers"/>.
    /// </remarks>
    /// <param name="otherConfig"></param>
    /// <returns>
    ///     <see langword="true"/> if both objects have an equal value; 
    ///     otherwise, <see langword="false"/>.
    /// </returns>
    public bool Equals(SimulationConfiguration otherConfig)
    {
        return QuantityOfPlayers.Equals(otherConfig.QuantityOfPlayers);
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
        return otherObject is SimulationConfiguration otherConfig && this.Equals(otherConfig);
    }

    /// <summary>
    ///     Returns the hash code for <see langword="this object"/>.
    /// </summary>
    /// <remarks>
    ///     This is an <see langword="override"/>.
    /// </remarks>
    /// <returns>
    ///     A 32-bit signed integer that represents the hash code for <see langword="this object"/> 
    ///     based on its <see cref="QuantityOfPlayers"/>.
    /// </returns>
    public override int GetHashCode()
    {
        return QuantityOfPlayers.GetHashCode();
    }

    public static bool operator ==(SimulationConfiguration left, SimulationConfiguration right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(SimulationConfiguration left, SimulationConfiguration right)
    {
        return !(left == right);
    }
}
