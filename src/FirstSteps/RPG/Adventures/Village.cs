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
            if (!(hero is Human))
            {
                Console.WriteLine("You can't enter to the village! Only human can enter!");
                return;
            }
            Console.WriteLine("\nYou enter to the Village!");
            Console.WriteLine("\nPress any button to try get an item!");
            Console.ReadLine();
            Item item = OldChest.Open();
            if (item == null)
            {
                Console.WriteLine("\nUnfortunately, Empty slot!");
                return;
            }
            hero.AddItemToBackpack(item);
        }
    }
}