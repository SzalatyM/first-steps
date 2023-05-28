using System;
using FirstSteps.RPG;
using FirstSteps.RPG.Heroes;
using Spectre.Console;

namespace FirstSteps
{
    class Program
    {
        private static Hero hero;

        static void Main(string[] args)
        {         
          
            Game.GameMenu();
            HeroesRepository.SafeHero(hero);
        }
    }
}
