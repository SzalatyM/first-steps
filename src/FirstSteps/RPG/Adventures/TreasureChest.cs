using FirstSteps.RPG.Heroes;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstSteps.RPG.Adventures
{
    public class TreasureChest : IAdventure
    {
        public string Command => "Treasure Chest";

        public void Enter(Hero hero)
        {

        }
 
        public void Treasure(Hero hero)
        {
            var drawCoins = new Random().Next(1, 25);
            hero.AddCoins(drawCoins);
            Console.WriteLine($"You opened the treasure chest! You get {drawCoins} coins");
        }
    }
}
