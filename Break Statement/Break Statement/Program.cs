using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Break_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;

            while(x <= 50)
            {
                Console.WriteLine("The new value of x is: {0}", x);
                x++;

                if(x == 45)
                {
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
