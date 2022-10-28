using FirstSteps.RPG.Items;

namespace FirstSteps.RPG.Heroes
{
    public class Elf : Hero
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
    }
}