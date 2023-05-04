using System;
using FirstSteps.RPG.Heroes;
using FirstSteps.RPG.Adventures;
using Spectre.Console;
using FirstSteps.RPG.Tools;
using System.Security.Cryptography.X509Certificates;
using System.Linq;

namespace FirstSteps.RPG
{
    public static class Game
    {
        private static Hero _hero;
        private static AdventuresRegistry _adventuresRegistry = new AdventuresRegistry();
        public static void CreateHero()
        {
            Console.WriteLine("Create your hero");

            var name = AnsiConsole.Ask<string>("Type hero name:");

            var selectedRace = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("Choose hero race:")
                    .AddChoices(Enum.GetNames(typeof(Races))));

            Enum.TryParse<Races>(selectedRace, out var race);

            _hero = HeroesCreator.Create(name, race);

        }
        public static void HandleAdventures(string command)
        {
            var adventure = _adventuresRegistry.GetAdventure(command);
            adventure.Enter(_hero);
        }
        public static void DisplayHeroStats()
        {
            _hero.DisplayStats();
        }

        public static void DisplayAllRaces()
        {
            var races = Enum.GetNames(typeof(Races));
            for (int i = 0; i < races.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {races[i]}");
            }
        }
        public static void GetMenu()
        {
            var menu = new SelectionPrompt<string>();

            menu.AddChoice("Hero")
                .AddChild("Stats");

            menu.AddChoiceGroup("Adventures", _adventuresRegistry.GetCommands());
            var command = AnsiConsole.Prompt(menu);
            Console.WriteLine(command);
        }
        public static void GameMenu()
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
                _adventuresRegistry.GetCommands();
                Game.GetMenu();
                Console.WriteLine();
                userInput = Console.ReadLine();
                Game.HandleAdventures(userInput);

            }
            while (userInput != "end");
        }
    }
}