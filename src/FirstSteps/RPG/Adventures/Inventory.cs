using FirstSteps.RPG.Heroes;
using FirstSteps.RPG.Items;
using FirstSteps.RPG.Tools;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstSteps.RPG.Adventures
{
    public class Inventory
    {
        private static List<Item> _inventory = new List<Item>()
        {
            new MagicAxe(),
            new MagicBow(),
            new MagicSkull(),
            new MagicSword()
        };
        public void ShowItems(Hero _hero)
        {           
            string userInput = AnsiConsole.Prompt(
                  new SelectionPrompt<string>()
                      .Title("\nWhich item u want to buy?: ")
                      .AddChoices("MagicAxe", "MagicBow", "MagicSkull", "MagicSword"));

            var item = _inventory.FirstOrDefault(item => item.Name == userInput);

            if (item == null)
            {
                Console.WriteLine("There is no such item to buy!");
            }
            else if (_hero.TrySpendCoins(item))
            {
                 Display.ItemText($"You bought a {userInput} ");
                _hero.AddItemToBackpack(item);
                _inventory.Remove(item);
            }
            else
            {
                Console.WriteLine($"You dont have a coins to buy a {userInput} ");
            }
        }
    }
}