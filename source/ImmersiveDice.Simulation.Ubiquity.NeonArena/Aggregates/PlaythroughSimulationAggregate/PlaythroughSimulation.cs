using ImmersiveDice.Simulation.Ubiquity.NeonArena.Aggregates.PlaythroughSimulationAggregate.ValueObjects;
using ImmersiveDice.Simulation.Ubiquity.NeonArena.Common.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ImmersiveDice.Simulation.Ubiquity.NeonArena.Aggregates.PlaythroughSimulationAggregate
{
    internal sealed class PlaythroughSimulation : AggregateRoot<PlaythroughSimulationId>
    {
        public PlaythroughSimulationId Id { get; init; }
        private SimulationConfiguration SimulationConfig { get; init; }

        private PlaythroughSimulation() 
        {
            Id = new PlaythroughSimulationId();
            SimulationConfig = new SimulationConfiguration();
        }

        private PlaythroughSimulation(SimulationConfiguration configuration)
        {
            Id = new PlaythroughSimulationId();
            SimulationConfig = configuration;
        }

        public static PlaythroughSimulation Create()
        {
            return new PlaythroughSimulation();
        }

        public static PlaythroughSimulation Create(SimulationConfiguration configuration)
        {
            return new PlaythroughSimulation(configuration);
        }

        internal SimulationConfiguration GetConfiguration()
        {
            return SimulationConfig;
        }

        public UInt16 GetQuantityOfPlayers()
        {
            return SimulationConfig.QuantityOfPlayers;
        }

        public bool Equals(PlaythroughSimulation otherObj)
        {
            return Id.Equals(otherObj.Id);
        }               

        public override bool Equals(object? otherObj)
        {
            return otherObj is PlaythroughSimulation && Equals(otherObj);
        }

        public override bool Equals(Entity<PlaythroughSimulationId>? otherObj)
        {
            return Equals(otherObj);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
        
    }
}
