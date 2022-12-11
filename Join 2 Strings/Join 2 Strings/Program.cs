using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Join_2_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name1 = { "This is Peter", "Hello Paul", "Today is Sunday the Eleventh"};
            string[] name2 = { "Monday", "Tuesday", "Wednesday", "Thurday", "Friday"};

            string joinedString = String.Join("\n", name1);
            string week = String.Join(", ", name2);

            Console.WriteLine(joinedString);
            Console.WriteLine("The days of the week are: {0}", week);

            Console.ReadKey();
        }
    }
}
