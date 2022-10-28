using FirstSteps.RPG.Items;

namespace FirstSteps.RPG.Heroes
{
    public class Dwarf : Hero
    {
        public Dwarf(string name) : base(name, Races.Dwarf)
        {
            _strength = 4;
            _intelligence = 2;
            _agility = 4;
            _health = 140;
            _damage = 28;
        }
        
        protected override bool CanHandleSpecialItem(Item item)
        {
            return item is MagicAxe;
        }
    }
}