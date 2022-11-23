using FirstSteps.RPG.Items;
using System.Linq;
using System.Collections.Generic;
namespace FirstSteps.RPG.Heroes
{
    public class Undead : Hero
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
    }
}