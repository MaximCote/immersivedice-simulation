using ImmersiveDice.Simulation.Ubiquity.NeonArena.Aggregates.PlaythroughSimulationAggregate.ValueObjects;
using ImmersiveDice.Simulation.Ubiquity.NeonArena.Common.Abstractions;

namespace ImmersiveDice.Simulation.Ubiquity.NeonArena.Aggregates.PlaythroughSimulationAggregate;

/// <summary>
///     Represent a table-top role-playing game playthrough simulation.
/// </summary>
/// <remarks>
///     It aims to automate the generation of statistically relevant data for analysis.
/// </remarks>
public sealed class PlaythroughSimulation : AggregateRoot<PlaythroughSimulationId>
{
    public PlaythroughSimulationId Id { get; init; }
    private SimulationConfiguration SimulationConfig { get; init; }

    /// <summary>
    ///     Initialize a new playthrough simulation with a default configuration.
    /// </summary>
    private PlaythroughSimulation() 
    {
        Id = new PlaythroughSimulationId();
        SimulationConfig = new SimulationConfiguration();
    }
    /// <summary>
    ///     Initialize a new playthrough simulation with a specified configuration.
    /// </summary>
    private PlaythroughSimulation(SimulationConfiguration configuration)
    {
        Id = new PlaythroughSimulationId();
        SimulationConfig = configuration;
    }

    /// <summary>
    ///     Create and initialize a new playthrough simulation with a specified configuration.
    /// </summary>
    /// <returns>
    ///     A new reference object representing a playthrough simulation with configuration values
    ///     like <see cref="SimulationConfiguration.QuantityOfPlayers"/>.
    /// </returns>
    public static PlaythroughSimulation Create(SimulationConfiguration configuration)
    {
        return new PlaythroughSimulation(configuration);
    }

    /// <summary>
    ///     Obtains the quantity of players in the current playthrough.
    /// </summary>
    /// <returns>
    ///     A 16-bit unsigned integer describing the value for the quantity of players
    ///     being simulated in the current playthrough simulation.
    /// </returns>
    public UInt16 GetQuantityOfPlayers()
    {
        return SimulationConfig.QuantityOfPlayers;
    }

    /// <summary>
    ///     Indicates whether <see langword="this object"/> value <see langword="is equal to"/>
    ///     the value of another specified <see langword="object"/> of the same type.
    /// </summary>
    /// <remarks>
    ///     The objects are compared by their <see cref="Id"/> property.
    /// </remarks>
    /// <param name="otherPlaythroughSim"></param>
    /// <returns>
    ///     <see langword="true"/> if both objects have an equal value; 
    ///     otherwise, <see langword="false"/>.
    /// </returns>
    public bool Equals(PlaythroughSimulation otherPlaythroughSim)
    {
        return Id.Equals(otherPlaythroughSim.Id);
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
    public override bool Equals(Entity<PlaythroughSimulationId>? otherObject)
    {
        return otherObject is PlaythroughSimulation otherPlaythroughSim && Equals(otherPlaythroughSim);
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
        return otherObject is PlaythroughSimulation otherPlaythroughSim && Equals(otherPlaythroughSim);
    }

    /// <summary>
    ///     Obtains the hash code for <see langword="this object"/>.
    /// </summary>
    /// <remarks>
    ///     This is an <see langword="override"/>.
    /// </remarks>
    /// <returns>
    ///     A 32-bit signed integer that represents the hash code for <see langword="this object"/> 
    ///     based on its <see cref="Id"/>.
    /// </returns>
    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }

    /// <summary>
    ///     Create and initialize a new playthrough simulation with default configuration.
    /// </summary>
    /// <returns>
    ///     A new reference object representing a playthrough simulation with default configuration values
    ///     like <see cref="SimulationConfiguration.DefaultQuantityOfPlayers"/>.
    /// </returns>
    internal static PlaythroughSimulation Create()
    {
        return new PlaythroughSimulation();
    }

    /// <summary>
    ///     Obtains the configuration details for the current playthrough.
    /// </summary>
    /// <remarks>
    ///     Mostly used for unit test.
    /// </remarks>
    /// <returns>
    ///     A value object that describes the <see cref="SimulationConfiguration.QuantityOfPlayers"/> 
    ///     being simulated as well as the <see cref="SimulationConfiguration.MinQuantityOfPlayers"/> constant 
    ///     and the <see cref="SimulationConfiguration.MaxQuantityOfPlayers"/> constant.
    /// </returns>
    internal SimulationConfiguration GetConfiguration()
    {
        return SimulationConfig;
    }
}
