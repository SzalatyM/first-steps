
using System.Dynamic;

namespace FirstSteps.RPG.Heroes
{
    public class Boss : IAttacker
    {
        private string _name;
        public int Health { get; private set; }
        public int Strength { get; private set; }
        public int Damage { get; private set; }


        private Boss()
        {

        }

        public static Boss CreateDiablo()
        {
            return new Boss { _name = "Diablo", Health = 50, Strength = 5, Damage = 6 };
        }

        public int DealDamage()
        {
            return Damage + Strength;
        }
        public int TakeDamage(int damage)
        {

            return Health -= damage;
        }
    }
}