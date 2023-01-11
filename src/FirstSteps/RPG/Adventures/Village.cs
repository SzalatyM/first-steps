using FirstSteps.RPG.Heroes;
using System;
using System.Collections.Generic;
using System.Text;
using FirstSteps.RPG.Items;

namespace FirstSteps.RPG.Adventures
{
    class Village
    {
        public void Enter(Hero hero)
        {
            if (hero is Human)
            {
                Console.WriteLine("You enter to the Village!");
            }
            else
            {
                Console.WriteLine("You can't enter to the village! Only human can enter!");
            }
            Console.WriteLine("Choose a number from 1 to 5.\n If your choise is equals computer choise u win a random item");
            Human human = (Human)hero;

            List<Item> items = new List<Item>();
            var computer = new Random().Next(1, 2);
            Console.WriteLine($"Computer rolled! Your turn now! Good Luck");
            var player = Console.ReadLine();
            Console.WriteLine($"You rolled: {player}");
            Console.WriteLine(computer);
            if (computer == int.Parse(player))
            {
                items.Add(new Item());
                foreach (var item in items)
                {
                    Console.WriteLine(item);
                }               
            }
            else
            {
                Console.WriteLine("This time it failed! Try again.");
            }
        }
    }
}