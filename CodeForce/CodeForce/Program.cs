using System;

namespace WordsinSentences
{

    class MainClass
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int k = Int32.Parse(s);
            //int givenumber = 0;
            int count = 0;
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            for (int i = 1; i <= 10000; i++)
            {
                
                a = i / 10000;
                b = (i / 1000) % 10;
                c = (i / 100) % 10;
                d = i % 10;
                if ((a + b + c + d) == 10)
                {
                    count++;
                   
                }
                if (k == count)
                {   
                    Console.WriteLine(i);
                    break;

                }


            }
            Console.WriteLine("a=" + a + " b=" + b + " c=" + c + " d=" + d);
           
            Console.ReadKey();
        }
    }
}
