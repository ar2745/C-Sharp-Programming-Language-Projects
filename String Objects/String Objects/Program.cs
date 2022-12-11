using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = "Jamaica";
            string[] countries = { "Nigeria", "Argentina", "India", "USA" };
            string firstName, lastname, surName;

            firstName = "Peter";
            lastname = "Paul";
            surName = "James";

            char name = 'e';
            char[] hello = { 'H', 'e', 'l', 'l', 'o' };

            string names = firstName + " " + lastname + " " + surName;

            Console.WriteLine(names);

            string world = String.Join(" ", countries);

            Console.WriteLine("The names of the countries are {0}", world);

            string charPrint = new string(hello);

            Console.WriteLine(charPrint);

            DateTime DT = new DateTime(2022, 09, 22, 15, 35, 1);
            string newDT = String.Format("Today's date is: {0}", DT);

            Console.WriteLine(newDT);

            Console.ReadKey();
        }
    }
}
