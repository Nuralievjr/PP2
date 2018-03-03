using System;
using System.IO;
namespace OnlineShop
{
    class MainClass
    {   
       

        public static void Main(string[] args)
        {   
            
            Console.WriteLine("Здраствуйете, Ваше имя");

            string nameofclient = Console.ReadLine();
            Console.Clear();

            Shop shop = new Shop();

            bool t;
            int cursor = 0;
            int n = shop.n;

            shop.ReadProducts();
            shop.MoveinProduct(cursor);

            while(true)
            {   
               
                ConsoleKeyInfo keyinfo = Console.ReadKey();
                if(keyinfo.Key == ConsoleKey.UpArrow)
                {
                    cursor--;
                    if(cursor==-1)
                    {
                        cursor = shop.n - 1;
                    }

                }
                if(keyinfo.Key == ConsoleKey.DownArrow)
                {   
                    
                    cursor++;
                    if(cursor==shop.n)
                    {
                        cursor = 0;
                    }
                   
                }
                if(keyinfo.Key == ConsoleKey.Enter)
                {   
                    
                    shop.Buy(shop.listofproduct[cursor]);
                }
                if(keyinfo.Key==ConsoleKey.S)
                {
                    cursor = 0;
                    shop.n = shop.bought.Count;
                    shop.listofproduct = shop.bought;
                    shop.ShowBought();
                }
                    
                if(keyinfo.Key == ConsoleKey.B)
                {   
                    
                    t = true;
                    break;

                }
                shop.MoveinProduct(cursor);
                
                
            }
           
            Console.Clear();
            if(t ==true)
            {   
                Console.WriteLine("Thanks "+ nameofclient);
                Console.WriteLine("Your check");
                int sum = 0;
                for (int i = 0; i < shop.bought.Count; i++)
                {
                    Console.WriteLine(shop.bought[i]);
                    sum += shop.bought[i].cost;
                }
                Console.WriteLine("Total: "+ sum );
            }



                       
                
        }
    }
}
