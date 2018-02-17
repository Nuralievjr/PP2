using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ComplexApp
{
    //[Serializable]
    class Complex
    {
        public int a, b;
        public Complex(int v) { }
        public Complex( int x, int y)
        {
            this.a = x;
            this.b = y;
        }

        public Complex Divide(Complex c)
        {
            Complex res = new Complex(this.a * c.b /  this.b * c.a);
            return res;

        }

        public static Complex operator /(Complex c1, Complex c2)
        {
            Complex res = new Complex((c1.a*c2.b)/(c1.b/c2.a));
            //res.Simplify();
            return res;
        }

        /*public void Simplify()
        {
            int _a = this.a;
            int _b = this.b;

            while (_a > 0 && _b > 0)
            {
                if (_a > _b)
                    _a = _a % _b;
                else
                    _b = _b % _a;
            }
            int gcd = _a + _b;
            this.a /= gcd;
            this.b /= gcd;
        }
        /* static void Serialization()
         {
             XmlSerializer xs = new XmlSerializer(typeof(Complex));
             FileStream fs = new FileStream("data.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
             xs.Serialize(fs, Complex);
             fs.Close();

         */
    }

    class Program
    {
        static void Main(string[] args)
        {

            string s = Console.ReadLine();
            string[] token = s.Split();
            Complex result = new Complex(0, 0);
            foreach (string t in token)
            {
                string[] arr = t.Split('\\');
                Complex cmp = new Complex(int.Parse(arr[0]), int.Parse(arr[1]));
                result = result / cmp;
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
