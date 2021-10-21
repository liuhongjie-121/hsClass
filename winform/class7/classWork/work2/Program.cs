using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入圆的半径:");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("周长：" + MyArith.Perimeter(num1));
            Console.WriteLine("面积：" + MyArith.Area(num1));
            Console.WriteLine("体积" + MyArith.Volum(num1));
            Console.ReadKey();
        }
    }
}
