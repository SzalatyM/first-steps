﻿using FirstSteps.RPG.Items;
using System;

namespace FirstSteps.RPG.Heroes
{
    public class Dwarf : Hero, IGreeting
    {
        public Dwarf(string name) : base(name, Races.Dwarf)
        {
            _strength = 4;
            _intelligence = 2;
            _agility = 4;
            _health = 140;
            _damage = 28;
        }

        protected override bool CanHandleSpecialItem(Item item)
        {
            return item is MagicAxe;
        }

        public string Greed()
        {
            return "\nYou are playing as a Dwarf\n";
        }
    }
}