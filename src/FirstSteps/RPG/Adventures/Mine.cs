using FirstSteps.RPG.Heroes;
using Spectre.Console;
using System;
namespace FirstSteps.RPG.Adventures
{
    public class Mine
    {
  
        private int enter = 0;
        public void Enter(Hero hero)
        {
            if (hero is Dwarf == false)
            {
                AnsiConsole.MarkupLine($"{Emoji.Known.CrossMarkButton} [red]You can't enter! Only Dwarf can enter to the Mine! [/] {Emoji.Known.CrossMarkButton}");
                return;
            }

            AnsiConsole.MarkupLine($"{Emoji.Known.CrossedSwords} [darkblue]You entered to the Mine![/] {Emoji.Known.CrossedSwords}");

            enter += 1;

            var coins = enter % 2 == 0 ? 3 : 1;
            Console.WriteLine($"You gain {coins} coins ");
            hero.AddCoins(coins);
            //int coins;
            //if (hero is Dwarf)
            //{

            //    AnsiConsole.MarkupLine($"{Emoji.Known.CrossedSwords} [darkblue]You entered to the Mine![/] {Emoji.Known.CrossedSwords}");
            //    enter += 1;
            //}
            //else
            //{
            //    AnsiConsole.MarkupLine($"{Emoji.Known.CrossMarkButton} [red]You can't enter! Only Dwarf can enter to the Mine! [/] {Emoji.Known.CrossMarkButton}");
            //    return;
            //}

            //Dwarf dwarf = (Dwarf)hero;

            //if (enter % 2 == 0)
            //{
            //     coins = 3;
            //}
            //else
            //{
            //   coins = 1;
            //}
            //Console.WriteLine($"You gain {coins} coins ");
            //dwarf.AddCoins(coins);
        }
    }
}

