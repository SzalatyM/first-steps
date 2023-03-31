
using System.Dynamic;

namespace FirstSteps.RPG.Heroes
{
    public  class Boss : IAttacker
    {
        public string Name;
        public int Health;
        public int Strength;
        public int Damage;

        private Boss()
        {
            
        }

        public static Boss CreateDiablo()
        {      
            return new Boss {Name = "Diablo", Health = 50, Strength = 5, Damage = 6};
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