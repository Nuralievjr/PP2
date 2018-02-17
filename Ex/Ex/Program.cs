using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace PrimeNumber
{
    class Prime
    {
        public static bool IsPrime(int x)
        {
            if (x == 1) return false;
            if (x == 2) return true;
            if (x % 2 == 0) return false;

            var sqrt = (int)Math.Floor(Math.Sqrt(x));

            for (int i = 3; i <= sqrt; i += 2)
            {
                if (x % i == 0) return false;
            }

            return true;
        }


        class MainClass
        {

        }
        private static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"/Users/macbook/Documents/PP2/Example.txt");
            StreamWriter sw = new StreamWriter(@"/Users/macbook/Documents/PP2/Sw.txt");
            //string s = Console.ReadLine();
            //
            var list = new List<int>();
            string s = sr.ReadLine();
            //Console.WriteLine(s);
            string[] tokens = s.Split();
            //Console.WriteLine(tokens);

            foreach (var number in tokens)
            {
                int num = Int32.Parse(number);

                //Console.WriteLine(num);
                if (IsPrime(num))
                {

                    list.Add(num);



                    //Console.Write(min);
                    //Console.ReadKey();

                }


            }
            int min = list.Min();
            sw.WriteLine(min);
            sw.Close();

            //.ReadKey();
        }

    }
}
