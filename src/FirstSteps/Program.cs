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

            AnsiConsole.MarkupLine($"{Emoji.Known.Dagger} [red]Let's play the game [/] {Emoji.Known.Dagger}");

            Console.WriteLine("Type 'end' if you want to quit.");
            Console.WriteLine("\nIf You want go back to the previous menu press 'x'\n");
            Console.WriteLine("________________________________");
            string command = AnsiConsole.Prompt(
            new SelectionPrompt<string>().Title("\nSelect what you want to do: ").AddChoices("stats", "treasure", "inventory", "forest", "dungeons", "mine"));

            Console.WriteLine($"\nYou choose: { command}");
            Game.HandleCommand(command);         
            do
            {
               
                var userCommand = Console.ReadLine();
                if (userCommand == "x") // I try to do this yet but i think I need some prompt about it 
                {
                    Game.HandleCommand(command);
                }
                Game.HandleCommand(userCommand);
                Console.WriteLine();               
            }
            while (command.ToLower() != "end");
        }
    }
}
