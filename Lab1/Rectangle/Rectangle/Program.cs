using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Rectangle{
        int w;
        int h;
        public Rectangle(int w, int h)
        {
            this.w = w;
            this.h = h;
        }
        public static int findArea(int x, int y)
        {
            return x * y;
        }
        public static int findPerimetre(int x, int y)
        {
            return 2 * (x + y);
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is width?");
            int w = int.Parse(Console.ReadLine());
            Console.WriteLine("What is heigh?");
            int h = int.Parse(Console.ReadLine());
            Rectangle good = new Rectangle(w, h);
            Console.WriteLine("Area is-"+Rectangle.findArea(w, h));
            Console.WriteLine("Perimetre is-"+Rectangle.findPerimetre(w, h));
            Console.ReadKey();
        }
    }
}
