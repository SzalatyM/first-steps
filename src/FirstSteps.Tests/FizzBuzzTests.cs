using Xunit;

namespace FirstSteps.Tests;

public class FizzBuzzTests
{
    private readonly FizzBuzz _fizzBuzzGame;

    public FizzBuzzTests()
    {
        _fizzBuzzGame = new FizzBuzz();
    }

    [Fact]
    public void Length_Should_Be_Equal_To_Given_Number()
    {
        var words = _fizzBuzzGame.GetWords(20);

        Assert.Equal(20, words.Length);
    }

    [Fact]
    public void Numbers_Not_Affected_By_Rules_Should_Be_Numbers()
    {
        var words = _fizzBuzzGame.GetWords(10);

        Assert.Equal("1", words[0]);
        Assert.Equal("2", words[1]);
        Assert.Equal("4", words[3]);
        Assert.Equal("7", words[6]);
        Assert.Equal("8", words[7]);
    }

    [Fact]
    public void Numbers_Divisible_By_Three_Should_Be_Equal_Fizz()
    {
        const string result = "Fizz";

        var words = _fizzBuzzGame.GetWords(20);

        Assert.Equal(result, words[2]);
        Assert.Equal(result, words[5]);
        Assert.Equal(result, words[8]);
        Assert.Equal(result, words[11]);
        Assert.Equal(result, words[17]);
    }

    [Fact]
    public void Numbers_Divisible_By_Five_Should_Be_Equal_Buzz()
    {
        const string result = "Buzz";

        var words = _fizzBuzzGame.GetWords(20);

        Assert.Equal(result, words[4]);
        Assert.Equal(result, words[9]);
        Assert.Equal(result, words[19]);
    }

    [Fact]
    public void Numbers_Divisible_By_Three_And_Five_Should_Be_Equal_FizzBuzz()
    {
        const string result = "FizzBuzz";

        var words = _fizzBuzzGame.GetWords(50);

        Assert.Equal(result, words[14]);
        Assert.Equal(result, words[29]);
        Assert.Equal(result, words[44]);
    }
}