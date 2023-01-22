using FirstSteps.RPG.Adventures;
using FirstSteps.RPG.Heroes;
using FluentAssertions;
using Xunit;

namespace FirstSteps.Tests.RPG.Adventures
{
    public class DungeonsTests
    {
        [Fact]
        public void Undead_Should_Gain_One_Mana_Point_After_First_Visit_In_The_Dungeons()
        {
            //arrange - section to setup the class you want to test
            var dungeons = new Dungeons();
            var undead = new Undead("Test");

            //act - section to perform the action you want to test
            dungeons.Enter(undead);

            //assert - section to check if the result matches your expectation
            undead.ManaPoints.Should().Be(1);
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(3, 2)]
        [InlineData(15, 4)]
        public void Undead_Should_Gain_Expected_Mana_Point_After_Given_Visit_In_The_Dungeons(int expectedManaPoints, int visitCounter)
        {
            //arrange - section to setup the class you want to test
            var dungeons = new Dungeons();
            var undead = new Undead("testhero");

            //act - section to perform the action you want to test
            for(int i = 0; i < visitCounter; i++)
            {
                dungeons.Enter(undead);
            }

            //assert - section to check if the result matches your expectation
            undead.ManaPoints.Should().Be(expectedManaPoints);
        }
    }
}