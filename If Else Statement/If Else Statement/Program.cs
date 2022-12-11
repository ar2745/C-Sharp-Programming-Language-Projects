using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Else_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 19;
            int y = 2;

            if (x == 19 && y == 2)
            {
                Console.WriteLine("This condition is true and the value is {0}", x + y);
            }
            else
            {
                Console.WriteLine("This condition is false and the value is {0}", x - y);
            }
            Console.ReadKey();
        }
    }
}

