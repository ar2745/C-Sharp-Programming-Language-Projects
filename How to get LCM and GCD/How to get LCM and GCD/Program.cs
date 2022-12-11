using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCM_and_GCD 
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, num1, num2, result, lcm, gcd;

            Console.Write("Enter first number: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            y = int.Parse(Console.ReadLine());

            num1 = x;
            num2 = y;

            do
            {
                result = num2;
                num2 = num1 % num2;
                num1 = result;

            } while (num2 > 0);

            gcd = num1;
            lcm = (x * y) / gcd;

            Console.WriteLine("The LCM of {0} and {1} is: {2}", x, y, lcm);
            Console.WriteLine("The GCD of {0} and {1} is: {2}", x, y, gcd);
        }
    }
}
