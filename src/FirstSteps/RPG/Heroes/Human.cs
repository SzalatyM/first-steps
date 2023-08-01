using System.Linq;
using System.Xml.Linq;
using FirstSteps.RPG.Heroes;
using FirstSteps.RPG.Items;
using FirstSteps.RPG.ModelFiles;

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

        private static Human NewHuman( string name, int strength, int intelligence, int agility, int health, int damage, int coinsBag, Equipment equipment)
        {
            return new Human(name, strength, intelligence, agility, health, damage, coinsBag, equipment);
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

            return NewHuman(name, strength, intelligence, agility, health, damage, coinsBag, equipment);
        }
    }
}