using FirstSteps.RPG.Items;

namespace FirstSteps.RPG.Heroes
{
    public class Dwarf : Hero, IGreeting
    {
        public Dwarf(string name) : base(name, Races.Dwarf)
        {
            _strength = 4;
            _intelligence = 2;
            _agility = 4;
            _health = 25;
            _damage = 7;
        }

        protected override bool CanHandleSpecialItem(Item item)
        {
            return item is MagicAxe;
        }

        public string Greed()
        {
            return "\nYou are playing as a Dwarf\n";
        }
        public override int DealDamage()
        {
            throw new System.NotImplementedException();
        }
    }
}