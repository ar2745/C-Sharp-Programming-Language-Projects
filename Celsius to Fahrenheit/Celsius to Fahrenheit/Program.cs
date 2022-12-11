using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conver_from_Celsius_to_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number in Celsius: ");
            int c = Convert.ToInt32(Console.ReadLine());

            int f = (c * 9) / 5 + 32;

            Console.WriteLine("The result in Fahrenheit is: {0}", f);
        }
    }
}
