using FirstSteps.RPG.Heroes;
using System;
using FirstSteps.RPG.Items;

namespace FirstSteps.RPG.Adventures
{
    class Village 
    {
        public void Enter(Hero hero, Item item)
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
            human.AddItemToBackpack(item); // I tryed to do this with variable private Item item; and add item to human.AddItemToBackPack(item) - doesn't work 
            // i will be greatfull that u explain me in details that i could understand in next examples/ future. Because at this moment im trying different options without understanding it :(
            OldChest.Open();
        }
    }
}