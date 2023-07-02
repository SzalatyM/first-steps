using FirstSteps.RPG.Items;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstSteps.RPG.Heroes
{
    public class Elf : Hero
    {
        public string Name { get; set; }
        public Races Race { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public int Agility { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }
        public int CoinsBag { get; set; }

        private List<Arrow> _arrowsBag = new List<Arrow>();

        public Elf(string name) : base(name, Races.Elf)
        {
            _strength = 3;
            _intelligence = 2;
            _agility = 5;
            _health = 21;
            _damage = 9;
        }
        public Elf(string name, Races race, int strength, int intelligence, int agility, int health, int damage, int coinsBag) :base(name,Races.Elf)
        {
            Race = race;
            Strength = strength;
            Intelligence = intelligence;
            Agility = agility;
            Health = health;
            Damage = damage;
            CoinsBag = coinsBag;  
            Name = name;
        }
        
        protected override bool CanHandleSpecialItem(Item item)
        {
            return item is MagicBow;
        }

        public void Heal()
        {
            _health += _health + 10;
            Console.WriteLine("U gain 10hp!");
        }

        public void CollectArrows(List<Arrow> arrows)
        {
            _arrowsBag.AddRange(arrows);
        }

        public override int DealDamage()
        {
            bool magicBowIsInTheBackpack = _equipment.Backpack.Any(x => x is MagicBow);

            return magicBowIsInTheBackpack ? _agility * 4 : _damage + _agility;
        }
    }
}