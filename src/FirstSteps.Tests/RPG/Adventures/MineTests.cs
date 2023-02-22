using FirstSteps.RPG.Adventures;
using FirstSteps.RPG.Heroes;
using FluentAssertions;
using Xunit;

namespace FirstSteps.Tests.RPG.Adventures
{
    public class MineTests
    {
        [Fact]
        public void Dwarf_Should_Gain_One_Coin_After_the_First_Visit__In_The_Mine()
        {
            var mine = new Mine();
            var dwarf = new Dwarf("Test");

            mine.Enter(dwarf);

            dwarf.Coins.Should().Be(1);
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(4, 2)]
        [InlineData(5, 3)]
        [InlineData(8, 4)]
        [InlineData(13, 5)]
        [InlineData(16, 6)]
        [InlineData(17, 7)]
        [InlineData(20, 8)]
        [InlineData(21, 9)]
        [InlineData(24, 10)]
        [InlineData(25, 11)]
        [InlineData(28, 12)]
        [InlineData(28, 13)]
        public void Dwarf_Should_Gain_Three_Coins_When_Numbers_Are_Odd_Or_Plus_2_Coins_When_Divide_By_Five_When_Number_Is_13_Gain_0_Coins_Otherwise_Gain_1_Coin(int expectedCoins, int visitCounter)
        {
            var mine = new Mine();
            var dwarf = new Dwarf("TestHeroes");

            for (int i = 0; i < visitCounter; i++)
            {
                mine.Enter(dwarf);
            }
            dwarf.Coins.Should().Be(expectedCoins);
        }
    }
}