using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_and_Time
{
    class Program
    {
        static void Main (string[] args)
        {
            DateTime DT = new DateTime(2022, 09, 10, 13, 52, 12);
            string printdt = string.Format("The time is {0:t} on today {0:D}", DT);

            Console.WriteLine(printdt);
            Console.ReadKey();
        }
    }
}
