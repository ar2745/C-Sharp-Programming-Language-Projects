using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        public int higherNum(int num1, int num2)
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

        static void Main(string[] args)
        {
            int x = 300;
            int y = 50;
            int output;

            Program p = new Program();

            output = p.higherNum(x, y);

            Console.WriteLine("The highest value is: {0}", output);

            Console.ReadKey();
        }
    }
}
