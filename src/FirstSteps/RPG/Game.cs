using System;
using FirstSteps.RPG.Heroes;
using FirstSteps.RPG.Items;

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
            Console.WriteLine("Type 'treasure' to get a chance to draw an item");

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

        public static void Treasure()
        {

            var sword = new Item("Sword", 20, 18);
            var crystal = new Item("crystal", 30, 5);
            var bow = new Item("bow", 40, 12);

            Item[] items = { sword, crystal, bow, null, null, null };


            Random random = new Random();
            Console.WriteLine("Press any key to draw an item!");
            Console.ReadLine();

            
            int index = random.Next(items.Length);


            if (items[index] != null)
            {
                Console.WriteLine($" Item placed in backpack " + items[index]);
                _hero.AddItemToBackpack(items[index]);
            }                                             
            else
            {
                Console.WriteLine("failed this time");
            }
        }
    }
}
