using System;

namespace MaximumandMinimum
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int max = 0;
            int min = 0;
            string s = Console.ReadLine();
            string[] tokens = s.Split(' ');
            foreach(var number in tokens)
            {
                int num;
                if (Int32.TryParse(number, out num))
                {   
                }
                for (int i = 0; i < s.Length;i++)
                {
                    if(max<num){
                        max = num;
                       
                    }
                    if(min>num)
                    {
                        min = num;
                    }


                }
            Console.WriteLine("Max is " + max + "Min is "+ min);
            Console.ReadKey();

        }
    }
}
