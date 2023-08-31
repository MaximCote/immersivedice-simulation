using BoDi;
using ImmersiveDice.Simulation.Ubiquity.NeonArena.Aggregates.PlaythroughSimulationAggregate;
using ImmersiveDice.Simulation.AcceptanceTests.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmersiveDice.Simulation.AcceptanceTests.Hooks;

[Binding]
[Scope(Feature = "ChooseCharacterArchetypes")]
public class ChooseCharacterArchetypesHooks
{
    [BeforeScenario]
    public void RegisterDependencies(IObjectContainer objectContainer)
    {
        
    }
}
