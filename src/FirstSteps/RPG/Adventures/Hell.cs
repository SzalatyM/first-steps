using FirstSteps.RPG.Heroes;
using FirstSteps.RPG.Tools;
using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices.WindowsRuntime;

namespace FirstSteps.RPG.Adventures
{
    public class Hell
    {
        public void FightWithboss(Hero hero)
        {
            Boss boss = new Boss("Diablo")
            {
                Health = 55,
                Damage = 6,
                Strength = 4,
            };
            Display.DefaultText($"You entered to the Hell!\nIf u wanna fight with {boss._name} press 'f' otherwise go back to previous menu ");
            Display.ErrorText("Boss stats:");
            Display.ItemText($"\n Health = {boss.Health}\n Damage = {boss.Damage}\n Strenght = {boss.Strength}");

            Display.WarningText("Press 'hit' to try to  hit a boss or run away press 'run'");

            try
            {

                while (boss.Health >= 0)
                {
                    var userInput = Console.ReadLine();
                    switch (userInput)
                    {
                        case "hit":
                            var number = new Random().Next(1, 4);
                            Console.WriteLine($"You rolled {number}");
                            if (number >= 1)
                            {
                                boss.Health -= hero.DealDamage();
                                Display.ErrorText($"You deal  {hero.DealDamage()} to boss!");
                                Display.DefaultText($"Actually health boss: {boss.Health}");
                            }
                            else
                            {
                                hero.Health -= boss.DealDamage();
                                Display.ErrorText($"Boss deal {boss.Damage} to Hero!");
                                Display.DefaultText($"you have actually {hero.Health}");
                            }
                            break;
                        case "run":
                            Display.ErrorText("You ran away");
                            return;
                    }
                    if (hero.Health <= 0)
                    {
                        Display.ErrorText("You died! Game over");
                        break;
                    }
                }

                Display.ItemText("Boss died! You receive a 100 coins");
                hero.AddCoins(100);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Wrong type");
            }
        }

    }
}