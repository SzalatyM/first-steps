
using System.Dynamic;

namespace FirstSteps.RPG.Heroes
{
    public class Boss : IAttacker
    {
        public string Name { get { return _name; } }
        private string _name;
        public int Health { get { return _health; } }
        private int _health;
        public int Strength { get { return _strength; } }
        private int _strength;
        public int Damage { get { return _damage; } }
        private int _damage;


        private Boss()
        {

        }

        public static Boss CreateDiablo()
        {
            return new Boss { _name = "Diablo", _health = 50, _strength = 5, _damage = 6 };
        }

        public int DealDamage()
        {
            return Damage + Strength;
        }
        public int TakeDamage(int damage)
        {

            return _health -= damage;
        }
    }
}