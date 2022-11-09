using FirstSteps.RPG.Items;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace FirstSteps.RPG.Heroes
{

    public class Elf : Hero, IGreeting
    {
        private Arrow _arrows;


        public Elf(string name) : base(name, Races.Elf)
        {
            _strength = 3;
            _intelligence = 2;
            _agility = 5;
            _health = 120;
            _damage = 20;
        }

        protected override bool CanHandleSpecialItem(Item item)
        {
            return item is MagicBow;
        }

        public string Greed()
        {
            return "Im Elf";
        }
        public void Heal()
        {
            _health += _health + 10;
            Console.WriteLine("U gain 10hp!"); 
        }
        public void  CollectArrows(List<Arrow> _arrowsList)
        {
            _arrowsList.Add(_arrows);
            
            // i dont know how to do it :( im losing so much time and still not working.
                                                          // if here  is ok then in class forest drops an error and inverse..
                                                          // You show me  examples but still i dont know how to fix it.
                                                          // the best idea will be to show me how to do it and explains me in simple.


        }
    }
}
