using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;

            while(x <= 100)
            {
                Console.WriteLine("The new value of x is {0}", x);
                x++;
            }

            Console.ReadKey();
        }
    }
}
