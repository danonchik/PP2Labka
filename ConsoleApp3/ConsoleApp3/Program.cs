using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
     class student {
        public string name;
        public string surname;
        public string nationality;
        public int age;
        public int hmcitf;
        public student(){
            name="Dana";
            surname="Sidakina";
            nationality="Kazakh";
            age=18;
            hmcitf=1;
        }
        public override string ToString()
        {
            return name + " " + surname + " " + nationality + " " + age + " " + hmcitf;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            student girl = new student();
            girl.name = "Asem";
            girl.surname = "Dosniyaz";
            girl.nationality = "Kazakh";
            girl.age = 17;
            girl.hmcitf = 2;
            string info=girl.ToString();
            Console.WriteLine(info);
            student first = new student();
            Console.WriteLine(first.ToString());
            /* without Console.Readkey() because I will push  CTRL+F5. */
        }
    }
}
