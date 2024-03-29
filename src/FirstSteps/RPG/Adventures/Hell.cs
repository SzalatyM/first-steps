﻿using FirstSteps.RPG.Heroes;
using FirstSteps.RPG.Tools;
using Spectre.Console;
using System;

namespace FirstSteps.RPG.Adventures
{
    public class Hell : IAdventure
    {
        public string Command => "Hell";

        public void Enter(Hero hero)
        {
            var diablo = Boss.CreateDiablo();
            var heroDamage = hero.DealDamage();
            var diabloDamage = diablo.DealDamage();

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
                        if (number >= 2)
                        {
                            diablo.TakeDamage(heroDamage);
                            Display.ClassicText($"[blue]You deal {heroDamage} damage to boss![/]");
                            Display.ClassicText($"[purple]Actually health boss: {diablo.Health}[/]");
                            Console.WriteLine(string.Empty);
                        }
                        else
                        {
                            hero.TakeDamage(diabloDamage);
                            Display.ErrorText($"Boss deal {diabloDamage} damage to Hero!");
                            Display.DefaultText($"You currently have {hero.Health} hp");
                            Console.WriteLine(string.Empty);
                        }
                        break;
                    case "Run":
                        Display.ErrorText("You ran away");
                        return;
                    case "Boss stats":
                        Display.ErrorText("Boss stats:");
                        Display.ItemText($"\n Health = {diablo.Health}\n Damage = {diablo.Damage}\n Strenght = {diablo.Strength}");
                        break;
                }
                if (diablo.Health <= 0)
                {
                    Display.ItemText("Boss died! You receive a 100 coins");
                    hero.AddCoins(100);
                    return;
                }
            }
            while (hero.Health > 0);
            Display.ErrorText("You died! Game over");
            Environment.Exit(1);
        }
    }
}