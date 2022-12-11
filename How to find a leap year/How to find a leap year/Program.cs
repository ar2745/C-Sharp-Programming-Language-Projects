using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leap_Year
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any year to check if it is a leap year: ");
            int x = Convert.ToInt32(Console.ReadLine());

            if(x % 4 == 0)
            {
                Console.WriteLine("This is a leap year");
            }
            else
            {
                Console.WriteLine("This is not a leap year");
            }
        }
    }
}
