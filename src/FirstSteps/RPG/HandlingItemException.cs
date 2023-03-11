using System;

namespace FirstSteps.RPG
{
    public class HandlingItemException : Exception
    {
        const string text = "You can't hold this item";
        public HandlingItemException() : base(text)
        {
            
        }
       public void TrySpendCoins()
        {
            throw new HandlingItemException();
        }
        public void ShowItems()
        {
            try
            {
                TrySpendCoins();
            }
            catch(HandlingItemException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}