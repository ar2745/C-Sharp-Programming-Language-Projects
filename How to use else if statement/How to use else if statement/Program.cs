using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Use_Of_Else_If_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            Console.Write("Enter any number to check if it is even or odd: ");
            x = int.Parse(Console.ReadLine());

            if(x % 2 == 0)
            {
                Console.WriteLine("This is an even number");
            }
            else if(x % 2 != 0)
            {
                Console.WriteLine("This is an odd number");
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
        }
    }
}
