using System;
using System.Collections.Generic;
using System.Linq;
namespace FirstSteps.RPG.Items
{
    class OldChest
    {
        private static List<Item> _itemsForHuman = new List<Item>()
        {
            new Pitchfork(),
            new Knife()
        };

        public static Item Open()
        {
            var random = new Random().Next(0, 5);
            if (random >= _itemsForHuman.Count())
            {
                return null;
            }
            else
            {
                return _itemsForHuman[random];
            }
        }
    }
}