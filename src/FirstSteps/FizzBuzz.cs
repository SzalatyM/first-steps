namespace FirstSteps;

public class FizzBuzz
{
    public void Run()
    {
        for (int i = 1; i <= 100; i++)
        {
            string result = "";
            if (i % 3 == 0)
            {
                result += "Fizz";
            }
            if (i % 5 == 0)
            {
                result += "Buzz";
            }
            if (result == "")
            {
                result = i.ToString();
            }
            System.Console.WriteLine(result);
        }
    }
}
