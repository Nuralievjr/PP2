using System;

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
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] tokens = s.Split();
            foreach(var number in tokens){
                int num=Int32.Parse(number);
                //Console.WriteLine(num);
                if(IsPrime(num))
                {
                    Console.WriteLine("The Prime number is " + num );
                }


            }

        }
    }
}
