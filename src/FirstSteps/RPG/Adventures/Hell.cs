using FirstSteps.RPG.Heroes;
using FirstSteps.RPG.Tools;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace FirstSteps.RPG.Adventures
{
    public class Hell 
    {
          
        public void FightWithboss(Hero hero)
        {
            Boss boss = new Boss("Diablo", 30, 5, 7);
            Display.DefaultText($"You entered to the Hell!\nIf u wanna fight with {boss.Name} press 'f' otherwise go back to previous menu ");
            Display.ErrorText("Boss stats:");
            Display.ItemText($"\n Health = {boss.Health}\n Damage = {boss.Damage}\n Strenght = {boss.Strength}");
            var userInput = Console.ReadLine();

            if(userInput == "f")
            {
                Console.WriteLine("Let's Fight!");
                var result = boss.Health - hero.Damage;
                Console.WriteLine(result);
                Console.WriteLine(boss.Health);
            }
            else
            {
                Console.WriteLine("Wrong type");
                
            }
 
        }
    }
    
}