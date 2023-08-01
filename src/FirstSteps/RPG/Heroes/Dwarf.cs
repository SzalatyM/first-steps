using FirstSteps.RPG.Items;
using FirstSteps.RPG.ModelFiles;
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
            _coinsBag = 0;
        }
        private static Dwarf NewDwarf(string name, int strength, int intelligence, int agility, int health, int damage, int coinsBag, Equipment equipment)
        {
            return NewDwarf(name, strength, intelligence, agility, health, damage, coinsBag, equipment);
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

            return NewDwarf(name, strength, intelligence, agility, health, damage, coinsBag, equipment);
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