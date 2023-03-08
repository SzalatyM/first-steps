﻿using FirstSteps.RPG.Heroes;
using FirstSteps.RPG.Tools;
using Spectre.Console;
using System;
namespace FirstSteps.RPG.Adventures
{
    public class Mine
    {
        private int _enter = 0;
        public void Enter(Hero hero)
        {
            if (hero is Dwarf == false)
            {
                Display.ErrorText("You can't enter! Only Dwarf can enter to the Mine!");
                return;
            }
            Display.DefaultText("You entered to the Mine! ");

            _enter += 1;
            int coins = 0;           
            if(_enter == 13)
            {
                return;
            }
            else if(_enter % 2 == 0)
            {
                coins += 3;
            }
            else
            {
                coins += 1;
            }
            if(_enter % 5 == 0)
            {
                coins += 2;
            }
            hero.AddCoins(coins);
            Console.WriteLine($"You gain: { coins} coins");
        }
    }
}

