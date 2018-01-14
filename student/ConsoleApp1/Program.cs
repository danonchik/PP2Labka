using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myarr = new List<int>();
            for(int i = 0; i < args.Length; i++)
            {
                myarr.Add(int.Parse(args[i]));
            }
            for(int i = 0; i < myarr.Count; i++)
            {
                bool ok = true;
                for(int j = 2; j <= Math.Sqrt(myarr[i]); j++)
                {
                    if (myarr[i] % j == 0)
                    {
                        ok = false;
                        break;
                    }
                }
                if (ok && myarr[i] != 1)
                {
                    Console.WriteLine(myarr[i]);
                }
                else continue;
            }
            Console.ReadKey();
            



        }
    }
}
