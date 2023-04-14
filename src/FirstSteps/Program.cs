using System;
using FirstSteps.RPG;
using Spectre.Console;

namespace FirstSteps
{
    class Program
    {
        static void Main(string[] args)
        {
            AnsiConsole.MarkupLine($"{Emoji.Known.BowAndArrow} [darkgreen]Welcome to the RPG game [/] {Emoji.Known.CrossedSwords}");

            Game.CreateHero();

            AnsiConsole.MarkupLine($"{Emoji.Known.Dagger} [red]Let's play the game[/] {Emoji.Known.Dagger}");

            Console.WriteLine("\nType 'end' if you want to quit.");
            Console.WriteLine("\nIf You want go back to the previous menu press button\n");
            Console.WriteLine("________________________________");
            string userInput;
            do
            {
                string command = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                        .Title("\nSelect what you want to do: ")
                        .AddChoices("stats", "treasure adventure", "inventory", "forest", "dungeons", "mine","village", "hell"));
                Game.HandleCommand(command);
                Console.WriteLine();
                userInput = Console.ReadLine();
            }
            while (userInput != "end");
        }
    }
}
