using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_of_Number_Using_Recursion
{
    class Program
    {
        static long power(int x, int y)
        {
            if (y != 0)
            {
                return (x * power(x, y - 1));
            }
            return 1;
        }
        static void Main(string[] args)
        {
            int x = 10;
            int y = 2;
            long result;

            result = power(x, y); ;

            Console.WriteLine("The result of the power is: {0}", result);
        }
    }
}
