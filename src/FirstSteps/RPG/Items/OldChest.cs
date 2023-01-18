using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstSteps.RPG.Items
{
    class OldChest
    {
        public static List<Item> itemsForHuman = new List<Item>()
        {
            new Pitchfork(),
            new Knife()
        };
        public static Item Open()
        {
            var random = new Random().Next(0,5);
            if (random > itemsForHuman.Count() || random == 2)
            {
                Console.WriteLine("Empty slot");
                return null;
            }
            else
            {
                Console.WriteLine(itemsForHuman[random]);
                return itemsForHuman[random];
            }
        }
    }
}
