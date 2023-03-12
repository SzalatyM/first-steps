using System;

namespace FirstSteps.RPG
{
    public class HeroCantHoldItemException : Exception
    {
        const string text = "You can't hold this item";
        public HeroCantHoldItemException() : base(text)
        {
            
        }
       public void TrySpendCoins()
        {
            throw new HeroCantHoldItemException();
        }
        public void ShowItems()
        {
            try
            {
                TrySpendCoins();
            }
            catch(HeroCantHoldItemException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}