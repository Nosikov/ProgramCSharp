using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Person();
            p1.Firstname = "Ivabov";
            p1.Lastname = "Petr";

            Console.WriteLine(p1.Firstname);
            

            var d1 = new Doctor();
            d1.Firstname = "Jivago";
            d1.um = 120;

            Console.WriteLine(d1.Firstname+"="+d1.um);
            Console.ReadLine();

        }
    }
}
