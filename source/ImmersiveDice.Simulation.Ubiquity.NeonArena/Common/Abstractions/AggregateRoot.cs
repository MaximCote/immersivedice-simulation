using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmersiveDice.Simulation.Ubiquity.NeonArena.Common.Abstractions;

/// <summary>
///     An abstraction to narrow the definition of a type.
/// </summary>
public abstract class AggregateRoot<TEntityId> : Entity<TEntityId> { }
