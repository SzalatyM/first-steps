using System;
using System.Collections.Generic;
using System.Text;

namespace FirstSteps.RPG
{
    class Undead : Hero
    {
        public Undead(string name) : base(name, Races.Undead)
        {
            _strength = 3;
            _intelligence = 3;
            _agility = 4;
            _health = 130;
            _damage = 21;
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
