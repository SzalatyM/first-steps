using FirstSteps.RPG.Items;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstSteps.RPG.Heroes
{
    public class Elf : Hero
    {
        private List<Arrow> _arrowsBag = new List<Arrow>();

        public Elf(string name) : base(name, Races.Elf)
        {
            _strength = 3;
            _intelligence = 2;
            _agility = 5;
            _health = 21;
            _damage = 9;
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
            _arrowsBag.AddRange(arrows);
        }

        public override int DealDamage()
        {
            bool magicBowIsInTheBackpack = _equipment.Backpack.Any(x => x is MagicBow);

            return magicBowIsInTheBackpack ? _agility * 4 : _damage + _agility;
        }
    }
}