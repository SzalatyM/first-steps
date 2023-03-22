using FirstSteps.RPG.Heroes;
using FirstSteps.RPG.Items;
using FirstSteps.RPG.Tools;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace FirstSteps.RPG.Adventures
{
    public  class Hell
    {
        HeroesDamage heroes = new HeroesDamage();
        public void FightWithboss(Hero hero)
        {
            Boss boss = new Boss("Diablo", 40, 5, 7);
            Display.DefaultText($"You entered to the Hell!\nIf u wanna fight with {boss.Name} press 'f' otherwise go back to previous menu ");
            Display.ErrorText("Boss stats:");
            Display.ItemText($"\n Health = {boss.Health}\n Damage = {boss.Damage}\n Strenght = {boss.Strength}");


            Console.WriteLine("Press 'z' to hit or run away press 'y'");
            while (true)
            {
                var userInput = Console.ReadLine();
                if (userInput == "z")
                {
                    Console.WriteLine("u hit the boss ");
                    heroes.Damage(hero, boss);
     
                   
                }
                else if (userInput == "y")
                {
                    Console.WriteLine("u run ");
                    break;
                }
                else
                {
                    Console.WriteLine("xDDD");
                }
            }
        }
    }
}
            
        