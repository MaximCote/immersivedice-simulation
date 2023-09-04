using ImmersiveDice.Simulation.Ubiquity.NeonArena.Aggregates.PlaythroughSimulationAggregate.ValueObjects;
using ImmersiveDice.Simulation.Ubiquity.NeonArena.Aggregates.PlaythroughSimulationAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmersiveDice.Simulation.AcceptanceTests.Drivers;

public sealed class PlaythroughSimulationDriver
{
    internal UInt16 QuantityOfPlayersChosenByUser { get; set; }
    internal SimulationConfiguration? SimulationConfig { get; set; }
    internal PlaythroughSimulation? Simulation { get; set; }
}
