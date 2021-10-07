using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1,打印九九乘法表
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < i+1; j++)
                {
                    Console.Write(i+"*"+j+"="+i*j+"\0");
                }
                Console.WriteLine();
            }
        }
    }
}
