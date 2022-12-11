using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangular_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;

            Console.Write("Enter number of rows: ");
            int num = int.Parse(Console.ReadLine());

            for(x = 1; x <= num; x++)
            {
                for(y = x; y < num; y++)
                {
                    Console.Write(" ");
                }

                for(z = 1; z < (x * 2); z++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
