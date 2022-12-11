using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Series
{
    class Program
    {
        static void Main(string[] args)
        {
            int fb1 = 0, fb2 = 1, fb, x, num;

            Console.WriteLine("Enter the number of elements: ");
            num = int.Parse(Console.ReadLine());
            Console.Write(fb1 + " " + fb2 + " ");

            for(x = 2; x < num; ++x)
            {
                fb = fb1 + fb2;
                Console.Write(fb + " ");
                fb1 = fb2;
                fb2 = fb;
            }
        }
    }
}
