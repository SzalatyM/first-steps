using System.Linq;
using FirstSteps.RPG.Items;
namespace FirstSteps.RPG.Heroes
{
    public class Human : Hero
    {
        public Human(string name) : base(name, Races.Human)
        {
            _strength = 3;
            _intelligence = 2;
            _agility = 5;
            _health = 20;
            _damage = 6;
        }

        public override int DealDamage()
        {
            bool item = _equipment.Backpack.Any(x => x is MagicSword || x is Pitchfork || x is Knife);
            return item == false ? _damage + _strength : (_damage + _strength) * 2;
        }

        protected override bool CanHandleSpecialItem(Item item)
        {
            return item is MagicSword || item is Pitchfork || item is Knife;
        }
    }
}