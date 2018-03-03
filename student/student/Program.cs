using System;
using System.Linq;
using System.Collections.Generic;
namespace student
{   
  
    
    class MainClass
    {   
        static void ReadInfo()
        {
            string s = Console.ReadLine();
            string[] token = s.Split();
            int min = 0;//int.Parse(token[0]);
            int max = 0;

            foreach (var number in token)
            {
                int x = int.Parse(number);
                for (int i = 0; i < s.Length;i++)
                {
                    if(max<x){
                        max = x;
                    }
                    if(min>x)
                    { min = x;}
                   
                }

            }
            Console.WriteLine(max+" " + min);
            Console.ReadKey();
        }

        public static void Main(string[] args)
        {
            ReadInfo();

        }
    }
}
