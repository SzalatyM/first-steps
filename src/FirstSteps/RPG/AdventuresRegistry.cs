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
        public List<string> GetCommands()
        {
            return _adventures.Select(x => x.Command).ToList();
        }   
        public IAdventure GetAdventure(string command)
        {
             return _adventures.FirstOrDefault(x => x.Command == command);
        }             
    }
}