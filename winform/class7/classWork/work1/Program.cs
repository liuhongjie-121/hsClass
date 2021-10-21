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
            MyArith MA = new MyArith();
            Console.Write("请输入数字1:");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("请输入数字2:");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine(num1 + "+" +num2 + "=" + MA.Add(num1,num2));
            Console.WriteLine(num1 + "-" + num2 + "=" + MA.Sub(num1, num2));
            Console.WriteLine(num1 + "*" + num2 + "=" + MA.Mul(num1, num2));
            Console.WriteLine(num1 + "/" + num2 + "=" + MA.Div(num1, num2));
            Console.ReadKey();
        }
    }
}
