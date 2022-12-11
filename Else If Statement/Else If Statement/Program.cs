using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Else_If_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            double x = Convert.ToInt32(Console.ReadLine());
                        
            if (x < 20)
            {
                Console.WriteLine("This is less than 20");
            }
            else if (x < 30)
            {
                Console.WriteLine("This is less than 30");
            }
            else if (x < 40)
            {
                Console.WriteLine("This is less than 40");
            }
            else
            {
                Console.WriteLine("Invalid number");
            }

            Console.ReadKey();
        }
    }
}
