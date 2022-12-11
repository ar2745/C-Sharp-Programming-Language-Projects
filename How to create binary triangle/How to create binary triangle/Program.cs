using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y = 0, z;

            Console.Write("Enter number of rows: ");
            z = int.Parse(Console.ReadLine());

            for(int i = 1; i <= z; i++)
            {
                for(x = 1; x <= i; x++)
                {
                    if(y == 1)
                    {
                        Console.Write("0");
                        y = 0;
                    }
                    else if(y == 0)
                    {
                        Console.Write("1");
                        y = 1;
                    }
                }

                Console.Write("\n");
            }
        }
    }
}
