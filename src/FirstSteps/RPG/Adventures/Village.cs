using FirstSteps.RPG.Heroes;
using System;
using System.Collections.Generic;
using System.Text;
using FirstSteps.RPG.Items;
using FirstSteps.RPG;

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
            OldChest.Open();
        }
    }
}