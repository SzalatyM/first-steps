
using System.Dynamic;

namespace FirstSteps.RPG.Heroes
{
    public class Boss : IAttacker
    {
        public string Name { get { return _name; } }
        private string _name;
        public int Health { get; set; }
        public int Strength { get; set; }

        public int Damage { get; set; }


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