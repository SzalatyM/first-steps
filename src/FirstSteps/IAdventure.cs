using FirstSteps.RPG.Heroes;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstSteps
{
    public interface IAdventure
    {
        public void Enter(Hero hero);
        // u mean public void Enter(Hero hero, string command) ? 
    }
}
