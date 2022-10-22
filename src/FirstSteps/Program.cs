using System;
using FirstSteps.RPG;

namespace FirstSteps
{
    class Program
    {
        static void Main(string[] args)
        {
            


            Console.WriteLine("Welcome to the RPG game");

            Game.CreateHero();

            Console.WriteLine("Let's play the game");

            Game.DisplayCommands();

            Console.WriteLine("Type 'end' if you want to quit.");

            string command;
            
            do
            {
               command = Console.ReadLine();
                Game.HandleCommand(command);
                Console.WriteLine();
                
            }
            while(command.ToLower() != "end");
        }
    }
}
