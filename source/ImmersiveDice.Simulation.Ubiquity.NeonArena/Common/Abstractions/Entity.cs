using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmersiveDice.Simulation.Ubiquity.NeonArena.Common.Abstractions;

/// <summary>
///     An abstraction to narrow the definition of a type 
///     and to provide type-specific functionality for determining equality of instances
/// </summary>
public abstract class Entity<TEntityId> : IEquatable<Entity<TEntityId>>
{
    public abstract bool Equals(Entity<TEntityId>? other);
}