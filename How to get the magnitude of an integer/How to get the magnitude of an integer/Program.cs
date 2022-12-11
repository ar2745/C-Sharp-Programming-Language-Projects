using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magnitude_Of_An_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y = 0;

            Console.Write("Enter some numbers: ");
            x = int.Parse(Console.ReadLine());

            do
            {
                y++;
                x = x / 10;
            } while (x != 0);

            Console.WriteLine("The magnitude = {0}", y);
        }
    }
}
