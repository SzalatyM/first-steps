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
               
                var userCommand = Console.ReadLine();
                if (userCommand == "x")
                {
                    Game.HandleCommand(command);
                }
                Game.HandleCommand(userCommand);
                Console.WriteLine();               
            }
            while (userInput != "end");
        }
    }
}
