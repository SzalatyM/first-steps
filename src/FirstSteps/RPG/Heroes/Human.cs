using System;
using System.Linq;
using FirstSteps.RPG.Adventures;
using FirstSteps.RPG.Items;
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
        }

        public override int DealDamage()
        {
            Item item = equipment.backpack.FirstOrDefault(
                 item => item.Name == "MagicSword" || item.Name == "Pitchfork" || item.Name == "Knife");

            if (item == null)
            {
                return _damage + _strength;
            }
            return (_damage + _strength) * 2;
        }

        protected override bool CanHandleSpecialItem(Item item)
        {
            return item is MagicSword || item is Pitchfork || item is Knife;
        }
    }
}