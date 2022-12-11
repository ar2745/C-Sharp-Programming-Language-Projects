using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 15;
            int y = 9;
            int z;

            y += x;
            z = x;
            z += x;
            z -= x;
            z *= x;
            z /= x;

            Console.WriteLine("The result of y is {0}", y);
            Console.WriteLine("The result of z is {0}", z);

            Console.ReadKey();
        }
    }
}
