using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value_Parameter
{
    class Program
    {
        public void OutputNum(out int x)
        {
            int insert = 30;
            x = insert;
        }
        static void Main(string[] args)
        {
            int y = 80;
            Program p = new Program();

            Console.WriteLine("Value of y before calling method: {0}", y);

            p.OutputNum(out y);

            Console.WriteLine("Value of y after calling method: {0}", y);

            Console.ReadKey();
        }
    }
}
