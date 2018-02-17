using System;

namespace Reactangle
{
    class Rectangle
    {
        public double w;
        public double h;
        public void FindArea() { }
        public void FindArea(double x, double y )
        {
            this.w = x;
            this.h = y;


            Console.WriteLine("The Area is " + x*y);

        }
        public void FindPerimetr(){ }
        public void FindPerimetr(double x1, double y1)
        {
            this.w = x1;
            this.h = y1;

            Console.WriteLine("The Perimetr is " + 2*(x1+y1));
        }

        
    }
   
    class MainClass
    {   
        public static void Main(string[] args)
        {

            Rectangle first = new Rectangle();
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            int x = Int32.Parse(s1);
            int y = Int32.Parse(s2);
            first.FindArea(x,y);
            first.FindPerimetr(x,y);
            Console.ReadKey();
       
            
        }
    }
}
