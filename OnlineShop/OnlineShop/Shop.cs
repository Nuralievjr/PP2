using System;
using System.Collections.Generic;
using System.IO;

namespace OnlineShop
{   
    
    public class Shop
    {
        public List<Product> listofproduct;
        public List<Product> bought;
        public int n;

        public Shop()
        {
            listofproduct = new List<Product>();
            bought = new List<Product>();
        }
        public void ReadProducts()
        {
            listofproduct = new List<Product>();
            StreamReader list = new StreamReader(@"/Users/macbook/Documents/PP2/asd.txt");
            n = int.Parse(list.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string s = list.ReadLine();
                string[] token = s.Split();
                Product products = new Product(token[0], int.Parse(token[1]));
                listofproduct.Add(products);

            }
        }
        public void MoveinProduct(int cursor)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            int move = 1;
            for (int i = 0; i < n; i++)
            {
                Product products = listofproduct[i];
                if (i == cursor)
                {
                    Console.BackgroundColor = ConsoleColor.Green;

                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.White;
                }
                Console.SetCursorPosition(20, move * 2);
                Console.WriteLine(products.name);
                Console.SetCursorPosition(50, move * 2);
                Console.WriteLine(products.cost);
                move++;
            }

        }
        public void Buy(Product p)
        {

            bought.Add(p);


        }
        public void ShowBought()
        {

            for (int i = 0; i < bought.Count; i++)
            {
                Console.WriteLine(bought[i]);
            }


        }
        public void EscapeShowProducts()
        {
            for (int i = 0; i < listofproduct.Count; i++)
            {
                Console.WriteLine(listofproduct[i]);
            }
        }

    }
}
