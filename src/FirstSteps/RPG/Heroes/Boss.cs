
using System.Dynamic;

namespace FirstSteps.RPG.Heroes
{
    public  class Boss : IAttacker
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Strength { get; set; }
        public int Damage { get; set; }

        public Boss()
        {
            
        }

        public static Boss CreateDiablo(string name, int health, int strength, int damage )
        {      
            return new Boss { Name = name, Health = health, Strength = strength, Damage = damage };
        }
       
        public int DealDamage()
        {
            return Damage + Strength;
        }
    }
}