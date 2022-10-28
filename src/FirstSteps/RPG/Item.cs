using System;
using System.Collections.Generic;
using System.Text;

namespace FirstSteps.RPG
{
      class Item
    {
        public string Name;
        public int Price;
        public int Weight;
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

