using System;
using System.Collections.Generic;
using System.Text;

namespace FirstSteps.RPG
{
    class Undead : Hero
    {
        public Undead(string name) :base(name, Races.Undead)
        {
            _strength = 3;
            _intelligence = 3;
            _agility = 4;
            _health = 130;
            _damage = 21;

        }
    }
}
