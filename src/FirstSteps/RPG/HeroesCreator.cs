using System;
using System.Collections.Generic;
using System.Text;

namespace FirstSteps.RPG
{
    class HeroesCreator
    {       
        public static Hero Create(string name, Races race)
        {        
            if (race == Races.Human)
            {
                return new Human(name);
            }
            else if (race == Races.Dwarf)
            {
                return new Dwarf(name);
            }
            else if (race == Races.Elf)
            {
                return new Elf(name);
            }
            else if (race == Races.Undead)
            {
                return new Undead(name);
            }
            else
            {
                Console.WriteLine("Choose a corrent hero");
                return null;
            }
        }
    }  
}
