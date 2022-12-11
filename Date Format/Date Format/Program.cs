using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display_Date_Formats
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime DT = new DateTime(2022, 09, 16);

            Console.WriteLine("Date and Time is: {0}", DT);
            Console.WriteLine(DT.ToString("yyyy-MM-dd"));
            Console.WriteLine(DT.ToString("dd-MM-yyyy"));
            Console.WriteLine(DT.ToString("MM-dd-yyyy"));
            Console.WriteLine(DT.ToString("M/d/yyyy"));
            Console.WriteLine(DT.ToString("M/d/yy"));

        }
    }
}
