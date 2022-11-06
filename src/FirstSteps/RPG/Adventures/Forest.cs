using FirstSteps.RPG.Heroes;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstSteps.RPG.Adventures
{
    class Forest : Elf
    {
        public Forest() // i dont know why it's not working.. 
        {

        }
    
        public void Enter(Elf elf)
        {
            Console.WriteLine("You enetered the old forest. What do u want to do?");
            Console.WriteLine("Type 'heal' to increase your healt.");
            Console.WriteLine("Type 'collect arrows' to collect a random number of arrows");
            var userInput = Console.ReadLine();

            switch (userInput)
            {
                case "heal":
                    elf.Heal();                  
                    break;
                case "collect":
                  //  elf.CollectArrows();  // same problem, i dont know how o get a acces to this with parametrs. 
                   // I need to read/ watch about parametrs in method. it's a little bit complicated for me.. :(
                    break;
                default:
                    Console.WriteLine("Wrong type!");
                    break;
            }
        }
    }
}

   

