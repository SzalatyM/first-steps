using System;

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
            switch (race)
            {
                case Races.Human:
                    return new Human(heroModel.Name, heroModel.Damage, heroModel.Health, heroModel.Agility, heroModel.CoinsBag, heroModel.Intelligence, heroModel.Strength);
                case Races.Dwarf:
                    return new Dwarf(heroModel.Name, heroModel.Damage, heroModel.Health, heroModel.Agility, heroModel.CoinsBag, heroModel.Intelligence, heroModel.Strength);
                case Races.Elf:
                    return new Elf(heroModel.Name, heroModel.Damage, heroModel.Health, heroModel.Agility, heroModel.CoinsBag, heroModel.Intelligence, heroModel.Strength);
                case Races.Undead:
                    return new Undead(heroModel.Name, heroModel.Damage, heroModel.Health, heroModel.Agility, heroModel.CoinsBag, heroModel.Intelligence, heroModel.Strength);
                default:
                    throw new NotImplementedException();
            }            
        }
    }
}