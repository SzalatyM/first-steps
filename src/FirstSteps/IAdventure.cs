using FirstSteps.RPG.Heroes;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstSteps
{
    interface IAdventure
    {
        string Command { get; }
        public void Enter(Hero hero);
    }
}