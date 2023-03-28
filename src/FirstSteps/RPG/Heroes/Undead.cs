using FirstSteps.RPG.Items;
using System.Linq;

namespace FirstSteps.RPG.Heroes
{
    public class Undead : Hero, IGreeting
    {
        public int ManaPoints { get; private set; }

        public Undead(string name) : base(name, Races.Undead)
        {
            _strength = 3;
            _intelligence = 3;
            _agility = 4;
            _health = 22;
            _damage = 8;
        }

        protected override bool CanHandleSpecialItem(Item item)
        {
            return item is MagicSkull;
        }

        public void ManaIncreases(int mana)
        {
            ManaPoints += mana;
        }

        public string Greed()
        {
            return "\nYou are playing as a Undeed\n";
        }

        public override int DealDamage()
        {
            bool containsAnItem = _equipment.Backpack.Any(x => x is MagicSkull);
            return containsAnItem == false ? _damage + _intelligence : _damage + _intelligence * 2;
        }
    }
}