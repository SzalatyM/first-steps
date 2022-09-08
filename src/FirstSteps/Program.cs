using System;

namespace FirstSteps
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var number = new Number(10);

            number.Add(20);
            number.Subtract(60);
            number.Divide(2);
            number.Double();
            number.Triple();


            Console.WriteLine(number.GetValue()); 
        }
    }
}
