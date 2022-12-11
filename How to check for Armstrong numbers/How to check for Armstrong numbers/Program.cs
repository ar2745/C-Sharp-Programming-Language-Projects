using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armstrong_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, sum = 0, add;

            Console.Write("Enter a number to check for armstrong: ");
            x = int.Parse(Console.ReadLine());

            add = x;

            do
            {
                y = x % 10;
                sum = sum + (y * y * y);
                x = x / 10;

            } while (x != 0);

            if(add == sum)
            {
                Console.Write("This is an armstrong number");
            }
            else
            {
                Console.Write("This is not an armstrong number");
            }
        }
    }
}
