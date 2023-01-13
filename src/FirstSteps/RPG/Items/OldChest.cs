using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstSteps.RPG.Items
{
    class OldChest
    {
        private static List<Item> itemsForHuman = new List<Item>()
        {
            new Pitchfork(),
            new Knife()
        };
        public static Item Open()
        {
            var random = new Random().Next(0,5);
            if(random > itemsForHuman.Count())
            {
                Console.WriteLine("\nUnfortunately, Empty slot!");
                return null;              
            }
            else
            {
                Console.WriteLine($"U get a {itemsForHuman[random].Name}");
               return itemsForHuman[random];
            }
        }
    }
}
