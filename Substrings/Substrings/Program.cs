using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "This is a Hello World";

            if(name.Contains("Hello"))
            {
                Console.WriteLine("This application checks for 'Hello' in the sentence above");
            }

            Console.ReadKey();
        }
    }
}
