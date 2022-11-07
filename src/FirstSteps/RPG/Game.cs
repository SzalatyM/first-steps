using System;
using FirstSteps.RPG.Heroes;
using System.Collections.Generic;
using FirstSteps.RPG.Items;
using System.Linq;
using FirstSteps.RPG.Adventures;

namespace FirstSteps.RPG
{
    public static class Game
    {
        private static List<Item> _inventory = new List<Item>()
        {
            new MagicAxe(),
            new MagicBow(),
            new MagicSkull(),
            new MagicSword()
        };
        private static Hero _hero;
        private static Forest _forest;

        public static void CreateHero()
        {
            Console.WriteLine("Create your hero");

            Console.Write("Type hero name: ");
            var name = Console.ReadLine();

            Console.WriteLine("Choose hero race: ");

            DisplayAllRaces();

            var race = int.Parse(Console.ReadLine());

            _hero = HeroesCreator.Create(name, (Races)race);

            DisplayGreetings();


        }

        public static void DisplayCommands()
        {
            Console.WriteLine("Commands:");
            Console.WriteLine("Type 'stats' to display hero statistics.");
            Console.WriteLine("Type 'treasure' to get a chance to find coins");
            Console.WriteLine("Type 'inventory' to go to the inventory with items");
            Console.WriteLine("Type 'forest' to enter to forest");
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
                case "forest":
                    if(_hero is Elf)
                    {
                        _forest.Enter((Elf)_hero); // rly i dont understand this :( 
                    }
                    else
                    {
                        Console.WriteLine("You can't enter! Only Elf have acces to the Forest");
                    }
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
            var item = _inventory.FirstOrDefault(item => item.Name == userInput);
            if (item == null)
            {
                Console.WriteLine("There is no such item to buy!");
            }
            else if (_hero.TrySpendCoins(item))
            {
                _hero.AddItemToBackpack(item);
                _inventory.Remove(item);
                Console.WriteLine($"You bought a {userInput} ");
            }
            else
            {
                Console.WriteLine($"You dont have a coins to buy a {userInput} ");
            }
        }
        public static void DisplayGreetings()
        {
           IGreeting greeting = _hero as IGreeting;             
           Console.WriteLine(greeting != null ? greeting.Greed() : "Hello");
            
            //IGreeting greeting = _hero as IGreeting;
            //if(greeting != null)
            //{
            //    Console.WriteLine(greeting.Greed());
            //}
            //else
            //{
            //    Console.WriteLine("hello");

            //}
            //if(_hero is IGreeting)
            //{
            //    IGreeting greeting = (IGreeting)_hero;
            //    Console.WriteLine(greeting.Greed());
            //}
            //else
            //{
            //    Console.WriteLine("hello");
            //}
        }
        
    }
}
