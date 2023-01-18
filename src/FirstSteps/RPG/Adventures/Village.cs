using FirstSteps.RPG.Heroes;
using System;
using FirstSteps.RPG.Items;
using System.Collections.Generic;

namespace FirstSteps.RPG.Adventures
{
    class Village
    {
        public void Enter(Hero hero)
        {
            if (hero is Human)
            {
                Console.WriteLine("\nYou enter to the Village!");
            }
            else
            {
                Console.WriteLine("You can't enter to the village! Only human can enter!");
                return;
            }
            Console.WriteLine("\nPress any button to try get an item!");
            Console.ReadLine();
            Human human = (Human)hero;
            Item item = OldChest.Open(item => item != null);
            human.AddItemToBackpack(item);
            Console.WriteLine($"U get a {item.Name}");
            
        }
        //Console.WriteLine($"U get a {itemsForHuman[random].Name}");
        //Console.WriteLine("\nUnfortunately, Empty slot!");
    }
}