using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z = 0, flag = 0;

            Console.Write("Enter a number to check for prime: ");
            x = int.Parse(Console.ReadLine());

            z = x / 2;

            for(y = 2; y <= z; y++)
            {
                if(x % y == 0)
                {
                    Console.Write("This is not a prime number");
                    flag = 1;
                    break;
                }                
            }
            if(flag == 0)
            {
                Console.Write("This is a prime number");
            }
        }
    }
}
