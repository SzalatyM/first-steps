using FirstSteps.RPG.Heroes;
using System;
using FirstSteps.RPG.Items;
using FirstSteps.RPG.Tools;

namespace FirstSteps.RPG.Adventures
{
    public class Village : IAdventure
    {
        public void Enter(Hero hero)
        {
            if (!(hero is Human))
            {
                Console.WriteLine("You can't enter to the village! Only human can enter!");
                return;
            }
            Display.DefaultText("\nYou enter to the Village! \nPress any button to try get an item!");
            Console.ReadLine();
            Item item = OldChest.Open();
            if (item == null)
            {
                Display.WarningText("\nUnfortunately, Empty slot!");
                return;
            }
            hero.AddItemToBackpack(item);
        }
    }
}