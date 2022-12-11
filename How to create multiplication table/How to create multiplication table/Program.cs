using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_Table_Using_A_while_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y = 1;

            Console.Write("Choose a number: ");
            x = int.Parse(Console.ReadLine());

            while(y <= 14)
            {
                Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
                y++;
            }
        }
    }
}
