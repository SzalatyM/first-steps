using System;
using System.Collections.Generic;
using System.Text;

namespace FirstSteps.RPG
{
    public class Item
    {
        public string Name { get; }   

        public int Price { get;}

        public Item(string name, int price)
        {
            Name = name;
            Price = price;

        }
        public override string ToString()
        {
            return "Item: " + Name + "price: " + Price;
        }
    }
}

