using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxandmin
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader d = new StreamReader(@"C:\Users\777\Desktop\dana.txt");
            String s = d.ReadLine();
            string[] x = s.Split(' ');
            int maxx = int.Parse(x[0]);
            for (int i = 0; i < x.Length; i++)
            {
                if (maxx < int.Parse(x[i])) maxx = int.Parse(x[i]);
            }
            int minn = int.Parse(x[0]);
            for (int i = 0; i < x.Length; i++)
            {
                if (minn > int.Parse(x[i])) minn = int.Parse(x[i]);
            }
            Console.WriteLine(maxx + " " + minn);
            Console.ReadKey();

        }
    }
}
