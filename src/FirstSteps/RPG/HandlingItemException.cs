using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstSteps.RPG
{
    public class HandlingItemException : Exception
    {
        const string text = "You can't hold this item";
        public HandlingItemException() : base(text)
        {
            
        }
       public void MetodaWyjatku()
        {
            throw new HandlingItemException();
        }
        public void MetodaCatch()
        {
            try
            {
                MetodaWyjatku();
            }
            catch(HandlingItemException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
