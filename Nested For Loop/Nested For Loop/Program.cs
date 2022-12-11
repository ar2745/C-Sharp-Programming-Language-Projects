using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            for(x = 2; x < 50; x++)
            {
                for (y = 2; y <= (x / y); y++)
                {
                    if ((x % y) == 0)
                    {
                        break;
                    }
                }
                if(y > (x/y))
                {
                    Console.WriteLine(x + " is a prime number");
                }
            }
            Console.ReadKey();
        }
    }
}
