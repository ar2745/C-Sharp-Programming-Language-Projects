using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relational_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 19;

            if (x == 10 && y == 15) //And operator
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            if (x == 10 || y == 15) //Or operator
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            Console.ReadKey();
        }
    }
}
