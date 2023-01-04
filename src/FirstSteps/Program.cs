using System;
using FirstSteps.RPG;
using Spectre.Console;

namespace FirstSteps
{
    class Program
    {
        static void Main(string[] args)
        {
            //displaying colored text with emoji, see docs: https://spectreconsole.net/prompts/text and https://spectreconsole.net/appendix/
            AnsiConsole.MarkupLine($"{Emoji.Known.BowAndArrow} [darkgreen]Welcome to the RPG game [/] {Emoji.Known.CrossedSwords}");

            Game.CreateHero();

            Console.WriteLine("Let's play the game");

            Game.DisplayCommands();

            Console.WriteLine("Type 'end' if you want to quit.");

            string command;

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