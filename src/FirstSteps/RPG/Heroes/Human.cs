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
            _coinsBag = 0;                       
        }
        public Human(string name, int strength, int intelligence, int agility, int health, int damage, int coinsBag, Equipment equipment) : base(name, Races.Human)
        {
            _strength = strength;
            _intelligence = intelligence;
            _agility = agility;
            _health = health;
            _damage = damage;
            _coinsBag = coinsBag;
            _equipment = equipment;           
        }

        public override int DealDamage()
        {

            if (_equipment.Backpack.Any(x => x is MagicSword))
            {
                return (_damage + _strength) * 2;
            }
            else if (_equipment.Backpack.Any(x => x is Pitchfork))
            {
                return _damage + _damage;
            }
            else if (_equipment.Backpack.Any(x => x is Knife))
            {
                return _damage + _strength;
            }
            else
            {
                return _damage + _intelligence;
            }
        }
        protected override bool CanHandleSpecialItem(Item item)
        {
            return item is MagicSword || item is Pitchfork || item is Knife;
        }
    }
}