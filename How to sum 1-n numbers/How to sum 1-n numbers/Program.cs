using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_N_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, num1, sum = 0;

            Console.Write("Enter the Nth number: ");
            x = int.Parse(Console.ReadLine());

            for(num1 = 1; num1 <= x; num1++)
            {
                sum = sum + num1;
            }
            Console.WriteLine("The sum of numbers from 1 to " + x + " = " + sum);
        }
    }
}
