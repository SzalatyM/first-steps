using FirstSteps.RPG.Items;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstSteps.RPG.Heroes
{
    public class Elf : Hero, IGreeting
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

        public string Greed()
        {
            return "\nYou are playing as a Elf\n";
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
            Item item = equipment.backpack.FirstOrDefault(
                 item => item.Name == "MagicBow");

            if (item == null)
            {
                return _damage + _agility;
            }
            return _agility * 4;
        }
    }
}