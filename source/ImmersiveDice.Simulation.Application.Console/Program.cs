using ImmersiveDice.Simulation.Ubiquity.NeonArena.Aggregates.PlaythroughSimulationAggregate;
using ImmersiveDice.Simulation.Ubiquity.NeonArena.Aggregates.PlaythroughSimulationAggregate.ValueObjects;

/*
The following is a short console application program 
to interactively test the features of the modular monolith.
*/

for (int i=5; i>=1; i--)
{ 
    Console.WriteLine($"Hello, welcome to Immersive Dice simulation generator!\n");
    Console.WriteLine($"Choose the number of players to include in the simulation.");
    Console.WriteLine($"Enter a number between {SimulationConfiguration.MinQuantityOfPlayers} " +
        $"and {SimulationConfiguration.MaxQuantityOfPlayers}\n");

    //Wait for the user to press a key
    ConsoleKeyInfo userInput = Console.ReadKey();

    //Validate the input is a number and the number is within the values allowed by the game rules
    if (UInt16.TryParse(userInput.KeyChar.ToString(), out UInt16 qtyOfPlayers)
        && qtyOfPlayers >= SimulationConfiguration.MinQuantityOfPlayers 
        && qtyOfPlayers <= SimulationConfiguration.MaxQuantityOfPlayers)
    {
        //Initialize a new simulation configuration with the quantity of players input provided
        SimulationConfiguration simulationConfig = new SimulationConfiguration(qtyOfPlayers);
        //Create a new simulation with the new configuration
        PlaythroughSimulation playthrough = PlaythroughSimulation.Create(simulationConfig);
        //Output the configuration of the simulation through one of its method.
        Console.WriteLine($"\n\nThe number of players configured is {playthrough.GetQuantityOfPlayers()}.");
        Console.WriteLine($"Thank you, until next time!");
        break;
    }
    else
    {
        Console.WriteLine($"\n\nThe input is invalid");
        Console.WriteLine($"You have {i} attempt(s) left.\n\n\n");
    }
}