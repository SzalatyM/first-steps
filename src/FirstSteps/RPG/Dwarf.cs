using System;
using System.Collections.Generic;
using System.Text;

namespace FirstSteps.RPG
{
    class Dwarf : Hero
    {
        public Dwarf(string name) :base(name, Races.Dwarf) 
        {
            _strength = 4;
            _intelligence = 2;
            _agility = 4;
            _health = 140;
            _damage = 28;
        }
        }
    }

