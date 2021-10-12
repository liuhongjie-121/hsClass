

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2,求以下数列前20项之和。
            // 1/2+2/3+3/5+5/8+8/13+……
            Console.WriteLine(string.Format("结果是：{0}", Fun20(1, 2)));
            Console.ReadKey();
        }

        public static double Fun20(double f1, double f2)
        {
            if (f2 < 21)
            {
                return f1 / f2 + Fun20(f2, f1 + f2);
            }
            else
            {
                return f1 / f2;
            }
        }
    }
}
