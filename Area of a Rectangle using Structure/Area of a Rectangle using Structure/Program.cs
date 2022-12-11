using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initialize_Structure_Without_New_Keyword
{
    class Program
    {
        public struct AreaRectangle
        {
            public int x, y;
            public AreaRectangle(int length, int breadth)
            {
                x = length;
                y = breadth;
            }
        }
        static void Main(string[] args)
        {
            AreaRectangle AreaR;

            AreaR.x = 15;
            AreaR.y = 9;
            int Area = AreaR.x * AreaR.y;

            Console.WriteLine("The area of the rectangle is: {0}", Area);
        }
    }
}
