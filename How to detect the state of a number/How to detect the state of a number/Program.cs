using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Of_A_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            Console.Write("Enter some number: ");
            x = int.Parse(Console.ReadLine());

            if(x > 0)
            {
                Console.Write("This is a positive number");
            }
            else if(x == 0)
            {
                Console.Write("This is a zero");
            }
            else
            {
                Console.Write("This is a negative number");
            }
        }
    }
}
