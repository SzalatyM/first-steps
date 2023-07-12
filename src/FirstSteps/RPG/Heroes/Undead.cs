using FirstSteps.RPG.Items;
using System.Linq;

namespace FirstSteps.RPG.Heroes
{
    public class Undead : Hero
    {
        public int ManaPoints { get; private set; }

        public Undead(string name) : base(name, Races.Undead)
        {
            _strength = 3;
            _intelligence = 3;
            _agility = 4;
            _health = 22;
            _damage = 8;
            _coinsBag = 0;
        }
        public Undead(string name, int strength, int intelligence, int agility, int health, int damage, int coinsBag) : base(name, Races.Undead)
        {
            _strength = strength;
            _intelligence = intelligence;
            _agility = agility;
            _health = health;
            _damage = damage;
            _coinsBag = coinsBag;
        }
        protected override bool CanHandleSpecialItem(Item item)
        {
            return item is MagicSkull;
        }

        public void ManaIncreases(int mana)
        {
            ManaPoints += mana;
        }

        public override int DealDamage()
        {
            bool magicSkullIsInTheBackpack = _equipment.Backpack.Any(x => x is MagicSkull);

            return magicSkullIsInTheBackpack ? _damage + _intelligence * 2 : _damage + _intelligence;
        }
    }
}