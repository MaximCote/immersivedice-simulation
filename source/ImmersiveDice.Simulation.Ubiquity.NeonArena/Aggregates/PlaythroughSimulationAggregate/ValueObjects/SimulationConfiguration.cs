using ImmersiveDice.Simulation.Ubiquity.NeonArena.Common.Abstractions;

namespace ImmersiveDice.Simulation.Ubiquity.NeonArena.Aggregates.PlaythroughSimulationAggregate.ValueObjects;

/// <summary>
///     Describes the configuration details for the current playthrough
///     as well as defining useful constants part of the game rules specification.
/// </summary>
public sealed record class SimulationConfiguration : IValueObject
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
    /// <remarks>
    ///     Required by Entity Framework Core ORM.
    /// </remarks>
    private SimulationConfiguration() { }
}
