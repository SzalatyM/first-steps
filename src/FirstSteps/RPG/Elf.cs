﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FirstSteps.RPG
{
        class Elf : Hero
    {
        public Elf(string name) : base(name, Races.Elf)
        {
            _strength = 3;
            _intelligence = 2;
            _agility = 5;
            _health = 120;
            _damage = 20;
        }
        protected override bool CanHandleSpecialItem(Item item)
        {
            if (item is MagicAxe)
            {
                return true;
            }
            else
            {
                Console.WriteLine("U can't carry this item");
                return false;
            }
        }
    }
}
