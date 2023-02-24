using System;
using System.Collections.Generic;
using FirstSteps.RPG.Items;
using Spectre.Console;

namespace FirstSteps.RPG.Heroes
{
    public abstract class Hero
    {
        private Equipment _equipment;
        private string _name;
        private Races _race;
        protected int _strength;
        protected int _intelligence;
        protected int _agility;
        protected int _health;
        protected int _damage;   
        public Hero(string name, Races race)
        {
            _equipment = new Equipment(); // i found a similar example i thnk on stackoverflow. can i do it some other way? with variable. Can u show me other example/ solution? 
            _name = name;
            _race = race;
        }
        public Equipment GetEquipment()
        {
            return _equipment; 
        }
        public void DisplayStats()
        {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine($"Race: {_race}");
            AnsiConsole.Write(new BarChart()
            .Width(60)
            .Label($"[blue bold underline] {_race}: {_name} [/]")
            .CenterLabel()
            .AddItem("Strength", _strength, Color.Orange1)
            .AddItem("Intelligence", _intelligence, Color.Blue)
            .AddItem("Agility", _agility, Color.Yellow)
            .AddItem("Health", _health, Color.Red)
            .AddItem("Damage", _damage, Color.Green));
            Console.WriteLine($"Equipment:\ntotal price: {_equipment.DisplayTotalPrice()}\ntotal items: {_equipment.DisplayTotalItems()}\ntotal weight; {_equipment.DisplayTotalWeight()} ");
        }      
        }
    }
