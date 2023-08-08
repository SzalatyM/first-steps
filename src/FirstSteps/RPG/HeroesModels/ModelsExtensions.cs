using FirstSteps.RPG.Items;
using System;

namespace FirstSteps.RPG.HeroesModels
{
    public static class ModelsExtensions
    {
        public static Equipment MapToEquipment(this HeroModel heroModel)
        {
            Equipment equipment = new Equipment();

            foreach (ItemModel itemModel in heroModel.Equipment.Items)
            {
                Item item = MapItem(itemModel.Name);
                equipment.TryAddItemToBackpack(item);
            }
            return equipment;
        }

        private static Item MapItem(string itemModel)
        {
            return itemModel switch
            {
                "MagicAxe" => new MagicAxe(),
                "MagicBow" => new MagicBow(),
                "MagicSword" => new MagicSword(),
                "MagicSkull" => new MagicSkull(),
                "Arrow" => new Arrow(),
                "Knife" => new Knife(),
                "Pitchfork" => new Pitchfork(),
                _ => throw new ArgumentException("No Item"),
            };
        }
    }
}
