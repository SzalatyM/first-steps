using System;
using FirstSteps.RPG;
using Spectre.Console;

namespace FirstSteps
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = Console.ReadLine();
            AnsiConsole.MarkupLine($"{Emoji.Known.BowAndArrow} [darkgreen]Welcome to the RPG game [/] {Emoji.Known.CrossedSwords}");

            Game.CreateHero();

            AnsiConsole.MarkupLine($"{Emoji.Known.Dagger} [red]Let's play the game [/] {Emoji.Known.Dagger}");

            Console.WriteLine("Type 'end' if you want to quit.");
            Console.WriteLine("\nIf You want go back to the previous menu press button\n");
            Console.WriteLine("________________________________");
            do
            {
                string command = AnsiConsole.Prompt(
            new SelectionPrompt<string>().Title("\nSelect what you want to do: ").AddChoices("stats", "treasure", "inventory", "forest", "dungeons", "mine"));
                Game.HandleCommand(command);
                Console.ReadLine();  
                Console.WriteLine();
            }
            while (Game.HandleCommand(user) != "end"); // I've had this before like u wrote, but I just had a problem with a while loop so i decided to change conception :D
        }
    }
}
