using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;

            do
            {
                Console.WriteLine("The new value of x is: {0}", x);
                x++;
            }
            while (x <= 10);

            Console.ReadKey();
        }
    }
}
