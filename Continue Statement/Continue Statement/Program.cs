using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Continue_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;

            while(x <= 50)
            {
                if(x >= 20 && x <= 35)
                {
                    x++;
                    continue;
                }
                Console.WriteLine("The new value of x is: {0}", x);
                x++;
            }
            Console.ReadKey();
        }
    }
}
