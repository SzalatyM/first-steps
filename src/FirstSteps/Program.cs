using System;
using FirstSteps;

namespace temp
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzzGame = new FizzBuzz();

            var words = fizzBuzzGame.GetWords(50);

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
