using System.Linq;
using FirstSteps.RPG.Items;
using FirstSteps.RPG.HeroesModels;

namespace FirstSteps.RPG.Heroes
{
    public class Human : Hero
    {
        public Human(string name) : this(name, 3, 2, 5, 20, 6, 0, new Equipment())
        {

        }
        private Human(string name, int strength, int intelligence, int agility, int health, int damage, int coinsBag, Equipment equipment) : base(name, Races.Dwarf)
        {
            _strength = strength;
            _intelligence = intelligence;
            _agility = agility;
            _health = health;
            _damage = damage;
            _coinsBag = coinsBag;
            _equipment = equipment;
        }

        public static Human FromHeroModel(HeroModel heroModel)
        {
            string name = heroModel.Name;
            int strength = heroModel.Strength;
            int intelligence = heroModel.Intelligence;
            int agility = heroModel.Agility;
            int health = heroModel.Health;
            int damage = heroModel.Damage;
            int coinsBag = heroModel.CoinsBag;
            Equipment equipment = heroModel.MapToEquipment();

            return new Human(name, strength, intelligence, agility, health, damage, coinsBag, equipment);
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