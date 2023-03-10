using FirstSteps.RPG.Heroes;
using FirstSteps.RPG.Items;
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
                else if (_hero.TrySpendCoins(item))
                {
                    _hero.AddItemToBackpack(item);
                    _inventory.Remove(item);
                    Console.WriteLine($"You bought a {userInput} ");
                }
                else
                {
                    Console.WriteLine($"You dont have a coins to buy a {userInput} ");
                }
            }
            catch (HandlingItemException ex) 
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}