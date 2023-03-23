using System;
using System.Collections.Generic;
using System.Text;

namespace FirstSteps.RPG.Heroes
{
    public class Boss
    {
        public readonly string _name;
        public int Health;
        public int Strength;
        public int Damage;

        public Boss(string name)
        {
            _name = name;         
        }
    }
}
