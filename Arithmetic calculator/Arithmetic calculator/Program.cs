using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, sum, sub, mul, div;

            Console.Write("Enter first number: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            b = double.Parse(Console.ReadLine());

            sum = a + b;
            sub = a - b;
            mul = a * b;
            div = a / b;

            Console.WriteLine("Addition of {0} and {1}: {2}", a, b, sum);
            Console.WriteLine("Subtraction of {0} and {1}: {2}", a, b, sub);
            Console.WriteLine("Multiplication of {0} and {1}: {2}", a, b, mul);
            Console.WriteLine("Division of {0} and {1}: {2}", a, b, div);
        }
    }
}
