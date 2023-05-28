using FirstSteps.RPG.Heroes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace FirstSteps.RPG
{
    public class HeroesRepository
    {
        const string FilePath = @"C:\Users\misza\source\repos\first-steps\src\FirstSteps\RPG\File\hero.json";

        public static void SafeHero(Hero hero)
        {
            string serialize = JsonSerializer.Serialize(hero);
            File.WriteAllText(FilePath, serialize);
        }
        public static string LoadHero()
        {
            string deSerialize = File.ReadAllText(FilePath);
            HeroModel heroModel = JsonSerializer.Deserialize<HeroModel>(deSerialize);
            return heroModel.ToString();
        }
    }
}
