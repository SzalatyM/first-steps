using FirstSteps.RPG.Items;
using System;
using System.Collections.Generic;
using AutoMapper;
using System.Security.Cryptography.X509Certificates;
using System.Linq;
using System.Xml.Linq;
using System.Reflection.Metadata.Ecma335;

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
            EquipmentModel equipment = new EquipmentModel();

            switch (race)
            {
                case Races.Human:
                    return new Human(heroModel.Name, heroModel.Strength, heroModel.Intelligence, heroModel.Agility, heroModel.Health, heroModel.Damage, heroModel.CoinsBag, MapEquipment(equipment));
                case Races.Dwarf:
                    return new Dwarf(heroModel.Name, heroModel.Strength, heroModel.Intelligence, heroModel.Agility, heroModel.Health, heroModel.Damage, heroModel.CoinsBag, heroModel.Equipment);
                case Races.Elf:
                    return new Elf(heroModel.Name, heroModel.Strength, heroModel.Intelligence, heroModel.Agility, heroModel.Health, heroModel.Damage, heroModel.CoinsBag, heroModel.Equipment);
                case Races.Undead:
                    return new Undead(heroModel.Name, heroModel.Strength, heroModel.Intelligence, heroModel.Agility, heroModel.Health, heroModel.Damage, heroModel.CoinsBag, heroModel.Equipment);
                default:
                    throw new NotImplementedException();

            }
        }
        private static Equipment MapEquipment(EquipmentModel equipmentModel)
        {
            Equipment equipment = new Equipment();

            if (equipmentModel.Items != null)
            {
                foreach (var itemModel in equipmentModel.Items)
                {
                    foreach (var item in itemModel.ItemList)
                    {
                        Item mappedItem = MapItem();
                        equipment.TryAddItemToBackpack(mappedItem);
                        Console.WriteLine(item);
                    }
                }
            }

            return equipment;
        }

        private static Item MapItem(ItemModel itemModel)
        {
            List<Item> item = itemModel.ItemList;
            return new Item(item => item is MagicAxe);
        }
    }
}