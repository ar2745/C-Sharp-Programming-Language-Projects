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
            int remainder, reverse = 0;

            Console.WriteLine("Enter some numbers: ");
            int x = Convert.ToInt32(Console.ReadLine());

            do
            {

                remainder = x % 10;
                reverse = reverse * 10 + remainder;
                x /= 10;

            } while (x != 0);

            Console.WriteLine("The result of Reversed number is: {0}", reverse);
        }
    }
}
