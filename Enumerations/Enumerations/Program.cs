using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumarations
{
    class Program
    {
        enum lang {English, Spanish, Chinese, French, Igbo};

        static void Main(string[] args)
        {
            int America = (int)lang.English;
            int Nigeria = (int)lang.Igbo;
            int China = (int)lang.Chinese;

            Console.WriteLine("Americans speak {0}", America);
            Console.WriteLine("Nigerians speak {0}", Nigeria);
            Console.WriteLine("Chinese speak {0}", China);

            Console.ReadKey();
        }
    }
}
