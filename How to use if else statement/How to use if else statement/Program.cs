using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Use_Of_If_Statememnt
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            Console.Write("Enter first number: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("Ener second number: ");
            y = int.Parse(Console.ReadLine());

            if(x > y)
            {
                Console.WriteLine("{0} is greater than {1}", x, y);
            }
            else
            {
                Console.WriteLine("{0} is greater than {1}", y, x);
            }
        }
    }
}
