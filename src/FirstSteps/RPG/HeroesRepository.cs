﻿using FirstSteps.RPG.Heroes;
using System.IO;
using System.Text.Json;

namespace FirstSteps.RPG
{
    public class HeroesRepository
    {
        const string FilePath = @"..\..\..\RPG\File\hero.json";

        public static void SaveHero(Hero hero)
    {
         
        string serializedData = JsonSerializer.Serialize(hero.ToHeroModel());
        File.WriteAllText(FilePath, serializedData);
    }
        public static HeroModel LoadHero()
        {
            string heroJsonString = File.ReadAllText(FilePath);
            HeroModel heroModel = JsonSerializer.Deserialize<HeroModel>(heroJsonString);
            return heroModel;
        }
    }
}   