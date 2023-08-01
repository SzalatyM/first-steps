﻿using FirstSteps.RPG.Items;
using FirstSteps.RPG.ModelFiles;
using System.Linq;

namespace FirstSteps.RPG.Heroes
{
    public class Undead : Hero
    {
        public int ManaPoints { get; private set; }

        public Undead(string name) : base(name, Races.Undead)
        {
            _strength = 3;
            _intelligence = 3;
            _agility = 4;
            _health = 22;
            _damage = 8;
            _coinsBag = 0;
        }
        private static Undead NewUndead(string name, int strength, int intelligence, int agility, int health, int damage, int coinsBag, Equipment equipment)
        {
            return NewUndead(name, strength, intelligence, agility, health, damage, coinsBag, equipment);
        }

        public static Undead FromHeroModel(HeroModel heroModel)
        {
            string name = heroModel.Name;
            int strength = heroModel.Strength;
            int intelligence = heroModel.Intelligence;
            int agility = heroModel.Agility;
            int health = heroModel.Health;
            int damage = heroModel.Damage;
            int coinsBag = heroModel.CoinsBag;
            Equipment equipment = heroModel.MapToEquipment();

            return NewUndead(name, strength, intelligence, agility, health, damage, coinsBag, equipment);
        }
        protected override bool CanHandleSpecialItem(Item item)
        {
            return item is MagicSkull;
        }

        public void ManaIncreases(int mana)
        {
            ManaPoints += mana;
        }

        public override int DealDamage()
        {
            bool magicSkullIsInTheBackpack = _equipment.Backpack.Any(x => x is MagicSkull);

            return magicSkullIsInTheBackpack ? _damage + _intelligence * 2 : _damage + _intelligence;
        }
    }
}