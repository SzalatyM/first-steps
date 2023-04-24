using FirstSteps.RPG.Adventures;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

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
          new Village()
        };
        
        public static string GetCommands()
        {
            
            string command = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                        .Title("\nSelect what you want to do: ")
                        .AddChoices("stats", "treasure adventure", "inventory", "forest", "dungeons", "mine", "village", "hell")); 
            if(_adventures.FirstOrDefault(x => x.Command))
            return command;
        }
        public static string GetAdventure(IAdventure adventure)
        {
            return adventure.Command;
        }      
    }
}
