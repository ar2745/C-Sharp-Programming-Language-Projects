using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decimal_to_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            int[] z = new int[20];

            Console.Write("Enter a decimal number: ");
            x = int.Parse(Console.ReadLine());

            for(y = 0; x > 0; y++)
            {
                z[y] = x % 2;
                x = x / 2;
            }
            Console.Write("Binary equivalent: ");
            for(y = y - 1; y >= 0; y--)
            {
                Console.Write(z[y]);
            }
        }
    }
}
 