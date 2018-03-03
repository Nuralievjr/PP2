using System;
namespace OnlineShop
{
    public class Product
    {
        public string name;
        public int cost;
        public Product(string name, int cost)
        {
            this.name = name;
            this.cost = cost;
        }
        public override string ToString()
        {
            return name+" "+cost;
        }
    }
}
