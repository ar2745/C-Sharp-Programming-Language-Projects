using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, reverse, sum = 0;

            Console.Write("Enter some numbers to check for palindrome: ");
            x = int.Parse(Console.ReadLine());
            reverse = x;

            do
            {
                y = x % 10;
                sum = (sum * 10) + y;
                x = x / 10;

            } while (x != 0);

            if(reverse == sum)
            {
                Console.Write("This is a palindrome");
            }
            else
            {
                Console.Write("This is not a palindrome");
            }
        }
    }
}
