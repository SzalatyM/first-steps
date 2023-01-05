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
        private int enter = 0;
        public void Enter(Hero hero)
        {
            Dwarf dwarf = (Dwarf)hero;

            if (hero is Dwarf)
            {
                Console.WriteLine($"You enetered the Mine.");
                enter += 1;

                if (enter % 2 == 0)
                {
                    Coins = 3;
                    dwarf.AddCoins(Coins);
                    Console.WriteLine($" You gain {Coins} coins ");                    
                }
                else
                {
                    Coins = 1;
                    dwarf.AddCoins(Coins);
                    Console.WriteLine($" You gain {Coins} coins ");
                }               
            }
        }
    }
}
