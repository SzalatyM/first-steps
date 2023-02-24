using FirstSteps.RPG.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstSteps.RPG
{
    public class Equipment
    {
        private List<Item> backPack = new List<Item>();
        private int maxBackpack = 5;
        private int _maxWeight = 40;
        private int _coinsBag;
        public int Coins { get { return _coinsBag; } }

        public bool AddItemToBackpack(Item item)
        {
            return TryAddItemToBackpack(item);
        }
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

        private bool CanHandleSpecialItem(Item item) 
        {
            return item is Item;
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

        public void AddCoins(int coins)
        {
            _coinsBag = _coinsBag + coins;
        }
        public bool TrySpendCoins(Item item)
        {
            if (_coinsBag >= item.Price)
            {
                _coinsBag = _coinsBag - item.Price;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
