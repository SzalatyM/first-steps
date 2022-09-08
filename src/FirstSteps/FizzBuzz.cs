using System;

namespace FirstSteps
{
    public class FizzBuzz
    {
        public string[] GetWords(int numberOfWords)
        {
            string[] words  = new string[numberOfWords];
            for (int i = 1; i <= numberOfWords; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    words[i - 1] = "FizzBuzz";
                }
                else if(i % 3 == 0)
                {
                    words[i - 1] = "Fizz";
                }
                else if( i % 5 == 0)
                {
                    words[i - 1] = "Buzz";
                }
                else
                {
                    words[i - 1] = i.ToString();                  
                }
                
            }




            //if the number is divisible by 3 and 5, set the word to "FizzBuzz"

            //if the number is divisible by 3, set the word to "Fizz"

            //if the number is divisible by 5, set the word to "Buzz"

            //if the number is not divisible by 3 or 5, set the word to the number

            //return the array of strings
            return words;
        }
    }
}
