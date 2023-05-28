using System;
using FirstSteps.RPG;
using FirstSteps.RPG.Heroes;
using Spectre.Console;

namespace FirstSteps
{
    class Program
    {
        private static Hero Hero;
        static void Main(string[] args)
        {
            HeroesRepository.SafeHero(Hero);
            Game.GameMenu();
        }
    }
}
