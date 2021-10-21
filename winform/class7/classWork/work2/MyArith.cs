using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work1
{
    class MyArith
    {
        public static double PI = 3.14d;
        // 周长
        public static double Perimeter(double num1)
        {
            return 2 * num1 * PI;
        }
        // 面积
        public static double Area(double num1)
        {
            return Math.Pow(num1,2) * PI;
        }
        // 体积
        public static double Volum(double num1)
        {
            return 3/4 * PI * Math.Pow(num1,3);
        }     
    }
}
