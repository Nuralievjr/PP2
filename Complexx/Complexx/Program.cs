using System;

namespace Complexx
{   
    class Comlpex
    {
        int a;
        int b;
        public Comlpex(){ }
        public Comlpex(int x, int y)
        {
            this.a = x;
            this.b = y;
        }

        public static Comlpex operator +(Comlpex c1, Comlpex c2)
        {
            int gener = c1.b * c2.b;
            Comlpex res = new Comlpex((c1.a*(gener/c1.b))+(c2.a*(gener/c2.b)), gener);
            return res;
        }
        public override string ToString()
        {
            return a+ "/" +b;
        }

        static public Comlpex ReadComplex() {
            string s = Console.ReadLine();
            string[] a = s.Split('/');
            int c1 = int.Parse(a[0]);
            int c2 = int.Parse(a[1]);
            return new Comlpex(c1, c2);

        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            Comlpex a = Comlpex.ReadComplex();
            Comlpex b = Comlpex.ReadComplex();
            Comlpex res = new Comlpex();
            res = a + b;
            Console.WriteLine(res);
            Console.ReadKey();
            /*string s1 = Console.ReadLine();

            string[] s22 = s2.Split('/');
            int s21 = int.Parse(s22[0]);
            int s22 = int.Parse(s22[1]);
            Comlpex c1 = new Comlpex(c11, c12);
            Comlpex c2 = new Complex(s21, s22);
            Comlpex */


        }
    }
}
