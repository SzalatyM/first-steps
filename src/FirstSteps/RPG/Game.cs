using System;

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

            DisplayAllRaces();
            Console.Write("Choose hero race: ");
            var race = int.Parse(Console.ReadLine());

            _hero = new Hero(name, (Races)race);
        }

        public static void DisplayCommands()
        {
            Console.WriteLine("Commands:");
            Console.WriteLine("Type 'stats' to display hero statistics.");
            Console.WriteLine("...");
        }

        public static void HandleCommand(string command)
        {
            switch(command)
            {
                case "stats":
                    DisplayHeroStats();
                    break;
                case "fight":
                    Figth();
                    break;
                default:
                    Console.WriteLine($"Command {command} not recognized");
                    break;
            }
        }

        private static void Figth()
        {
            Console.WriteLine("Fight begins!");

            var random = new Random();
            var dmg = random.Next(0, 20); // random dmg value

            _hero.hp -= dmg; // reduce hero's HP by random damage

            Console.WriteLine($"Hero lose {dmg} HP");

            if(_hero.hp > 0) // if hero is still alive
            {
                _hero.strength++; // increase hero's strength by one
                _hero.agility += 2; // increase hero's agility by two

                Console.WriteLine("Hero win the fight!");
            }
            else
            {
                Console.WriteLine("You are dead!");
            }
        }

        public static void DisplayHeroStats()
        {
            _hero.DisplayStats();
        }

        private static void DisplayAllRaces()
        {
            var races = Enum.GetNames(typeof(Races));
            for(int i = 0; i < races.Length; i++)
            {
                Console.WriteLine($"{i+1}. {races[i]}");
            }
        }
    }
}