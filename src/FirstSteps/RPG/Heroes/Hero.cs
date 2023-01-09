using System;
using System.Collections.Generic;
using FirstSteps.RPG.Items;
using Spectre.Console;

namespace FirstSteps.RPG.Heroes
{
    public abstract class Hero
    {
        private List<Item> backPack = new List<Item>();
        private int _coinsBag;
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
            AnsiConsole.Write(new BarChart()
    .Width(60)
    .Label($"[blue bold underline] {_race}: {_name} [/]") 
    .CenterLabel()
    .AddItem("Strength", _strength, Color.Orange1)
    .AddItem("Intelligence", _intelligence, Color.Blue)
    .AddItem("Agility", _agility, Color.Yellow)
    .AddItem("Health", _health, Color.Red)
    .AddItem("Damage", _damage, Color.Green));
            Console.WriteLine($"Equipment:\ntotal price: {DisplayTotalPrice()}\ntotal items: {DisplayTotalItems()}\ntotal weight; {DisplayTotalWeight()} ");
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