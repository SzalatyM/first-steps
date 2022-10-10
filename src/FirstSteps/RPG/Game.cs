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

            Console.WriteLine("Choose hero race: ");

            DisplayAllRaces();

            var race = int.Parse(Console.ReadLine());

            _hero = new Hero(name, (Races)race);
        }

        public static void DisplayCommands()
        {
            Console.WriteLine("Commands:");
            Console.WriteLine("Type 'stats' to display hero statistics.");
            Console.WriteLine("Type 'BossStats' to display boss statistics");
            Console.WriteLine("Type 'adventure' to move on to the boss fight");
            Console.WriteLine("Type 'lvl' to add stat points");
            Console.WriteLine("Type 'treasure' to get a chance to draw an item");

        }

        public static void HandleCommand(string command)
        {
            switch (command)
            {
                case "stats":
                    DisplayHeroStats();
                    break;
                case "adventure":
                    BossFight();
                    break;
                case "BossStats":
                    BossStats();
                    break;
                case "treasure":
                    Treasure();
                    break;
                case "lvl":
                    LevelUp();
                    break;
                default:
                    Console.WriteLine($"Command {command} not recognized");
                    break;
            }
        }
        public static Boss _boss;
        public static Item _item;

        public static void BossStats()
        {
            Boss _boss = new Boss("Diablo", 220, 28);

            Console.WriteLine(_boss.ToString());
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

        public static void BossFight()
        {

            Console.WriteLine("Lets fight with the Diablo Boss! ");

            Random random = new Random();
            _boss = new Boss("Diablo", 220, 28);

            bool playAgain = true;
            string player;
            string computer;


            while (playAgain)
            {
                player = "";
                computer = "";


                while (player != "s" && player != "p" && player != "r")
                {


                    Console.WriteLine(" Type: scissors 's', rock 'r' , paper 'p'");
                    player = Console.ReadLine();
                }

                switch (random.Next(1, 4))
                {

                    case 1:
                        computer = "r";
                        break;
                    case 2:
                        computer = "p";
                        break;
                    case 3:
                        computer = "s";
                        break;
                }

                Console.WriteLine("player: " + player);
                Console.WriteLine("computer: " + computer);


                switch (player)
                {
                    case "s":

                        if (computer == "s")
                        {
                            Console.WriteLine("Block!");
                        }
                        else if (computer == "p")
                        {
                            HitBoss();
                        }
                        else
                        {
                            HitHero();
                        }
                        break;
                    case "r":

                        if (computer == "r")
                        {
                            Console.WriteLine("Block!");
                        }
                        else if (computer == "p")
                        {
                            HitHero();

                        }
                        else
                        {
                            HitBoss();
                        }
                        break;

                    case "p":
                        if (computer == "r")
                        {
                            HitBoss();

                        }
                        else if (computer == "p")
                        {
                            Console.WriteLine("Block!");
                        }
                        else
                        {
                            HitHero();
                        }
                        break;
                }
                if (_boss.hp <= 0)
                {
                    Console.WriteLine("Boss died! Congratulations, u Won!");
                    break;
                }
                else if (_hero._health <= 0)
                {
                    Console.WriteLine($"Game over! You Died");
                    break;
                }

            }
        }

        public static void LevelUp()
        {
            RollDice();
        }

        public static void RollDice()
        {

            int playerRoll;
            int computerRoll;
            Random rollDice = new Random();

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Press any key to roll the dice!\nYou have a only one chance! ");
                Console.ReadKey();
                playerRoll = rollDice.Next(1, 24);
                Console.WriteLine("You rolled a " + playerRoll);

                computerRoll = rollDice.Next(1, 24);
                Console.WriteLine("Boss rolled a " + computerRoll);

                if (playerRoll > computerRoll)
                {
                    Console.WriteLine($"Congratulation!\n You gain +1 agility! U have now {_hero._agility = _hero._agility + 1} agility points!");
                }
                else
                {
                    Console.WriteLine("This time it didn't work out");
                }
            }
        }

        public static void HitBoss()
        {

            _boss.hp -= _hero._Damage;
            Console.WriteLine($"Boss lose {_hero._Damage} HP");
            Console.WriteLine($"Actually Boss hp = {_boss.hp}");

        }

        public static void HitHero()
        {
            _hero._health -= _boss.dmg;
            Console.WriteLine($"Hero lose {_boss.dmg} HP");
            Console.WriteLine($"Actually Hero hp = {_hero._health}");

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
