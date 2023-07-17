using FirstSteps.RPG.Items;
using System;
using System.Collections.Generic;
using AutoMapper;

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
                    return new Human(heroModel.Name, heroModel.Strength, heroModel.Intelligence, heroModel.Agility, heroModel.Health, heroModel.Damage, heroModel.CoinsBag);
                case Races.Dwarf:
                    return new Dwarf(heroModel.Name, heroModel.Strength, heroModel.Intelligence, heroModel.Agility, heroModel.Health, heroModel.Damage, heroModel.CoinsBag);
                case Races.Elf:
                    return new Elf(heroModel.Name, heroModel.Strength, heroModel.Intelligence, heroModel.Agility, heroModel.Health, heroModel.Damage, heroModel.CoinsBag);
                case Races.Undead:
                    return new Undead(heroModel.Name, heroModel.Strength, heroModel.Intelligence, heroModel.Agility, heroModel.Health, heroModel.Damage, heroModel.CoinsBag);
                default:
                    throw new NotImplementedException();
            }
        }
        public static Item MapItems(string ItemType)
        {
            switch (ItemType)
            {
                case "MagicSword":
                    return new MagicSword();
                case "MagicAxe":
                    return new MagicAxe();
                case "MagicSkull":
                    return new MagicSkull();
                case "MagicBow":
                    return new MagicBow();
                case "Knife":
                    return new Knife();
                case "Pitchfork":
                    return new Pitchfork();

                default:
                    throw new ArgumentException($"Unknown item type");
            }
        }

    }
}