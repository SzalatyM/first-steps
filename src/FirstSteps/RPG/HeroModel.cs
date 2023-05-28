using FirstSteps.RPG.Heroes;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstSteps.RPG
{
    public class HeroModel
    {
        
        public string _name;
        public Races _race;
         public int _strength;
        public int _intelligence;
        public int _agility;
        protected int _health;
        public int Health { get { return _health; } }
        protected int _damage;
        private int _coinsBag;
        public int Coins { get { return _coinsBag; } set { _coinsBag = value; } }

    }
}
