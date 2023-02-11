using System;
using FirstSteps.RPG.Heroes;
using System.Collections.Generic;
using FirstSteps.RPG.Items;
using System.Linq;
using FirstSteps.RPG.Adventures;
using Spectre.Console;
using FirstSteps.RPG.Tools;

namespace FirstSteps.RPG
{
    public static class Game
    {
        private static Mine mine = new Mine();
        private static Forest forest = new Forest();
        private static Dungeons dungeons = new Dungeons();
        private static Village village = new Village();
        private static Inventory inventory = new Inventory();
        private static Hero _hero;
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

            DisplayGreetings();
        }
        public static void HandleCommand(string command)
        {
            switch (command)
            {
                case "stats":
                    DisplayHeroStats();
                    break;
                case "treasure":
                    Treasure();
                    break;
                case "inventory":
                    inventory.ShowItems(_hero);
                    break;
                case "forest":
                    forest.Enter(_hero);
                    break;
                case "dungeons":
                    dungeons.Enter(_hero);
                    break;
                case "mine":
                    mine.Enter(_hero);
                    break;
                case "village":
                    village.Enter(_hero);
                    break;
                //case "x":
                //    Console.WriteLine(command);

                default:
                    Display.WarningText($"Command {command} not recognized");
                    break;
            }
        }
        public static void DisplayHeroStats()
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

        private static void Treasure()
        {
            Random random = new Random();
            int drawCoins = random.Next(1, 25);
            _hero.AddCoins(drawCoins);
            Console.WriteLine($"You opened the treasure chest! You get {drawCoins} coins");
        }
        public static void DisplayGreetings()
        {
            IGreeting greeting = _hero as IGreeting;
            Console.WriteLine(greeting != null ? greeting.Greed() : "\nBest choice. You play the strongest class in the game\n ");
        }
    }

}
