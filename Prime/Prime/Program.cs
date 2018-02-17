using System;
using System.Linq;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace Prime
{
    
    class MainClass
    {   
        public static bool IsPrime(int x)
        {
            if (x == 1) return false;
            if (x == 2) return true;
            if (x % 2 == 0) return true;
            var sqrt = (int)Math.Floor(Math.Sqrt(x));
            for (int i = 3; i <= sqrt; i += 2)
                if (x % i == 0) return false;
                return true;
        }

        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"/Users/macbook/Documents/PP2/Example.txt");
            StreamWriter sw = new StreamWriter(@"/Users/macbook/Documents/PP2/Sw.txt");
                
            string s = sr.ReadLine();
            string[] token = s.Split();
            int min = int.Parse(token[0]);
            foreach(var number in token)
            {
                int x = int.Parse(number);
                for (int i = 0; i < s.Length;i++)
                {
                    if(min>x){
                        min = x;
                    }
                }
            }
            //Console.WriteLine(min);
            sw.WriteLine(min);
            sw.Close();
            Console.ReadKey();

           /*List<int> list = new List<int>();
            foreach(var number in token)
            {
                x = Int32.Parse(number);
                if(IsPrime(x))
                {
                    for (i)
                }
            }
            list.Min(x);
            Console.WriteLine(x);
            Console.ReadKey();*/
                              
        }
    }
}
