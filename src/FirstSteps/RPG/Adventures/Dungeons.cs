using FirstSteps.RPG.Heroes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FirstSteps.RPG.Adventures
{
    class Dungeons
    {
        private  Undead undead;
        private int _manaPoints = 1;

        public void Enter(Hero hero)
        {
            if (hero is Undead)
            {
                Console.WriteLine("You enter the Dungeon!");
            }
            else
            {
                Console.WriteLine("You can't enter! Only Undead have acces to the dungeons");
                return;
            }
            Console.WriteLine($"You gain: { _manaPoints} mana points");
            undead.ManaIncreases(_manaPoints);
            _manaPoints = _manaPoints * 2;
            Console.WriteLine("____________________________________");
        }       
    }
}

