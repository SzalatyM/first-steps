using System;

namespace FirstSteps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FizzBuzz game:");

            var fizzBuzzGame = new FizzBuzz();
            var words = fizzBuzzGame.GetWords(50);
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }


            Console.WriteLine("Palindrome game:");

            var palindromeGame = new Palindrome();
            Console.WriteLine("anna: " + palindromeGame.IsPalindrome("anna"));
            Console.WriteLine("test: " + palindromeGame.IsPalindrome("test"));
        }
    }
}
