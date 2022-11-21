using System;
using Y09.Energy.Gateway.Stw.PurtelApi.Services;

namespace Y09.Energy.Gateway.Stw.PurtelApi.Actions;

static class Factory
{

    /// <summary>
    /// Start Console 
    /// </summary>
    public static void ConsoleStart()
    {
        Console.Clear();

        // Ask the user to choose an option.
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("*** Gateway STW to Call Purtel-Api ***");
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("-> use app.config to define API and Endpoint ");
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("\tEnter [A] - Call PurtelApi with parameter");
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("\n Press any key to Quit");
        Console.WriteLine("----------------------------------------------");

        // Use a switch statement to do the math.
        switch (Console.ReadLine())
        {
            case "A":
            case "a":
                ApiService.StartApi();
                break;
            default:
                Console.ReadKey();
                break;
        }

    }


    /// <summary>
    /// Test consle
    /// </summary>
    /// <param name="Gateway"></param>
    public static void ConsoleTest(string Gateway)
    {
        Console.Clear();

        Console.WriteLine("----------------------------------------------");
        Console.WriteLine($"Api started {Gateway}");
        Console.WriteLine("----------------------------------------------");
                
        // Wait for the user to respond before closing.
        Console.Write("Press any key to close app...");
        Console.ReadKey();

    }

}
