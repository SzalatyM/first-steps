
using System;


namespace FirstSteps.RPG.Heroes
{
    public class HeroesDamage
    {

        public void Damage(Hero hero, Boss boss)
        {
            var dmg = hero.Damage + 5;

            var hp = boss.Health - dmg;
            if (hero is Human)
            {
                Console.WriteLine($"You hit the boss! Boss lost {hp}");
                Console.WriteLine($" actually boss hp: {boss.Health - hp}");
                if(boss.Health < 0)
                {
                    Console.WriteLine("Boss died!");
                }
            }
        }
    }
    //var item = _inventory.FirstOrDefault(item => item.Name == userInput);

}
