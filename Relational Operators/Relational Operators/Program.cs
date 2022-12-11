using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relational_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 20;
            int y = 10;

            if(x == y) //Equivalent
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            if (x != y) //Not equivalent
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            
            if (x > y) //Greater than
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            if (x < y) //Less than
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
