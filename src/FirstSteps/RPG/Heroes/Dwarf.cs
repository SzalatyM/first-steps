using FirstSteps.RPG.Items;
using System.Linq;

namespace FirstSteps.RPG.Heroes
{
    public class Dwarf : Hero
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

        public override int DealDamage()
        {
            bool magicAxeIsInTheBackpack = _equipment.Backpack.Any(x => x is MagicAxe);

            return magicAxeIsInTheBackpack ? _damage + _agility + _strength : _damage + _agility;
        }
    }
}