using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_Conversions
{
    class Program
    {
        static void Main (string[] args)
        {
            // First example
            Console.WriteLine("Enter a number ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter another number ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            
            //Second example
            Console.WriteLine("Enter a number ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 / num2);

            Console.ReadKey();
        }
    }
}
