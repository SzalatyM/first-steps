using System;
using System.Runtime.InteropServices.WindowsRuntime;

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
            Hero hero;
            Races race = heroModel.Race;

            if (race == Races.Human)
            {                
                return hero = new Human(heroModel.Name, heroModel.Damage, heroModel.Health, heroModel.Agility, heroModel.CoinsBag, heroModel.Intelligence, heroModel.Strength);
            }
            else if (race == Races.Dwarf)
            {
                return hero = new Dwarf(heroModel.Name, heroModel.Damage, heroModel.Health, heroModel.Agility, heroModel.CoinsBag, heroModel.Intelligence, heroModel.Strength);
            }
            else if (race == Races.Elf)
            {
                return hero = new Elf(heroModel.Name, heroModel.Damage, heroModel.Health, heroModel.Agility, heroModel.CoinsBag, heroModel.Intelligence, heroModel.Strength);
            }
            else
            {
                return hero = new Undead(heroModel.Name, heroModel.Damage, heroModel.Health, heroModel.Agility, heroModel.CoinsBag, heroModel.Intelligence, heroModel.Strength);
            }
        }
    }
}