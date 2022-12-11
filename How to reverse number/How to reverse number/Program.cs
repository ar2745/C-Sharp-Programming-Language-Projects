using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, reverse = 0;

            Console.Write("Enter some digits: ");
            x = int.Parse(Console.ReadLine());

            while(x > 0)
            {
                y = x % 10;
                reverse = reverse * 10 + y;
                x /= 10;
            }
            Console.Write("The reverse number: " + reverse);
        }
    }
}
