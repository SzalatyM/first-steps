﻿using FirstSteps.RPG.Heroes;

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