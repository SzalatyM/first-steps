﻿using FirstSteps.RPG.Items;
using System.Linq;

namespace FirstSteps.RPG.Heroes
{
    public class Dwarf : Hero, IGreeting
    {
        public Dwarf(string name) : base(name, Races.Dwarf)
        {
            _strength = 4;
            _intelligence = 2;
            _agility = 4;
            _health = 25;
            _damage = 7;
        }

        protected override bool CanHandleSpecialItem(Item item)
        {
            return item is MagicAxe;
        }

        public string Greed()
        {
            return "\nYou are playing as a Dwarf\n";
        }
        public override int DealDamage()
        {
            bool containsAnItem = _equipment.Backpack.Any(x => x is MagicAxe);

            return containsAnItem == false ? _damage + _agility : _damage + _agility + _strength;
        }
    }
}