
namespace FirstSteps.RPG.Heroes
{
    public class Boss : IHeroesDamage
    {
        public readonly string _name;
        public int Health;
        public int Strength;
        public int Damage;

        public Boss(string name)
        {
            _name = name;
        }

        public int DealDamage()
        {
            return Damage + Strength;
        }
    }
}