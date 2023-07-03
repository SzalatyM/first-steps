using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;
using FirstSteps.RPG.Items;
namespace FirstSteps.RPG.Heroes
{
    public class Human : Hero
    {
        private HeroModel _heroModel;
        public Human(string name) : base(name, Races.Human)
        {
            _strength = 3;
            _intelligence = 2;
            _agility = 5;
            _health = 20;
            _damage = 6;
        }
        public Human(string name, Races race, int strength, int intelligence, int agility, int health, int damage, int coinsBag) : base(name, Races.Human)
        {
            _heroModel = new HeroModel();
            _heroModel.Name = name;
            _heroModel.Race = race;
            _heroModel.Strength = strength;
            _heroModel.Health = health;
            _heroModel.Damage = damage;
            _heroModel.Intelligence = intelligence;
            _heroModel.Agility = agility;
            _heroModel.CoinsBag = coinsBag;
        }

        public override int DealDamage()
        {

            if (_equipment.Backpack.Any(x => x is MagicSword))
            {
                return (_damage + _strength) * 2; 
            }
            else if(_equipment.Backpack.Any(x => x is Pitchfork))
            {
                return _damage + _damage;
            }
            else if(_equipment.Backpack.Any(x => x is Knife))
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