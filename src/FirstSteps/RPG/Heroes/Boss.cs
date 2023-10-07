

using System;

namespace FirstSteps.RPG.Heroes
{
    public class Boss : IAttacker
    {
        public string Name { get; private set; }
        public int MaxHealth { get; private set; }
        public int Health { get; private set; }
        public int Strength { get; private set; }
        public int Damage { get; private set; }

        private Boss()
        {

        }

        public static Boss CreateDiablo()
        {
            var diablo = new Boss { Name = "Diablo", Health = 40, Strength = 6, Damage = 10 };
            diablo.MaxHealth = diablo.Health;
            return diablo;
        }

        public int DealDamage()
        {
            double healthPercent = (double)Health / MaxHealth;

            double reducedDamage = 1 - healthPercent;

            if(reducedDamage > 0)
            {
                return (int)(Damage * healthPercent);
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