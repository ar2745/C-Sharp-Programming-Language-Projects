using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_and_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            Console.Write("Enter a number: ");
            x = int.Parse(Console.ReadLine());

            if(x % 2 == 0)
            {
                Console.WriteLine("This is an even number");
            }
            else
            {
                Console.WriteLine("This is an odd number");
            }
        }
    }
}
