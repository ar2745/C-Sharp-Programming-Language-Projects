using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Cases
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "This Is Hello";
            string nameLow = name.ToLower();
            string nameHigh = name.ToUpper();

            Console.WriteLine("This lowercase value is: {0}", nameLow);

            Console.WriteLine("This uppercase value is: {0}", nameHigh);

            Console.ReadKey();
        }
    }
}
