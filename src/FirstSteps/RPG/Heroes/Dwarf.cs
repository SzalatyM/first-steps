using FirstSteps.RPG.Items;
using System.Linq;

namespace FirstSteps.RPG.Heroes
{
    public class Dwarf : Hero
    {
       private HeroModel _heroModel;
        public Dwarf(string name) : base(name, Races.Dwarf)
        {
            _strength = 4;
            _intelligence = 2;
            _agility = 4;
            _health = 25;
            _damage = 7;
        }
        public Dwarf(string name, Races race, int strength, int intelligence, int agility, int health, int damage, int coinsBag) : base(name, Races.Dwarf)
        {
            _heroModel = new HeroModel
            {
                Name = name,
                Race = race,
                Strength = strength,
                Health = health,
                Damage = damage,
                Intelligence = intelligence,
                Agility = agility,
                CoinsBag = coinsBag
            };
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