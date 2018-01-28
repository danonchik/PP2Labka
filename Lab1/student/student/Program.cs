using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace asem1
{
    class Student
    {
        public string name;
        public string surname;
        public int age;
        public string fac;
        public Student()
        {
            name = "Asem";
            surname = "Dosniyaz";
            age = 17;
            fac = "FIT";
        }
        public override string ToString()
        {
            return name + " " + surname + " " + age + " " + fac;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student M = new Student ();
            Console.WriteLine(M);

            Console.ReadKey();
        }
    }
}
