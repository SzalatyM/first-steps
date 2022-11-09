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
        private List<Arrow> _arrowsList;

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
                    for(int i = 0; i < _arrowsList.Count; i++)
                    {
                        var draw = random.Next(1, 25);
                        if(draw >= _arrowsList.Count)
                        {
                            elf.CollectArrows(_arrowsList);
                            Console.WriteLine($"U gain {_arrowsList}");
                        }
                    }


                    break;
                default:
                    Console.WriteLine("Wrong type!");
                    break;
            }
        }
    }
}



