using FirstSteps.RPG.Items;
using FirstSteps.RPG.ModelFiles;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstSteps.RPG.Heroes
{
    public class Elf : Hero
    {
        private List<Arrow> _arrowsBag = new List<Arrow>();

        public Elf(string name) : base(name, Races.Elf)
        {
            _strength = 3;
            _intelligence = 2;
            _agility = 5;
            _health = 21;
            _damage = 9;
            _coinsBag = 0;

        }
        private static Elf NewElf(string name, int strength, int intelligence, int agility, int health, int damage, int coinsBag, Equipment equipment)
        {
            return NewElf(name, strength, intelligence, agility, health, damage, coinsBag, equipment);
        }

        public static Elf FromHeroModel(HeroModel heroModel)
        {
            string name = heroModel.Name;
            int strength = heroModel.Strength;
            int intelligence = heroModel.Intelligence;
            int agility = heroModel.Agility;
            int health = heroModel.Health;
            int damage = heroModel.Damage;
            int coinsBag = heroModel.CoinsBag;
            Equipment equipment = heroModel.MapToEquipment();

            return NewElf(name, strength, intelligence, agility, health, damage, coinsBag, equipment);
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