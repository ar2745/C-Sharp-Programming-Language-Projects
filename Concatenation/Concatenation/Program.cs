using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concatenation
{
    class Program
    {
        static void Main (string[] args)
        {
            string hello = "Welcome";
            string name = "Peter";
            int age = 24;
            int x = 9;
            int y = 12;
            int z = x + y;

            Console.WriteLine(hello + " " + name + ", " + "Your age is " + age);
            Console.WriteLine("The result is " + z);
            Console.ReadKey();
        }
    }
}
