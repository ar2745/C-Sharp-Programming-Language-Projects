using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Inheritance
{
    public class A
    {
        public int myNumber = 50;

        public class C : A
        {
            public int GetNum()
            {
                return this.myNumber;
            }
        }
    }
    public class B : A
    {
        public int myNum()
        {
            return this.myNumber;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            B bb = new B();
            bb.myNum();

            var c = new A.C();

            Console.WriteLine("The value of B is: {0}", bb.myNum());
            Console.WriteLine("The value of C is: {0}", c.GetNum());

            Console.ReadKey();
        }
    }
}
