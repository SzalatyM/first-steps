using System;
using System.Collections.Generic;
using FirstSteps.RPG.Items;
using Spectre.Console;

namespace FirstSteps.RPG.Heroes
{
    public abstract class Hero
    {
        public Equipment equipment { get { return _equipment; } }
        private Equipment _equipment;
        private string _name;
        private Races _race;
        protected int _strength;
        protected int _intelligence;
        protected int _agility;
        protected int _health;
        protected int _damage;
        private int _coinsBag;
        public int Coins { get { return _coinsBag; } set { Coins = value; } }
        private Item _item;
        public Item item { get { return _item;} set { item = value; } }

        public Hero(string name, Races race)
        {
            _equipment = new Equipment();
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
            Console.WriteLine($"Equipment:\ntotal price: {_equipment.DisplayTotalPrice()}\ntotal items: {_equipment.DisplayTotalItems()}\ntotal weight; {_equipment.DisplayTotalWeight()} ");
        }
        protected abstract bool CanHandleSpecialItem(Item item);

        public bool AddItemToBackpack(Item item)
        {
            if (!CanHandleSpecialItem(item))
            {
                Console.WriteLine("You can't hold this item!");
                return false;
            }
            else
            {
                equipment.TryAddItemToBackpack(item);
                return true;
            }
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
        public void AddCoins(int coins)
        {
            _coinsBag = _coinsBag + coins;
        }
    }
}

