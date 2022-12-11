using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_The_HCF
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z, hcf = 0;

            Console.Write("Enter first number: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            y = int.Parse(Console.ReadLine());

            for (z = 1; z <= x || z <= y; ++z)
            {
                if(x % z == 0 && y % z == 0)
                {
                    hcf = z;
                }
            }

            Console.Write("The HCF = {0}", hcf);
        }
    }
}
