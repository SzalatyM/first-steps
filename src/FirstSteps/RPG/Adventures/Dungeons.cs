using FirstSteps.RPG.Heroes;
using System;
using FirstSteps.RPG.Tools;

namespace FirstSteps.RPG.Adventures
{
    public class Dungeons
    {
        private int _manaPoints = 1;

        public void Enter(Hero hero)
        {
            
            if (hero is Undead)
            {
                Display.DefaultText("You enter to the Dungeon!");
            }
            else
            {
                Display.ErrorText("You can't enter! Only Undead can enter to the Dungeons!");
                return;
            }
            Undead undead = (Undead)hero;
            Console.WriteLine($"You gain: { _manaPoints} mana points");
            undead.ManaIncreases(_manaPoints);
            _manaPoints = _manaPoints * 2;
            Console.WriteLine("____________________________________");
        }       
    }
}
