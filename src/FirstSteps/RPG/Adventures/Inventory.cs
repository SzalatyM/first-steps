using FirstSteps.RPG.Heroes;
using FirstSteps.RPG.Items;
using FirstSteps.RPG.Tools;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstSteps.RPG.Adventures
{
    public class Inventory : IAdventure
    {
        private static List<Item> _inventory = new List<Item>()
        {
            new MagicAxe(),
            new MagicBow(),
            new MagicSkull(),
            new MagicSword()
        };

        public string Command => "Inventory";

        public void Enter(Hero hero)
        {
            try
            {
                foreach (var inventory in _inventory)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Name: {inventory.Name}\nPrice: {inventory.Price} coins");
                    Console.WriteLine();
                }
                Console.WriteLine("Which item u want to buy?\nEnter a name to select");
                string userInput = Console.ReadLine();
                var item = _inventory.FirstOrDefault(item => item.Name == userInput);
                if (item == null)
                {
                    Console.WriteLine("There is no such item to buy!");
                }
                else if (hero.TrySpendCoins(item))
                {
                    hero.AddItemToBackpack(item);
                    _inventory.Remove(item);
                    Console.WriteLine($"You bought a {userInput} ");
                }
                else
                {
                    Console.WriteLine($"You dont have a coins to buy a {userInput} ");
                }
            }
            catch (HeroCantHoldItemException ex) 
            {
                Console.WriteLine(ex.Message);
            }           
        }
    }
}