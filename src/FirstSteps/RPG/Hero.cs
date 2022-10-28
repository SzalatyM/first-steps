using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstSteps.RPG
{

    abstract class Hero
    {

        private List<Item> backPack = new List<Item>();

        private string _name { get; set; }
        private Races _race { get; set; }
        protected int _strength;
        public int Strength
        {
            get { return _strength; }
        }
        protected int _intelligence;
            public int Intelligence
        {
            get { return _intelligence; }
        }
        protected int _agility;
        public int Agility
        {
            get { return _agility; }
        }
        protected int _health;
        public int Health
        {
            get { return _agility; }
        }
        protected int _damage;
        public int Damage
        {
            get { return _damage; }
        }
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
            if (CanHandleSpecialItem(item))
            {
                return true;
            }
            else
            {
                return false;
            }

         //   if (backPack.Count <= maxBackpack && CountWeight() <= _maxWeight    item.Weight + CountWeight() <= _maxWeight)
            {
                backPack.Add(item);
                return true;
            }
        //    else
            {
                return false;
            }            
        }
        private string DisplayTotalPrice()
        {
            int totalPrice = 0;

            foreach (Item item in backPack)
            {
           //     totalPrice += item.Price;
            }
            return totalPrice.ToString();
        }
        private string DisplayTotalItems()
        {
            string totalItems = " ";

            foreach (Item item in backPack)
            {
          //      totalItems += item.Name + " ";
            }
            return totalItems;
        }
        private string DisplayTotalWeight()
        {
            int totalWeight = 0;
            foreach (Item item in backPack)
            {
            //    totalWeight += item.Weight;
            }
            return totalWeight.ToString();
        }

        private int CountWeight()
        {
            int totalWeight = 0;
            foreach (Item item in backPack)
            {
           //     totalWeight += item.Weight;
            }
            return totalWeight;
        }
        protected abstract bool CanHandleSpecialItem(Item item);
    }
}
    

    

