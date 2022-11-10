using FirstSteps.RPG.Heroes;
using FirstSteps.RPG.Items;
using System;
using System.Collections.Generic;

namespace FirstSteps.RPG.Adventures
{
    public class Forest
    {
        public Forest() { }

        public void Enter(Elf elf)
        {
            Console.WriteLine("You enetered the old forest. What do u want to do?");
            Console.WriteLine("Type 'heal' to increase your healt.");
            Console.WriteLine("Type 'collect ' to collect a random number of arrows");
            var userInput = Console.ReadLine();

            switch (userInput)
            {
                case "heal":
                    elf.Heal();
                    break;
                case "collect":
                    //draw random number
                    int arrowsNumber = new Random().Next(1, 10);

                    //create empty list of arrows
                    List<Arrow> collectedArrows = new List<Arrow>();

                    //fill empty list by arrows
                    for(int i = 0; i < arrowsNumber; i++)
                    {
                        collectedArrows.Add(new Arrow());
                    }

                    //add arrows to the elf's bag
                    elf.CollectArrows(collectedArrows);

                    break;
                default:
                    Console.WriteLine("Wrong type!");
                    break;
            }
        }
    }
}
