﻿using FirstSteps.RPG.Items;
using System;
using System.Collections.Generic;

namespace FirstSteps.RPG.Heroes
{
    public class Human : Hero
    {     
        public Human(string name) : base(name, Races.Human)
        {
            _strength = 3;
            _intelligence = 2;
            _agility = 5;
            _health = 20;
            _damage = 6;
        }

        protected override bool CanHandleSpecialItem(Item item)
        {
            return item is MagicSword;
        }
    }
}

