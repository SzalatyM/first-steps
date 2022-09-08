using System;

namespace FirstSteps
{
    class Program
    {
        static void Main(string[] args)
        {
            var skoda = new Car("Skoda Octavia");
            var honda = new Car("Honda Civic");

            Console.WriteLine($"{skoda.GetModel()} engine status: {skoda.EngineStatus()}");
            Console.WriteLine($"{honda.GetModel()} engine status: {honda.EngineStatus()}");
            
            honda.RunEngine();
            honda.SetModel("Honda X");

            Console.WriteLine($"{skoda.GetModel()} engine status: {skoda.EngineStatus()}");
            Console.WriteLine($"{honda.GetModel()} engine status: {honda.EngineStatus()}");
        }
    }
}
