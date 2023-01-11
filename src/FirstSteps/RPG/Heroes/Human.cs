using FirstSteps.RPG.Items;
using System;
using System.Collections.Generic;

namespace FirstSteps.RPG.Heroes
{
    public class Human : Hero
    {
        List<Item> itemList = new List<Item>()
        {
            new Item("Ring", 4, 4),
            new Item("earning", 5, 3),
            new Item("necklace", 4,6)
        };
        public Human(string name) : base(name, Races.Human)
        {
            _strength = 3;
            _intelligence = 2;
            _agility = 5;
            _health = 120;
            _damage = 20;
        }

        protected override bool CanHandleSpecialItem(Item item)
        {
            return item is MagicSword;
        }
        public void RolledItemToAdd(List<Item> items)
        {
            itemList.AddRange(items);
        }
    }
}

