using FirstSteps.RPG.Items;
using System;
using System.Collections.Generic;
using System.Text;
using FirstSteps.RPG.Heroes;

namespace FirstSteps.RPG
{
    public class Equipment
    {
        private List<Item> backPack = new List<Item>();
        const int maxBackpack = 5;
        const int _maxWeight = 40;
        public int _coinsBag;
        private Hero _hero;

        
        public bool TryAddItemToBackpack(Item item)
        {
            if (!CanHandleSpecialItem(item))
            {
                return false;
            }
            else if (backPack.Count <= maxBackpack && CountWeight() <= _maxWeight && item.Weight + CountWeight() <= _maxWeight)
            {
                backPack.Add(item);
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

            foreach (Item item in backPack)
            {
                totalPrice += item.Price;
            }
            return totalPrice.ToString();
        }
        public string DisplayTotalItems()
        {
            string totalItems = " ";

            foreach (Item item in backPack)
            {
                totalItems += item.Name + " ";
            }
            return totalItems;
        }

        public string DisplayTotalWeight()
        {
            int totalWeight = 0;
            foreach (Item item in backPack)
            {
                totalWeight += item.Weight;
            }
            return totalWeight.ToString();
        }

        private int CountWeight()
        {
            int totalWeight = 0;
            foreach (Item item in backPack)
            {
                totalWeight += item.Weight;
            }
            return totalWeight;
        }     
    }
}

