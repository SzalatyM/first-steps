using FirstSteps.RPG.Heroes;
using System;
using System.Collections.Generic;
using System.Text;
using FirstSteps.RPG.Items;

namespace FirstSteps.RPG.Adventures
{
    public class Mine
    {
        private int Coins = 1;

        public void Enter(Hero hero)
        {
            Dwarf dwarf = (Dwarf)hero;

            if (hero is Dwarf)
            {
          
                Console.WriteLine($"You enetered the Mine." );
            }
            else
            {
                Console.WriteLine("You can't enter to the Mine! Only Dwarf can enter!");
                return;
            }
            Console.WriteLine($" U gain {Coins} coins");
            if(Coins % 2 == 0)
            {
                dwarf.Coins(Coins);
                Coins = Coins + 1;
            }
            else
            {
                dwarf.Coins(Coins);
                Coins = Coins + 3;
            }

        }
    }
}
