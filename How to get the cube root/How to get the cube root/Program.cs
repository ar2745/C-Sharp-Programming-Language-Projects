using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cube_Root
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any number: ");
            double num1 = double.Parse(Console.ReadLine());

            double result = Math.Ceiling(Math.Pow(num1, (double)1 / 3));

            Console.WriteLine("The result of the cube root is {0}", result);

            Console.ReadKey();
        }
    }
}
