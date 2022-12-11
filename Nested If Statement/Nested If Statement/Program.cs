using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_If_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 34;
            int y = 9;
            int z = 5;

            if (x == 34)
            {
                Console.WriteLine("This first condition is met");
                if (y == 9)
                {
                    Console.WriteLine("This second condition is met");

                    if (z == 5)
                    {
                        Console.WriteLine("This third condition is met");
                    }
                }
                Console.WriteLine("Welcome to C# programming");
            }
            Console.ReadKey();
        }
    }
}
