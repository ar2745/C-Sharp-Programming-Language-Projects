using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 7;
            int y = 5;
            double z = ++x; //Increment

            Console.WriteLine(x + y); //Addition
            Console.WriteLine(x - y); //Subtraction
            Console.WriteLine(x * y); //Multiplication
            Console.WriteLine(x / y); //Division
            Console.WriteLine(x % y); //Modulus
            Console.WriteLine(z);

            Console.ReadKey();
        }
    }
}
