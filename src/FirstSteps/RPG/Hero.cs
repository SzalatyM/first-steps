using System;

namespace FirstSteps.RPG
{
    public class Hero
    {
        private string _name;
        public Races _race;
        public int _strength;
        public int _intelligence;
        public int _agility;

        public Hero(string name, Races race)
        {
            _name = name;
            _race = race;
        }

        public void DisplayStats()
        {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine($"Race: {_race}");
            Console.WriteLine($"Strength: {_strength}, intelligence {_intelligence}, agility {_agility}");
        }
    }
}