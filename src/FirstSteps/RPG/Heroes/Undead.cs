using FirstSteps.RPG.Items;
using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;

namespace FirstSteps.RPG.Heroes
{
    public class Undead : Hero
    {
       private HeroModel _heroModel;
        public int ManaPoints { get; private set; }

        public Undead(string name) : base(name, Races.Undead)
        {
            _strength = 3;
            _intelligence = 3;
            _agility = 4;
            _health = 22;
            _damage = 8;
        }
        public Undead(string name, Races race, int strength, int intelligence, int agility, int health, int damage, int coinsBag) : base(name, Races.Undead)
        {
            _heroModel = new HeroModel();
            _heroModel.Name = name;
            _heroModel.Race = race;
            _heroModel.Strength = strength; 
            _heroModel.Intelligence = intelligence;
            _heroModel.Agility = agility;
            _heroModel.Health = health;
            _heroModel.Damage = damage;
            _heroModel.CoinsBag = coinsBag;            
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