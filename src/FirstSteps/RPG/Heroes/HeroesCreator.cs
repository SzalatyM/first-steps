using FirstSteps.RPG.Items;
using FirstSteps.RPG.ModelFiles;
using System;
using System.Collections.Generic;
namespace FirstSteps.RPG.Heroes
{
    public class HeroesCreator
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
        public static Hero LoadFromFile()
        {
            HeroModel heroModel = HeroesRepository.LoadHero();
            Races race = heroModel.Race;

            return race switch
            {
                Races.Human => Human.FromHeroModel(heroModel),
                Races.Dwarf => Dwarf.FromHeroModel(heroModel),
                Races.Elf => Elf.FromHeroModel(heroModel),
                Races.Undead => Undead.FromHeroModel(heroModel),
                _ => throw new NotImplementedException("Something gone wrong"),
            };
        }
    }
}