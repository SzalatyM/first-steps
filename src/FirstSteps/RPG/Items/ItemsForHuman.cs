using System;
using System.Collections.Generic;
using System.Text;

namespace FirstSteps.RPG.Items
{
   public class ItemsForHuman : Item
    {
        List<Item> itemList = new List<Item>()
        {
            new Item("Ring", 4, 4),
            new Item("earning", 5, 3),
            new Item("necklace", 4,6)
        };
        public void Roll(List<Item> items)
        {
            itemList.AddRange(items);
        }
    }
}
