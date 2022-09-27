using System;

namespace FirstSteps.RPG
{
    public class Hero
    {
        private string _name;
        private Races _race;

        public int strength = 1;
        public int intelligence = 1;
        public int agility = 1;
        public int hp = 100;

        public Hero(string name, Races race)
        {
            _name = name;
            _race = race;
        }

        public void DisplayStats()
        {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine($"Race: {_race}");
            Console.WriteLine($"HP: {hp}");
            Console.WriteLine($"Strength: {strength}, intelligence {intelligence}, agility {agility}");
        }
    }
}