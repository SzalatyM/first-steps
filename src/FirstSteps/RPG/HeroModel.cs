using FirstSteps.RPG.Heroes;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstSteps.RPG
{
    public class HeroModel
    {       
        public string _name { get; set; }
        public Races _race { get; set; }
        public int _strength { get; set; }
        public int _intelligence { get; set; }
        public int _agility { get; set; }
        public int _health { get; set; }
        public int _damage { get; set; }
        public int _coinsBag { get; set; }
    }
}
