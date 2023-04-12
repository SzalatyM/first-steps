using FirstSteps.RPG.Heroes;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstSteps.RPG.Adventures
{
    public class TreasureChest
    {
        public void Treasure(Hero _hero)
        {
            var drawCoins = new Random().Next(1, 25);
            _hero.AddCoins(drawCoins);
            Console.WriteLine($"You opened the treasure chest! You get {drawCoins} coins");
        }
    }
}