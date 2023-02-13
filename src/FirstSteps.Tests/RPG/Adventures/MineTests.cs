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
        [InlineData(9, 5)]
        [InlineData(12, 6)]
        public void Dwarf_Should_Gain_Three_Coins_When_Numbers_Are_Odd_Otherwise_Should_Gain_One_Coin(int expectedCoins, int visitCounter)
        {

            var mine = new Mine();
            var dwarf = new Dwarf("Testhero");

            for (int i = 0; i < visitCounter; i++)
            {
                mine.Enter(dwarf);
            }

            dwarf.Coins.Should().Be(expectedCoins);
        }
        [Theory]
        [InlineData(1, 1)]
        [InlineData(4, 2)]
        [InlineData(5, 3)]
        [InlineData(8, 4)]
        [InlineData(10, 5)]
        [InlineData(13, 6)]
        [InlineData(14, 7)]
        [InlineData(17, 8)]
        [InlineData(18, 9)]
        [InlineData(21, 10)]
        [InlineData(22, 11)]
        [InlineData(25, 12)]
        [InlineData(25, 13)]
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