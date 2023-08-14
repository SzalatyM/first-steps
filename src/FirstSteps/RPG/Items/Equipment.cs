using FirstSteps.RPG.Items;
using System;
using System.Collections.Generic;

namespace FirstSteps.RPG
{
    public class Equipment
    {
        private List<Item> _backPack = new List<Item>();
        public List<Item> Backpack { get { return _backPack; } }

        const int MaxBackpack = 5;
        const int MaxWeight = 40;
    
        public bool TryAddItemToBackpack(Item item)
        {
            if (_backPack.Count <= MaxBackpack && CountWeight() <= MaxWeight && item.Weight + CountWeight() <= MaxWeight)
            {
                _backPack.Add(item);
                Console.WriteLine(item);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string DisplayTotalPrice()
        {
            int totalPrice = 0;

            foreach (Item item in _backPack)
            {
                totalPrice += item.Price;
            }
            return totalPrice.ToString();
        }
        public string DisplayTotalItems()
        {
            string totalItems = " ";

            foreach (Item item in _backPack)
            {
                totalItems += item.Name + " ";
            }
            return totalItems;
        }

        public string DisplayTotalWeight()
        {
            int totalWeight = 0;
            foreach (Item item in _backPack)
            {
                totalWeight += item.Weight;
            }
            return totalWeight.ToString();
        }

        private int CountWeight()
        {
            int totalWeight = 0;
            foreach (Item item in _backPack)
            {
                totalWeight += item.Weight;
            }
            return totalWeight;
        }
    }
}