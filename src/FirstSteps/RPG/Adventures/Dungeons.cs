using FirstSteps.RPG.Heroes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Spectre.Console;

namespace FirstSteps.RPG.Adventures
{
    class Dungeons
    {

        private int _manaPoints = 1;

        public void Enter(Hero hero)
        {
            
            if (hero is Undead)
            {
                Console.WriteLine("You enter the Dungeon!");
            }
            else
            {
                AnsiConsole.MarkupLine($"{Emoji.Known.CrossMarkButton} [red]You can't enter! Only Undead can enter to the Dungeons! [/] {Emoji.Known.CrossMarkButton}");
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

