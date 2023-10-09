﻿using FirstSteps.RPG.Items;
using FirstSteps.RPG.HeroesModels;
using System.Linq;

namespace FirstSteps.RPG.Heroes
{
    public class Undead : Hero
    {
        public int ManaPoints { get; private set; }
        private bool CanUseManaPoints => ManaPoints > 0;

        public Undead(string name) : this(name, 3, 3, 4, 22, 8, 0, new Equipment())
        {

        }
        private Undead(string name, int strength, int intelligence, int agility, int health, int damage, int coinsBag, Equipment equipment) : base(name, Races.Undead)
        {
            _strength = strength;
            _intelligence = intelligence;
            _agility = agility;
            _health = health;
            _damage = damage;
            _coinsBag = coinsBag;
            _equipment = equipment;
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

            return new Undead(name, strength, intelligence, agility, health, damage, coinsBag, equipment);
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

            if(CanUseManaPoints)
            {
                ManaPoints -= 1;
                return magicSkullIsInTheBackpack ? _damage + _intelligence * 2 : _damage + _intelligence;               
            }
            return 0;   
        }   
    }
}