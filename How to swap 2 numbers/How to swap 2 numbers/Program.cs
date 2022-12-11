using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, xswap;

            Console.WriteLine("Enter first number: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("The numnbers before swapping: {0} and {1}", num1, num2);
            
            xswap = num1;
            num1 = num2;
            num2 = xswap;
            
            Console.WriteLine("The numnbers after swapping: {0} and {1}", num1, num2);
        }
    }
}
