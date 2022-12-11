using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_Using_A_For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            Console.Write("Choose a number: ");
            x = int.Parse(Console.ReadLine());

            for(y = 1; y <= 10; y++)
            {
                Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
            }
        }
    }
}
