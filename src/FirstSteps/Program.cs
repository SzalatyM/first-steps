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

            Game.DisplayCommands();

            Console.WriteLine("Type 'end' if you want to quit.");

            string command = AnsiConsole.Prompt(
            new SelectionPrompt<string>().Title("Display Commands:").AddChoices("stats", "treasure", "inventory", "forest", "dungeons", "mine"));

            Game.HandleCommand(command);

            do
            {
                command = Console.ReadLine();
                Game.HandleCommand(command);
                Console.WriteLine();
            }
            while (command.ToLower() != "end");
        }
    }
}
