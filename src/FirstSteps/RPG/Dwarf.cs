using System;
using System.Collections.Generic;
using System.Text;

namespace FirstSteps.RPG
{
    class Dwarf : Hero
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




