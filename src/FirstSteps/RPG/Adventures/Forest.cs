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
        private Arrow _arrowList; // ?? 

        public Forest()
        {

        }
        //{
        //    Random random = new Random();  where have i to create  that object.. :( 
        //    int emptyList = 0;
            
        //    for(emptyList = 0; emptyList > random.Next(1,25); emptyList++)
        //    {
        //        if (emptyList == random.Next(1,25))      // THAT WAS just a try xD 
        //        {
        //            Console.WriteLine("???");
        //        }
        //        else
        //        {
        //            Console.WriteLine("!!!");
        //        }

        public void Enter(Elf elf)  // and why the fuck this elf was null..When i checked it with debuging..
        {
            Console.WriteLine("You enetered the old forest. What do u want to do?");
            Console.WriteLine("Type 'heal' to increase your healt.");
            Console.WriteLine("Type 'collect arrows' to collect a random number of arrows");
            var userInput = Console.ReadLine();


            switch (userInput)
            {
                case "heal":
                    elf.Heal() ;                
                    break;
                case "collect":                   
                    elf.CollectArrows(_arrowList);            // same...      
                    break;
                default:
                    Console.WriteLine("Wrong type!");
                    break;
            }
        }
    }
}

   

