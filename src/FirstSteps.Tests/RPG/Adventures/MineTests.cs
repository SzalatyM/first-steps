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
        [InlineData(11, 5)]
        [InlineData(14, 6)]
        [InlineData(15, 7)]
        [InlineData(18, 8)]
        [InlineData(19, 9)]
        [InlineData(22, 10)]
        [InlineData(23, 11)]
        [InlineData(26, 12)]
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