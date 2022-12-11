using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class A
    {
        public int number = 50;
    }
    public class B : A
    {
        public int myNumber()
        {
            return this.number;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            B bb = new B();
            bb.myNumber();

            Console.WriteLine("The value of B is: {0}", bb.myNumber());

            Console.ReadKey();
        }
    }
}
