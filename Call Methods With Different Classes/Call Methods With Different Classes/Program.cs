using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Calls
{
    class HighestFinder
    {
        public int highNum(int num1, int num2)
        {
            int result;

            if(num1 > num2)
            {
                result = num1;
            }
            else
            {
                result = num2;
            }

            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int x = 30;
            int y = 50;
            int output;

            HighestFinder h = new HighestFinder();

            output = h.highNum(x, y);

            Console.WriteLine("The highest value is: {0}", output);

            Console.ReadKey();
        }
    }
}
