using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstSteps.RPG
{
    
    public class Hero
    {
      private List<Item> backPack = new List<Item>();
        

        private string _name;
        public Races _race;
        public int _strength;
        public int _intelligence;
        public int _agility;
        public int _health;
        public int _Damage;
        
        

        public Hero(string name, Races race)
        {
            _name = name;
            _race = race;

            if (_race == Races.Human)
            {
                _strength = 5;
                _intelligence = 3;
                _agility = 2;
                _health = 120;
                _Damage = 22;
            }
            else if (_race == Races.Dwarf)
            {
                _strength = 7;
                _intelligence = 2;
                _agility = 1;
                _health = 200;
                _Damage = 30;
            }
            else if (_race == Races.Elf)
            {
                _strength = 2;
                _intelligence = 3;
                _agility = 5;
                _health = 130;
                _Damage = 20;
            }
            else if (_race == Races.Undead)
            {
                _strength = 3;
                _intelligence = 5;
                _agility = 2;
                _health = 150;
                _Damage = 18;
            }
            else
            {
                Console.WriteLine("Select a correct hero!");
            }

        }

        public void DisplayStats()
        {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine($"Race: {_race}");
            Console.WriteLine($"Strength: {_strength} \nIntelligence: {_intelligence} \nAgility: {_agility} \nHealth: {_health} \nDamage: {_Damage}\n");
            Console.WriteLine($"Equipment: total price: {DisplayTotalPrice()}\ntotal items: {DisplayTotalItems()} ");
        }
        public void AddItemToBackpack(Item item)
        {
            backPack.Add(item);

            
        }

        private string DisplayTotalPrice()
        {
            int totalPrice = 0;

            foreach(Item item in backPack)
            {
                totalPrice += item.Price;               
            }
            return totalPrice.ToString();
        }   
        private string DisplayTotalItems()
        {
            string totalItems = " ";

            foreach(Item item in backPack)
            {
                totalItems += item.Name + " ";
            }
            return totalItems;
        }
    }
    
}     
