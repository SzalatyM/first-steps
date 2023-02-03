using FirstSteps.RPG.Adventures;
using FirstSteps.RPG.Heroes;
using FluentAssertions;
using Xunit;

namespace FirstSteps.Tests.RPG.Adventures
{
    public class MineTests
    {
        public int coins;
        [Fact]
        
        public void Dwarf_Should_Gain_One_Coin_After_the_First_Visit__In_The_Mine()
        {
            var mine = new Mine();
            var dwarf = new Dwarf("Test");

            mine.Enter(dwarf);

            dwarf.Coins.Should().Be(1);

        }
        [Theory]
        [InlineData(1,1)]


        public void Dwarf_Should_Get_One_Coin_After_First_Visit_In_The_Mine(int expectedResult, int firstVisit)
        {
            var mine = new Mine();
            var dwarf = new Dwarf("Testhero");

            mine.Enter(dwarf);
            firstVisit += 1;
            dwarf.Coins.Should().Be(expectedResult);
        }
    }
}