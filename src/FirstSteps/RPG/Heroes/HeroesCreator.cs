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
        public static Hero Create()
        {

            HeroModel heroModel = HeroesRepository.LoadFromFile();
            Races race = heroModel.Race;

            if (race == Races.Human)
            {
                
                return new Human(heroModel.Name, heroModel.Damage, heroModel.Health, heroModel.Agility, heroModel.CoinsBag, heroModel.Intelligence, heroModel.Strength);
            }
            else if (race == Races.Dwarf)
            {
                
                return new Dwarf(heroModel.Name, heroModel.Damage, heroModel.Health, heroModel.Agility, heroModel.CoinsBag, heroModel.Intelligence, heroModel.Strength);
            }
            else if (race == Races.Elf)
            {
                return new Elf(heroModel.Name, heroModel.Damage, heroModel.Health, heroModel.Agility, heroModel.CoinsBag, heroModel.Intelligence, heroModel.Strength);
            }
            else
            {
                return new Undead(heroModel.Name, heroModel.Damage, heroModel.Health, heroModel.Agility, heroModel.CoinsBag, heroModel.Intelligence, heroModel.Strength);
            }
        }
    }
}