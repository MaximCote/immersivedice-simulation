using BoDi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmersiveDice.Simulation.AcceptanceTests.Hooks;

[Binding]
[Scope(Feature = "ChooseQuantityOfPlayers")]
public class ChooseQuantityOfPlayersHooks
{
    [BeforeScenario]
    public void RegisterDependencies(IObjectContainer objectContainer)
    {

    }
}
