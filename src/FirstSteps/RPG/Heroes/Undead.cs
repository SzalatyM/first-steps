using FirstSteps.RPG.Items;
namespace FirstSteps.RPG.Heroes
{
    public class Undead : Hero, IGreeting
    {
        private int _manaPoints;

        public Undead(string name) : base(name, Races.Undead)
        {
            _strength = 3;
            _intelligence = 3;
            _agility = 4;
            _health = 130;
            _damage = 21;
        }

        protected override bool CanHandleSpecialItem(Item item)
        {
            return item is MagicSkull;
        }
        public void ManaIncreases(int mana)
        {
            _manaPoints = _manaPoints + mana;
        }
        public string Greed()
        {
            return "\nYou are playing as a Undeed\n";
        }
    }
}