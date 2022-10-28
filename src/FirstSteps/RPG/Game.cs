using System;
using FirstSteps.RPG.Heroes;

namespace FirstSteps.RPG
{
    public static class Game
    {
        private static Hero _hero;

        public static void CreateHero()
        {
            Console.WriteLine("Create your hero");

            Console.Write("Type hero name: ");
            var name = Console.ReadLine();

            Console.WriteLine("Choose hero race: ");

            DisplayAllRaces();

            var race = int.Parse(Console.ReadLine());

           _hero = HeroesCreator.Create(name, (Races)race);
        }

        public static void DisplayCommands()
        {
            Console.WriteLine("Commands:");
            Console.WriteLine("Type 'stats' to display hero statistics.");
            Console.WriteLine("Type 'treasure' to get a chance to find coins");
            Console.WriteLine("Type 'inventory' to go to the inventory with items");
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
                    Inventory();
                    break;
                default:
                    Console.WriteLine($"Command {command} not recognized");
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

        }

        private static void Inventory()
        {
            //Display all items in inventory with name and price

            //Read the item name that user want to buy from console

            //Check if the item of the given name exists in the inventory

            //Write chosen item to the local variable itemToBuy

            //Use TryTakeCoins method to check if the hero can afford this item price
            //If it is true add the item to the hero's backpack and remove it from the inventory
        }
    }
}
