using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 使用格利高利公式求PI的近似值
            int flag = 1;
            int t = 1;
            double item = 1.0;
            double pi = 0.0;
            while (Math.Abs(item) >= Math.Pow(10,-6))
            {
                item = flag * 1.0 / t;
                pi = pi + item;
                flag = -flag;
                t = t + 2;
            }
            pi = pi * 4;
            Console.WriteLine(string.Format("PI={0}",pi));
            Console.ReadKey();
        }
    }
}
