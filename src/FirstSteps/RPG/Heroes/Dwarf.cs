using FirstSteps.RPG.Items;
using FirstSteps.RPG.HeroesModels;
using System.Linq;

namespace FirstSteps.RPG.Heroes
{
    public class Dwarf : Hero
    {

        public Dwarf(string name) : this(name, 4, 2, 4, 25, 7, 0, new Equipment())
        {

        }
        private Dwarf(string name, int strength, int intelligence, int agility, int health, int damage, int coinsBag, Equipment equipment) : base (name, Races.Dwarf)
        {
             _strength = strength;
            _intelligence = intelligence;
            _agility = agility;
            _health = health;
            _damage = damage;
            _coinsBag = coinsBag;
            _equipment = equipment;
        }     

        public static Dwarf FromHeroModel(HeroModel heroModel)
        {
            string name = heroModel.Name;
            int strength = heroModel.Strength;
            int intelligence = heroModel.Intelligence;
            int agility = heroModel.Agility;
            int health = heroModel.Health;
            int damage = heroModel.Damage;
            int coinsBag = heroModel.CoinsBag;
            Equipment equipment = heroModel.MapToEquipment();

            return new Dwarf(name, strength, intelligence, agility, health, damage, coinsBag, equipment);

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