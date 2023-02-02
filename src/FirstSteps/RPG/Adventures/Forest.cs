using FirstSteps.RPG.Heroes;
using FirstSteps.RPG.Items;
using FirstSteps.RPG.Tools;
using Spectre.Console;
using System;
using System.Collections.Generic;

namespace FirstSteps.RPG.Adventures
{
    public class Forest
    {
        public void Enter(Hero hero)
        {
            if (hero is Elf)
            {
                Display.DefaultText("You enetered the old forest. What do u want to do?");
            }
            else
            {
                Display.ErrorText("You can't enter! Only Elf can enter to the forest!");
                return;
            }
            Elf elf = (Elf)hero;
            Console.WriteLine("Type 'heal' to increase your health.");
            Console.WriteLine("Type 'collect ' to collect a random number of arrows");
            var userInput = Console.ReadLine();
            switch (userInput)               
            {
                case "heal":                   
                    elf.Heal();
               break;
                case "collect":
                    int arrowsNumber = new Random().Next(1, 10);
                    List<Arrow> collectedArrows = new List<Arrow>();
                    for (int i = 0; i < arrowsNumber; i++)
                    {
                        collectedArrows.Add(new Arrow());
                    }
                    elf.CollectArrows(collectedArrows);
                    Console.WriteLine($" You gain:  { arrowsNumber} arrows!");
                    break;
                default:
                    Console.WriteLine("Wrong type!");
                    break;
            }
        }
    }
}
