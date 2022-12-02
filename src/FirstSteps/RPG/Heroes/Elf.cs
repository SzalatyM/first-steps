using FirstSteps.RPG.Items;
using System;
using System.Collections.Generic;


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
            _health = 120;
            _damage = 20;
        }

        protected override bool CanHandleSpecialItem(Item item)
        {
            return item is MagicBow;
        }

        public string Greed()
        {
            return "Im Elf";
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
    }
}
