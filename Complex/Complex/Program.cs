using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Complex
{   
    class Complex 
    {
        public double  a;
        public double b;
        public Complex() { }
        public Complex(double x, double y)
        {
            this.a = x;
            this.b = y;
        }
        public static Complex operator /(Complex c1, Complex c2)
        {
            Complex res = new Complex((c1.a*c2.b), c1.b*c2.a);
            res.Simplify();
            return res;
        }
        public void Simplify()
        {
            double _a = this.a;
            double _b = this.b;

            while (_a > 0 && _b > 0)
            {
                if (_a > _b)
                    _a = _a % _b;
                else
                    _b = _b % _a;
            }
            // _a = 0, _b = 0 gcd(a, b) = _a + _b
            double gcd = _a + _b;
            this.a /= gcd;
            this.b /= gcd;
        }


        public override string ToString()
        {
            return a + "/" + b;
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {

            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            string[] c1 = s1.Split('/');
            string[] c2 = s2.Split('/');
            Complex cmp1 = new Complex(int.Parse(c1[0]), int.Parse(c1[1]));
            Complex cmp2 = new Complex(int.Parse(c2[0]), int.Parse(c2[1]));
            Complex res = cmp1 / cmp2;

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
