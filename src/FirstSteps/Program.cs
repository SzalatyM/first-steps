using System;

namespace FirstSteps
{
    class Program
    {
        static void Main(string[] args)
        {
            var skoda = new Car("Skoda Octavia");
            var honda = new Car("Honda Civic");

            Console.WriteLine(skoda.GetModel());
            Console.WriteLine(honda.GetModel());
        }
    }
}
