using FirstSteps.RPG.Adventures;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstSteps.RPG
{
    public class AdventuresRegistry 
    {
        private static List<IAdventure> _adventures = new List<IAdventure>()
        {
          new Dungeons(),
          new Forest(),
          new Hell(),
          new Mine(),
          new TreasureChest(),
          new Village(),
          new Inventory()
        };
        
        public void GetMenu()
        {
            var menu = new SelectionPrompt<string>();

            menu.AddChoice("Hero")
                .AddChild("Stats");


            menu.AddChoiceGroup("Adventures", new string[] {"Treasure Chest", "Inventory", "Forest", "Dungeons", "Mine", "Village", "Hell" });
            var command = AnsiConsole.Prompt(menu);
            Console.WriteLine(command);
        }
        public IAdventure GetAdventure(string command)
        {
             return _adventures.FirstOrDefault(x => x.Command == command);
        }             
    }
}
//public string GetCommands()
//{
//    string command = AnsiConsole.Prompt(
//            new SelectionPrompt<string>()
//                .Title("\nSelect what you want to do: ")
//                .AddChoices("Treasure Chest","Forest", "Inventory", "Dungeons", "Mine", "Village", "Hell"));
//   _adventures.Select(x => x.Command.ToList());

//}