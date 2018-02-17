using System;

namespace Circle
{   
    class Circle
    {
        public double radius;
        static double pi = 3.14;
        public void FindArea() { }
        public void FindArea(double rad)
        {
            this.radius = rad;
            Console.WriteLine("The Area is " + pi*rad*rad);
        }
        public void FindDiametr(double ra)
        {
            this.radius = ra;
            Console.WriteLine("The Diametr is " + ra*2);
        }
        public void FindCircumference(double r)
        {
            this.radius = r;
            Console.WriteLine("The Circumference is " + pi*2*r);
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            Circle first = new Circle();
            string s1 = Console.ReadLine();
            double r = double.Parse(s1);
            first.FindArea(r);
            first.FindDiametr(r);
            first.FindCircumference(r);
           
        }
    }
}
