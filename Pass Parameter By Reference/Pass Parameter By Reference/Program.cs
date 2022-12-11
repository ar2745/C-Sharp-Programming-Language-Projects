using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reference_Parameter
{
    class Program
    {
        public void numSwap(ref int x, ref int y)
        {
            int change;

            change = x;
            x = y;
            y = change;
        }
        static void Main(string[] args)
        {
            int w = 50;
            int z = 80;

            Program p = new Program();

            Console.WriteLine("The value of w before swapping is: {0}", w);
            Console.WriteLine("The value of z before swapping is: {0}", z);

            p.numSwap(ref w, ref z);

            Console.WriteLine("The value of w after swapping is: {0}", w);
            Console.WriteLine("The value of z after swapping is: {0}", z);

            Console.ReadKey();
        }
    }
}
