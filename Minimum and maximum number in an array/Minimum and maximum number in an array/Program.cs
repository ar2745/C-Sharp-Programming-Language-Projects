using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimum_And_Maximum_Number_In_An_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 4, 78, 98, 3, 0, 3, 12, 78, 95, 32, 67 };

            Console.WriteLine("The maximum number = " + arr1.Max());
            Console.WriteLine("The minimum number = " + arr1.Min());
        }
    }
} 