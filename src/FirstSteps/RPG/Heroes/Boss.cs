using System;
using System.Collections.Generic;
using System.Text;

namespace FirstSteps.RPG.Heroes
{
    public class Boss
    {
        public string Name { get { return _name; } }
        private string _name;
        private int _health;
        public int Health {get { return _health;}}
        private int _strength;
        public int Strength { get { return _strength;}}
        private int _damage;
        public int Damage { get { return _damage;}}

        public Boss(string name, int health, int strength, int damage)
        {
            _name = name;
            _health = health;
            _strength = strength;

            _damage = damage;
        }
    }
}
