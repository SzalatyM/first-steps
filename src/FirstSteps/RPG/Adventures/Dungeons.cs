using FirstSteps.RPG.Heroes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FirstSteps.RPG.Adventures
{
    class Dungeons
    {
        private int _manaPoints = 1;

        public void Enter(Undead undead)
        {
            for(int i = 1; i <= _manaPoints; i++)
            {
                Console.WriteLine($"You gain: { _manaPoints} mana points");
                undead.ManaIncreases(_manaPoints);
                _manaPoints = +_manaPoints * 2;
                break;
            }
            Console.WriteLine("____________________________________");
            }
        }
    }

