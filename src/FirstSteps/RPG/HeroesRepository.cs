using FirstSteps.RPG.Heroes;
using FirstSteps.RPG.Items;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace FirstSteps.RPG
{
    public class HeroesRepository
    {
        const string FilePath = @"..\..\..\RPG\File\hero.json";

        public static void SaveHero(Hero hero)
    {
        EquipmentModel equipment = hero.ToEquipmentModel();
        HeroModel heroModel = hero.ToHeroModel();

        Dictionary<string, object> heroData = new Dictionary<string, object>
        {
            { "Equipment", equipment },
            { "Hero", heroModel }
        };

        string serializedData = JsonSerializer.Serialize(heroData);
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