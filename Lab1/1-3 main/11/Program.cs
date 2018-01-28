using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ok = true;
            string s = Console.ReadLine();/* мой стринг  "1 2 3 4"*/
            string[] arr = s.Split(' '); /* после чего он стал таким, {"1","2","3","4"} */
            int[] array = new int[arr.Length]; /* moi novyi massiv*/
            for(int i = 0; i < array.Length; i++) /* probegayus po massivu */
            {
                array[i] = int.Parse(arr[i]);   /* priravnivayu kazhdyi element massiva chisel k kazhdomu itomu elementu arr */
            }
            foreach(int q in array) /* funkciya foreach probegaetsya po elementam bez indeksa */
            {
                for(int j = 2; j <= Math.Sqrt(q); j++) /* dal'she kak v c++ */
                {
                    if (q % j == 0)
                    {
                        ok = false;
                        break;
                    }
                    else
                    {
                        ok = true;
                    }

                }
                if(ok && q != 1)
                {
                    Console.WriteLine(q);
                }
                else
                {
                    continue;
                }

            }
            Console.ReadKey();

        }
    }
}
