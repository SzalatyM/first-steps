using System;
using System.Collections.Generic;
using System.Text;
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
            else if(random == 0)
            {
                Console.WriteLine($" You get a : {itemsForHuman[0].Name}");
                return itemsForHuman[0];               
            }
            else
            {
                Console.WriteLine($" You get a : {itemsForHuman[1].Name}");
                return itemsForHuman[1];
            }
        }
    }
}
