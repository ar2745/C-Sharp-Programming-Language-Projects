using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greatest_Of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;

            Console.Write("Enter first number: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            y = int.Parse(Console.ReadLine());

            Console.Write("Enter third number: ");
            z = int.Parse(Console.ReadLine());

            if(x > y && x > z)
            {
                Console.WriteLine("{0} is greater than {1} & {2}", x, y, z);
            }
            else if(y > x && y > z)
            {
                Console.WriteLine("{0} is greater than {1} & {2}", y, x, z);
            }
            else
            {
                Console.WriteLine("{0} is greater than {1} & {2}", z, x, y);
            }
        }
    }
}
