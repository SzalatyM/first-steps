using FirstSteps.RPG.Adventures;
using FirstSteps.RPG.Items;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace FirstSteps.RPG.Heroes
{
    public class HeroesDamage
    {
        private Boss boss;
        public void Damage(Hero hero)
        {
            if(hero is Human)
            {
                var dmg = hero.Damage + hero.Strength;

                var hp = dmg - boss.Health;
                Console.WriteLine(hp);
                if(hp < 0)
                {
                    Console.WriteLine("U lost this game mordo ");
                }
            }
        }
    }
    //var item = _inventory.FirstOrDefault(item => item.Name == userInput);

}
