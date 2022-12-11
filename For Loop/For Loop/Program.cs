using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            
            for(x = 1; x <= 50; x++)
            {
                Console.WriteLine("The new value of x  is: {0} ", x);
            }

            Console.ReadKey();
        }
    }
}
