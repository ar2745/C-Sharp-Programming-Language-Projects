using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitwise_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 20;
            int y = 15;
            int z = 0;
            int z1 = x & y;
            int z2 = x | y;
            int z3 = x ^ y;
            int z4 = ~x;
            int z5 = x << 2;
            int z6 = ~y;
            int z7 = y >> 2;

            Console.WriteLine("The result of z is {0}", z1);

            Console.ReadKey();
        }
    }
}
