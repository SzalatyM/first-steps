using FirstSteps.RPG.Heroes;
using FirstSteps.RPG.Items;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FirstSteps.RPG.Adventures
{
   public class Forest 
    {

        public Forest()
        {
 
            
        }

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
                    Random random = new Random();
                    int arrowsList = random.Next(1, 25);
                    elf.CollectArrows(arrowsList);
                    Console.WriteLine($"U get {arrowsList} arrows"); // is this working good?  
                                                                    // loop " for" im trying to do in a separate project 

                    break;
                default:
                    Console.WriteLine("Wrong type!");
                    break;
            }
        }
    }
}

   

