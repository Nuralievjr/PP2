using System;
using System.IO;
using System.Collections.Generic;
namespace OnlineShop
{
    public class CategoruofProducts
    {
        List<Product> listofproductsofcateg;
        List<string> category;
        string s;
        public CategoruofProducts()
        {
            
        }
        public void Category()
        {
            StreamReader sr = new StreamReader(@"/Users/macbook/Documents/PP2/Categ.txt");
            int n = int.Parse(sr.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string c = sr.ReadLine();
                category.Add(s);
            }
            
        }
        public void ReadProductsforCategory()
        {
            listofproductsofcateg = new List<Product>();
            StreamReader list = new StreamReader(@"/Users/macbook/Documents/PP2/Foods.txt");
            n = int.Parse(list.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string sf = list.ReadLine();
                string[] token = s.Split();
                Product products = new Product(token[0], int.Parse(token[1]));
                listofproductsofcateg.Add(products);

            }
        }





    }
}
