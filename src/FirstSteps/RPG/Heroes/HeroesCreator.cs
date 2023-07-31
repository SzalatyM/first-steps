using FirstSteps.RPG.Items;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;

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
                    return new Human(heroModel.Name, heroModel.Strength, heroModel.Intelligence, heroModel.Agility, heroModel.Health, heroModel.Damage, heroModel.CoinsBag, MapEquipment(heroModel.Equipment.Items));
                case Races.Dwarf:
                    return new Dwarf(heroModel.Name, heroModel.Strength, heroModel.Intelligence, heroModel.Agility, heroModel.Health, heroModel.Damage, heroModel.CoinsBag, MapEquipment(heroModel.Equipment.Items));
                case Races.Elf:
                    return new Elf(heroModel.Name, heroModel.Strength, heroModel.Intelligence, heroModel.Agility, heroModel.Health, heroModel.Damage, heroModel.CoinsBag, MapEquipment(heroModel.Equipment.Items));
                case Races.Undead:
                    return new Undead(heroModel.Name, heroModel.Strength, heroModel.Intelligence, heroModel.Agility, heroModel.Health, heroModel.Damage, heroModel.CoinsBag, MapEquipment(heroModel.Equipment.Items));
                default:
                    throw new NotImplementedException();

            }
        }
        private static Item MapItem(string itemModel)
        {
            switch (itemModel)
            {
                case "MagicAxe":
                    return new MagicAxe();
                case "MagicBow":
                    return new MagicBow();
                case "MagicSword":
                    return new MagicSword();
                case "MagicSkull":
                    return new MagicSkull();
                case "Arrow":
                    return new Arrow();
                case "Knife":
                    return new Knife();
                case "Pitchfork":
                    return new Pitchfork();
                default:
                    throw new ArgumentException("Nieznany typ przedmiotu: " + itemModel);
            }
        }
        private static Equipment MapEquipment(List<ItemModel> itemModels)
        {
            Equipment equipment = new Equipment();

            foreach (ItemModel itemModel in itemModels)
            {
                Item item = MapItem(itemModel.Name);
                equipment.TryAddItemToBackpack(item);
            }
            return equipment;
        }
    }
}