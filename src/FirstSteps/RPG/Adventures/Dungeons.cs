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
            for(int i = 0; i <= _manaPoints; i++)
            {
                _manaPoints = +_manaPoints * 2;
                Console.WriteLine($"You gain: { _manaPoints} mana points");
                undead.ManaIncreases(new List<int>());
                break;
            }


        
            }
        }
    }

