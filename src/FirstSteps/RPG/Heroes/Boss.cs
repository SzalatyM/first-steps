

using System;

namespace FirstSteps.RPG.Heroes
{
    public class Boss : IAttacker
    {
        public string Name { get; private set; }
        public int MaxHealth { get ; private set; }
        public int Health { get; private set; }
        public int Strength { get; private set; }
        public int Damage { get; private set; }

        private Boss()
        {

        }

        public static Boss CreateDiablo()
        {
            var diablo = new Boss { Name = "Diablo", Health = 40, Strength = 6, Damage = 6 };
            diablo.MaxHealth = diablo.Health;
            return diablo;
        }

        public int DealDamage()
        {
            double healthPercent = (double)Health / MaxHealth;

            if (healthPercent <= 0.7)
            {
                double reducedDamage = 0.7;
                return (int)(Damage * reducedDamage);
            }
            else
            {
                return Damage;
            }
        }     
        public int TakeDamage(int damage)
        {
            return Health -= damage;          
        }
    }
}