using System;
using FirstSteps.RPG.Items;
using Spectre.Console;

namespace FirstSteps.RPG.Heroes
{
    public abstract class Hero : IHeroesDamage
    {
        private Equipment _equipment;
        public Equipment equipment { get { return _equipment; } }
        private string _name;
        private Races _race;
        protected int _strength;
        public int Strength { get { return _strength; } }
        protected int _intelligence;
        public int Intelligence { get { return _intelligence; } }
        protected int _agility;
        public int Agility { get { return _agility; } }
        protected int _health;
        public int Health { get { return _health; } }
        protected int _damage;
        public int Damage { get { return _damage; } }
        private int _coinsBag;
        public int Coins { get { return _coinsBag; } set { Coins = value; } }

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
                return false;
            }
            else
            {
                _equipment.TryAddItemToBackpack(item);
                return true;
            }
        }

        public bool TrySpendCoins(Item item)
        {
            if (!CanHandleSpecialItem(item))
            {
                throw new HeroCantHoldItemException();
            }
            if (_coinsBag >= item.Price)
            {
                _coinsBag -= item.Price;
                return true;
            }
            return false;
        }    
        public void AddCoins(int coins)
        {
            _coinsBag += coins;
        }

        public abstract int DealDamage();
    }
}