using System;
using FirstSteps.RPG.Items;
using Spectre.Console;
using AutoMapper;

namespace FirstSteps.RPG.Heroes
{
    public abstract class Hero : IAttacker
    {
        protected Equipment _equipment;
        private string _name;
        private Races _race;
        protected int _strength;
        protected int _intelligence;
        protected int _agility;
        protected int _health;
        public int Health { get { return _health; } }
        protected int _damage;
        private int _coinsBag;
        public int Coins { get { return _coinsBag; } set { _coinsBag = value; } }

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
            Console.WriteLine($"Equipment: \nTotal coins: {Coins} \nTotal price: {_equipment.DisplayTotalPrice()}\nTotal items:{_equipment.DisplayTotalItems()}\nTotal weight: {_equipment.DisplayTotalWeight()} ");
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

        public int TakeDamage(int damage)
        {
            return _health -= damage;
        }
        public HeroModel ToHeroModel()
        {
            HeroModel heroModel = new HeroModel
            {
                Name = _name,
                Race = _race,
                Health = _health,
                Strength = _strength,
                Intelligence = _intelligence,
                Agility = _agility,               
                CoinsBag = _coinsBag,
                Damage = _damage               
            };
            return heroModel;        
        }
    }
}