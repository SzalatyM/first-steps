namespace FirstSteps.RPG.Items
{
    public class Item
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Weight { get; set; }

        public Item(string name, int price, int weight)
        {
            Name = name;
            Price = price;
            Weight = weight;
        }
       
        public override string ToString()
        {
            return "Item: " + Name + "price: " + Price + "weight" + Weight;
        }
    }
}

