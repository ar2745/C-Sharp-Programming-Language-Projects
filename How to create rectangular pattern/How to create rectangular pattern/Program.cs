using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangular_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            for(x = 1; x <= 7; x++)
            {
                for(y = 1; y < x; y++)
                {
                    Console.Write(" ");
                }

                for(y = 1; y <= 7; y++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
