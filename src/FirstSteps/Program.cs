using FirstSteps;

var fizzBuzzGame = new FizzBuzz();

var words = fizzBuzzGame.GetWords(50);

foreach (var word in words)
{
    Console.WriteLine(word);
}