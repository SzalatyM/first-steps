using FirstSteps.RPG.Items;
using System;

namespace FirstSteps.RPG.Heroes
{
    public class Elf : Hero, IGreeting
    {

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
    }
}