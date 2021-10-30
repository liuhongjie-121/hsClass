using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work3
{
    class Program
    {
        static void Main(string[] args)
        {
            Squarecs sq = new Squarecs();
            Cirecle ci = new Cirecle();
            Console.WriteLine("边长为2的正方形面积为:" + sq.Area(2));
            Console.WriteLine("半径为3的圆面积为:" + ci.Area(3));
            Console.ReadKey();
        }
    }
}
