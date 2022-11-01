using System;
using FirstSteps.RPG.Heroes;
using System.Collections.Generic;
using FirstSteps.RPG.Items;
using System.Linq;

namespace FirstSteps.RPG
{
    public static class Game
    {
        private static List<Item> _inventory = new List<Item>()
        {
        new Item("MagicAxe", 5,17),
        new Item("MagicSkull", 6, 10),
        new Item("MagicBow", 8, 15),
        new Item("MagicSword", 9, 16)
        };

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
            Random random = new Random();
            int drawCoins = random.Next(1, 25);
            _hero.AddCoins(drawCoins);
            Console.WriteLine($"You opened the treasure chest! You get {drawCoins} coins");
        }
        private static void Inventory()
        {
            foreach (var inventory in _inventory)
            {
                Console.WriteLine();
                Console.WriteLine($"Name: {inventory.Name}\nPrice: {inventory.Price} coins");
                Console.WriteLine();
            }

            Console.WriteLine("Which item u want to buy?\nEnter a name to select");
            string userInput = Console.ReadLine();
            string itemToBuy;

            switch (userInput)
            {
                case "MagicAxe":
                    itemToBuy = userInput;
                    var axe = _inventory.FirstOrDefault(item => item.Name == "MagicAxe");
                    if (_hero.TrySpendCoins(axe))
                    {
                        _hero.AddItemToBackpack(axe);
                        _inventory.Remove(axe);
                        Console.WriteLine("You bought MagicAxe!");
                    }
                    else if(_hero.TrySpendCoins(axe) == false)
                    {
                        Console.WriteLine("You dont have a coins to buy this item");
                    }
                    else
                    {
                        Console.WriteLine("There is no such item to buy!");
                    }
                    break;
                case "MagicSword":
                    itemToBuy = userInput;
                    break;
                case "MagicSkull":
                    itemToBuy = userInput;
                    break;
                case "MagicBow":
                    itemToBuy = userInput;
                    break;
                default:
                    Console.WriteLine("There is no such item in your inventory");
                    break;

            }


            //Display all items in inventory with name and price

            //Read the item name that user want to buy from console

            //Check if the item of the given name exists in the inventory

            //Write chosen item to the local variable itemToBuy

            //Use TryTakeCoins method to check if the hero can afford this item price
            //If it is true add the item to the hero's backpack and remove it from the inventory
        }
    }
}
