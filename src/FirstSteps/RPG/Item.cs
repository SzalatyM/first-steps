using System;
using System.Collections.Generic;
using System.Text;

namespace FirstSteps.RPG
{
    public class Item
    {
        public string Name { get; }
        public int Price { get; }
        public int Weight { get; }
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

