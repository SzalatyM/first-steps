

using System;

namespace FirstSteps.RPG.Heroes
{
    public class Boss : IAttacker
    {
        public string Name { get; private set; }
        public int Health { get; private set; }
        public int Strength { get; private set; }
        public int Damage { get; private set; }

        private Boss()
        {

        }

        public static Boss CreateDiablo()
        {
            return new Boss { Name = "Diablo", Health = 40, Strength = 6, Damage = 6 };
        }

        public int DealDamage()
        {           
            return Damage;       
            // i tryed make a logic with reduced damage here but not working. 
        }

        public int TakeDamage(int damage)
        {
            return Health -= damage;          
        }
    }
}