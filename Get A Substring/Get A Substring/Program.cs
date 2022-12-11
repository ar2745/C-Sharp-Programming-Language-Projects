using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_A_Subtstring
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "This is a sub string of Mr. Peter";
            string subname = name.Substring(24);

            Console.WriteLine(name);
            Console.WriteLine(subname);

            Console.ReadKey();
        }
    }
}
