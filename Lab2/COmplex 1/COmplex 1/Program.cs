using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex_1
{
    class Complex
    {
        public int x;
       public  int y;
        public Complex(){}
        public Complex(int _x,int _y)
        {
            x = _x;
            y = _y;
        }
        public override string ToString()
        {
            return x + " " + y;
        }
        public int Gcd(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else if (b > a)
                {
                    b = b - a;
                }
            }
            return Gcd(a, b);

        }
        public int Lcm(int a, int b)
        {
            
            int cml = a * b;
            int res  = cml / Gcd(a, b);
            return res;
        }
        public static Complex operator+(Complex c1, Complex c2)
        {
            Complex n = new Complex();
            n.y= Lcm(c1.y, c2.y);
            c1.x = (n.y / c1.y) * c1.x;
            c2.x = (n.y / c2.y) * c2.x;
            n.x = c1.x + c2.x;
            return n;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex(2, 4);
            Complex c2 = new Complex(3, 5);
            Complex result = new Complex();
            result = c1 + c2;
        }
    }
}
