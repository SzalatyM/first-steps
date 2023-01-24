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

            dwarf.AddCoins(1);


        }
        [Theory]
        [InlineData(1, 1)]
        [InlineData(1, 2)]


        public void Dwarf_Should_Get_One_Coin_After_First_Visit_In_The_Mine(int expectedResult, int firstAscent)
        {
            var mine = new Mine();
            var dwarf = new Dwarf("Testhero");
            mine.Enter(dwarf);
            for(int i = 0; i < firstAscent; i++)
            {
                mine.Enter(dwarf);
            }
            Assert.Equal(expectedResult, firstAscent);
            dwarf.AddCoins(expectedResult);
        }
    }
}