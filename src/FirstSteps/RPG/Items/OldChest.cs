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
                Console.WriteLine($"U get a {itemsForHuman[random].Name}"); // i dont know why i have error that index is out of range. Can u explain ? i didnt assign any range/length
                // i thought the error was coused, i have 0 do 5 but when i changed to 1,5 errow was the same.
                return itemsForHuman[random];
            }
        }
    }
}
