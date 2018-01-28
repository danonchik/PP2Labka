using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primemin
{
    class Program
    {
        static void Main(string[] args)
        {
            int cnt = 0;
            List<int> k = new List<int>();
            StreamReader SR = new StreamReader(@"C:/Users/777/Desktop/dana.txt");
            string s = SR.ReadLine();
            string[] d = s.Split(' ');
            int[] t = new int[d.Length];
            for (int i = 0; i < d.Length; i++)
            {
                t[i] = int.Parse(d[i]);
            }
            for(int i = 0; i < d.Length; i++)
            {
                bool ok = true;
                for (int j = 2; j * j <= t[i]; j++)
                {
                    if (t[i] % j == 0)
                    {
                        ok = false;
                        break;
                    }
                    else
                    {
                        ok = true;
                    }
                }
                
                if(ok && t[i] != 1)
                {
                    k.Add(t[i]);
                    cnt++;
                    
                }
                else
                {
                    continue;
                }
            }
            int[] pr = new int[cnt];
            int minn = pr[0];
            for(int i = 0; i < cnt; i++)
            {
                pr[i] = k[i];
            }
            for(int i = 0; i < pr.Length; i++)
            {
                if (pr[i] < minn)
                {
                    minn = pr[i];
                }
            }
            Console.WriteLine(minn);
            
            Console.ReadKey();
        }
    }
}
