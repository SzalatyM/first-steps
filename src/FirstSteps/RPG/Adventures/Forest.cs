using FirstSteps.RPG.Heroes;
using FirstSteps.RPG.Items;
using System;
using System.Collections.Generic;

namespace FirstSteps.RPG.Adventures
{
    public class Forest
    {
        private Elf elf; // Despite i use class Elf value of elf is equals null,
                         // I think it's rly easy but i can't find a simple way to fix it 
                         // although i had a similar example before but i can't remember. 
                         // When i created a new Elf, result was weird. I think i made a elf twice but still add a 10hp more. 
        public Forest()
        {
   
        }

        public void Enter(Hero _hero)
        {
            if (_hero is Elf)
            {
                Console.WriteLine("You enetered the old forest. What do u want to do?");
            }
            else
            {
                Console.WriteLine("You can't enter to the forest! Only Elf can enter!");
                return;
            }      
            Console.WriteLine("Type 'heal' to increase your healt.");
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
                    for(int i = 0; i < arrowsNumber; i++)
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
