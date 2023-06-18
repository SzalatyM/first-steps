using System;
using FirstSteps.RPG.Heroes;
using FirstSteps.RPG.Tools;
using Spectre.Console;

namespace FirstSteps.RPG
{
    public static class Game
    {
        private static Hero _hero;
        private static AdventuresRegistry _adventuresRegistry = new AdventuresRegistry();
        private static void CreateHero()
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
        private static void HandleCommand(string command)
        {
            var adventure = _adventuresRegistry.GetAdventure(command);

            if (adventure != null)
            {
                adventure.Enter(_hero);
            }
            else if (command == "Stats")
            {
                DisplayHeroStats();
            }
        }
        private static void DisplayHeroStats()
        {
            _hero.DisplayStats();
        }

        private static void DisplayAllRaces()
        {
            var races = Enum.GetNames(typeof(Races));
            for (int i = 0; i < races.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {races[i]}");
            }
        }
        private static string MenuSelect()
        {
            var menu = new SelectionPrompt<string>();

            menu.AddChoice("Hero")
                .AddChild("Stats");

            menu.AddChoiceGroup("Adventures", _adventuresRegistry.GetCommands());
            menu.AddChoice("Settings")
                .AddChild("end");
            return AnsiConsole.Prompt(menu);

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
            HeroesRepository.SafeHero(_hero);
            do
            {
                userInput = MenuSelect();
                HandleCommand(userInput);
                Console.WriteLine();
            }
            while (userInput != "end");
        }
    }
}