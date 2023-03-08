using FirstSteps.RPG.Adventures;
using FirstSteps.RPG.Heroes;
using FirstSteps.RPG.Items;
using FluentAssertions;
using Xunit;

namespace FirstSteps.Tests.RPG.Adventures
{
    public class VillageTests
    {

        [Fact]

        public void Human_Should_Gain_Random_Item_If_Function_IsTrue_Otherwise_Return_Empty_Slot()
        {
            var Human = new Human("Test");

            var result = Human.AddItemToBackpack(Human.item);

            Assert.True(result); // could you give me a prompt about it. I think, im close ;D



        }
    }
}
