using FirstSteps.RPG.Heroes;
using FirstSteps.RPG.Items;
using System.Collections.Generic;

namespace FirstSteps.RPG.HeroesModels
{
    public class HeroModel
    {
        public string Name { get; set; }
        public Races Race { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public int Agility { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }
        public int CoinsBag { get; set; }
        public EquipmentModel Equipment { get; set; }
    }
}