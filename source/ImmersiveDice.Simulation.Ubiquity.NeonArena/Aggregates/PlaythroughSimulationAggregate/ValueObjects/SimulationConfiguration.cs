using ImmersiveDice.Simulation.Ubiquity.NeonArena.Common.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmersiveDice.Simulation.Ubiquity.NeonArena.Aggregates.PlaythroughSimulationAggregate.ValueObjects;

internal record class SimulationConfiguration : ValueObject
{
    public const UInt16 MinQuantityOfPlayers = 2;
    public const UInt16 MaxQuantityOfPlayers = 6;
    public const UInt16 DefaultQuantityOfPlayers = 2;

    internal UInt16 QuantityOfPlayers { get; init; }

    private SimulationConfiguration() {}

    internal SimulationConfiguration(UInt16 quantityOfPlayers=DefaultQuantityOfPlayers) 
    {
        if (quantityOfPlayers >= MinQuantityOfPlayers && quantityOfPlayers <= MaxQuantityOfPlayers)
            QuantityOfPlayers = quantityOfPlayers;
        else
            QuantityOfPlayers = DefaultQuantityOfPlayers;
    }
}
