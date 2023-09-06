using FirstSteps.RPG.Items;
using FirstSteps.RPG.HeroesModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstSteps.RPG.Heroes
{
    public class Elf : Hero
    {
        private List<Arrow> _arrowsBag = new List<Arrow>();

        public Elf(string name) : this(name, 3, 2, 5, 21, 9, 0, new Equipment())
        {

        }
        private Elf(string name, int strength, int intelligence, int agility, int health, int damage, int coinsBag, Equipment equipment) : base(name, Races.Elf)
        {
            _strength = strength;
            _intelligence = intelligence;
            _agility = agility;
            _health = health;
            _damage = damage;
            _coinsBag = coinsBag;
            _equipment = equipment;
        }

        public static Elf FromHeroModel(HeroModel heroModel)
        {
            string name = heroModel.Name;
            int strength = heroModel.Strength;
            int intelligence = heroModel.Intelligence;
            int agility = heroModel.Agility;
            int health = heroModel.Health;
            int damage = heroModel.Damage;
            int coinsBag = heroModel.CoinsBag;
            Equipment equipment = heroModel.MapToEquipment();

            return new Elf(name, strength, intelligence, agility, health, damage, coinsBag, equipment);

        }

        protected override bool CanHandleSpecialItem(Item item)
        {
            return item is MagicBow;
        }

        public void Heal()
        {
            _health += _health + 10;
            Console.WriteLine("U gain 10hp!");
        }

        public void CollectArrows(List<Arrow> arrows)
        {

            _equipment.Backpack.AddRange(arrows.ToList());
            _arrowsBag.AddRange(arrows);
        }

        public override int DealDamage()
        {

            bool magicBowIsInTheBackpack = _equipment.Backpack.Any(x => x is MagicBow);
            bool arrowsAreInTheBackpack = _equipment.Backpack.Any(y => y is Arrow);

            if (magicBowIsInTheBackpack && arrowsAreInTheBackpack)
            {
                var arrows = _equipment.Backpack.OfType<Arrow>().FirstOrDefault();

                if (arrows != null)
                {
                    _equipment.Backpack.Remove(arrows);
                    return _agility * 4;
                }
            }
            return _agility; 
        }
    }
}