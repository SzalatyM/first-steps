using FirstSteps.RPG.Heroes;
using FirstSteps.RPG.Items;
using FirstSteps.RPG.Tools;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;

namespace FirstSteps.RPG.Adventures
{
    public class Hell
    {
        public void FightWithboss(Hero hero)
        {
            Boss boss = new Boss("Diablo")
            {
                Health = 40,
                Damage = 7,
                Strength = 5,

            };
            Display.DefaultText($"You entered to the Hell!\nIf u wanna fight with {boss._name} press 'f' otherwise go back to previous menu ");
            Display.ErrorText("Boss stats:");
            Display.ItemText($"\n Health = {boss.Health}\n Damage = {boss.Damage}\n Strenght = {boss.Strength}");


            Console.WriteLine("Press 'z' to hit or run away press 'y'");
            while (boss.Health >= 0)
            {
                var userInput = Console.ReadLine();
                if (userInput == "z")
                {
                    Console.WriteLine("u hit the boss ");
                    boss.Health -= hero.DealDamage();
                    Console.WriteLine(boss.Health);
                }
                if (userInput == "y")
                {
                    Console.WriteLine("You ran away");
                }
            }
            Console.WriteLine("Boss died! You receive a 100 coins");
            hero.AddCoins(100);      
        }
    }
}

