using System;
using System.Collections.Generic;
using System.Text;
using FirstSteps.RPG.Items;
using FirstSteps.RPG.Heroes;
using FirstSteps.RPG;
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
            var random = new Random().Next(1,5);
            if(random > itemsForHuman.Count)
            {
                Console.WriteLine("Not this time!");
                return null;              
            }
            else
            {
                Console.WriteLine($" You rolled: {itemsForHuman[0].Name}");
                return itemsForHuman[0];
                
            }
        }
    }
}
