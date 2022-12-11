using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int factorial = 1, x, num;

            Console.Write("Enter any number to get its factorial: ");
            num = int.Parse(Console.ReadLine());

            for(x = 1; x <= num; x++)
            {
                factorial = factorial * x;
            }
            Console.Write("The result of factorial " + num + " is " + factorial);
        }
    }
}
