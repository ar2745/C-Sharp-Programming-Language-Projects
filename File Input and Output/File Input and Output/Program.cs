using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_Input_and_Output
{
    class Program
    {
        static void writeFile(string Fname)
        {
            File.WriteAllText(Fname, "Hello World");
        }
        static void readFile(string Fname)
        {
            Console.WriteLine(File.ReadAllText(Fname));
        }
        static void Main(string[] args)
        {
            string Fname = @"C:\Users\ar274\Desktop\Demo.txt";

            writeFile(Fname);
            readFile(Fname);
        }
    }
}
