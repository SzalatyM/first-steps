using FirstSteps.RPG.Heroes;
using FirstSteps.RPG.Tools;
using Spectre.Console;
using System;

namespace FirstSteps.RPG.Adventures
{
    public class Hell
    {
        public void FightWithBoss(Hero hero)
        {
            var boss = Boss.CreateDiablo("Diablo", 50, 5, 6);

            Display.DefaultText($"You entered to the Hell!");

            do
            {
                string userInput = AnsiConsole.Prompt(
                     new SelectionPrompt<string>()
                       .Title($" \nChose what u want to do! {Emoji.Known.CrossedSwords}")
                       .AddChoices("Boss stats", "Hit the boss!", "Run"));

                switch (userInput)
                {
                    case "Hit the boss!":
                        var number = new Random().Next(1, 5);
                        Console.WriteLine($"You rolled {number}");
                        if (number >=1)
                        {
                            boss.Health -= hero.DealDamage();
                            Display.ErrorText($"You deal {hero.DealDamage()} damage to boss!");
                            Display.DefaultText($"Actually health boss: {boss.Health}");
                        }
                        else
                        {
                            hero.TakeDamage(boss.DealDamage());
                            Display.ErrorText($"Boss deal {boss.DealDamage()} damage to Hero!");
                            Display.DefaultText($"You currently have {hero.Health} hp");
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
                if (boss.Health <= 0)
                {
                    Display.ItemText("Boss died! You receive a 100 coins");
                    hero.AddCoins(100);
                    return;
                }
            }
            while (hero.Health >= 0);
            Display.ErrorText("You died! Game over");
            Environment.Exit(1);
        }
    }
}

//if (hero.Health <= 0)
//{
//    Display.ErrorText("You died! Game over");
//    break;
//}
//            }
//            if (boss.Health <= 0)
//{
//    Display.ItemText("Boss died! You receive a 100 coins");
//    hero.AddCoins(100);
//    return;