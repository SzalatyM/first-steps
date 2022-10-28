using System;
using System.Collections.Generic;
using FirstSteps.RPG.Items;

namespace FirstSteps.RPG.Heroes
{
    public abstract class Hero
    {
        private List<Item> backPack = new List<Item>();
        private string _name;
        private Races _race;
        protected int _strength;
        protected int _intelligence;
        protected int _agility;
        protected int _health;
        protected int _damage;

        private int maxBackpack = 5;
        private int _maxWeight = 40;

        public Hero(string name, Races race)
        {
            _name = name;
            _race = race;
        }

        public void DisplayStats()
        {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine($"Race: {_race}");
            Console.WriteLine($"Strength: {_strength} \nIntelligence: {_intelligence} \nAgility: {_agility} \nHealth: {_health} \nDamage: {_damage}\n");
            Console.WriteLine($"Equipment: total price: {DisplayTotalPrice()}\ntotal items: {DisplayTotalItems()}\ntotal weight; {DisplayTotalWeight()} ");
        }

        public bool AddItemToBackpack(Item item)
        {
            if (!CanHandleSpecialItem(item))
            {
                return false;
            }
            else if (backPack.Count <= maxBackpack && CountWeight() <= _maxWeight && item.Weight + CountWeight() <= _maxWeight)
            {
                backPack.Add(item);
                return true;
            }
            else
            {
                return false;
            }
        }
        
        protected abstract bool CanHandleSpecialItem(Item item);

        private string DisplayTotalPrice()
        {
            int totalPrice = 0;

            foreach (Item item in backPack)
            {
                totalPrice += item.Price;
            }
            return totalPrice.ToString();
        }

        private string DisplayTotalItems()
        {
            string totalItems = " ";

            foreach (Item item in backPack)
            {
                totalItems += item.Name + " ";
            }
            return totalItems;
        }

        private string DisplayTotalWeight()
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