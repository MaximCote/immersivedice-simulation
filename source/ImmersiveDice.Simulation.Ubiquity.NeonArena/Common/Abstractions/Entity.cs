using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmersiveDice.Simulation.Ubiquity.NeonArena.Common.Abstractions;

internal abstract class Entity<TEntityId> : IEquatable<Entity<TEntityId>>
{
    public abstract bool Equals(Entity<TEntityId>? other);
}
