using System;
using FirstSteps.RPG.Heroes;
using FirstSteps.RPG.Adventures;
using Spectre.Console;
using FirstSteps.RPG.Tools;

namespace FirstSteps.RPG
{
    public static class Game
    {
        private static Mine _mine = new Mine();
        private static Forest _forest = new Forest();
        private static Dungeons _dungeons = new Dungeons();
        private static Village _village = new Village();
        private static Inventory _inventory = new Inventory();
        private static TreasureAdventure _treasureAdventure = new TreasureAdventure();
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

        }
        public static void HandleCommand(string command)
        {
            switch (command)
            {
                case "stats":
                    DisplayHeroStats();
                    break;
                case "treasure":
                    _treasureAdventure.Treasure(_hero);
                    break;
                case "inventory":
                    _inventory.DisplayAllItems(_hero);
                    break;
                case "forest":
                    _forest.Enter(_hero);
                    break;
                case "dungeons":
                    _dungeons.Enter(_hero);
                    break;
                case "mine":
                    _mine.Enter(_hero);
                    break;
                case "village":
                    _village.Enter(_hero);
                    break;
                default:
                    Display.WarningText($"Command {command} not recognized");
                    break;
            }
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

        //private static void Treasure()
        //{
        //    var drawCoins = new Random().Next(1, 25);
        //    _hero.AddCoins(drawCoins);
        //    Console.WriteLine($"You opened the treasure chest! You get {drawCoins} coins");
        //}
    }
}