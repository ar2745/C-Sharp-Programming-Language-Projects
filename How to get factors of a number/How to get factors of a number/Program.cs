using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factors_Of_A_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            Console.Write("Enter a number: ");
            x = int.Parse(Console.ReadLine());

            for(y = 1; y <= x; y++)
            {
                if(x % y == 0)
                {
                    Console.WriteLine("The factors of {0} = {1}", x, y);
                }
            }
        }
    }
}
