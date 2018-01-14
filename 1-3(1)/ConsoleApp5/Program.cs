using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isprime = true;
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; //my array;
            for (int i = 0; i < arr.Length; i++)   //пробегаемся ;
            {
                for (int j = 2; j * j <= arr[i]; j++)  
                {
                    isprime = true;
                    if (arr[i] % j == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if (isprime && i != 0) Console.WriteLine(arr[i]);
                else continue;
            }

            Console.ReadKey();
        }

        private static int sqrt()
        {
            throw new NotImplementedException();
        }
    }
}
