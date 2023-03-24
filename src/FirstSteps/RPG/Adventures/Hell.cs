using FirstSteps.RPG.Heroes;
using FirstSteps.RPG.Tools;
using Spectre.Console;
using System;

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
            Display.DefaultText($"You entered to the Hell!");

            while (boss.Health >= 0)
            {
                string userInput = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                      .Title($" \nChose what u want to do! {Emoji.Known.CrossedSwords}")
                      .AddChoices("Boss stats", "Hit the boss!", "Run"));

                switch (userInput)
                {
                    case "Hit the boss!":
                        var number = new Random().Next(1, 6);
                        Console.WriteLine($"You rolled {number}");
                        if (number >= 2)
                        {
                            boss.Health -= hero.DealDamage();
                            Display.ErrorText($"You deal {hero.DealDamage()} damage to boss!");
                            Display.DefaultText($"Actually health boss: {boss.Health}");
                        }
                        else
                        {
                            //  hero.Health -= boss.DealDamage(); HERE Is problem ;)
                            Display.ErrorText($"Boss deal {boss.Damage} damage to Hero!");
                            Display.DefaultText($"You currently have { hero.Health} hp");
                        }
                        break;
                    case "Run":
                        Display.ErrorText("You ran away");
                        return;
                    case "Boss stats":
                        Display.ErrorText("Boss stats:");
                        Display.ItemText($"\n Health = {boss.Health}\n Damage = {boss.Damage}\n Strenght = {boss.Strength}");
                        break;
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
    }
}