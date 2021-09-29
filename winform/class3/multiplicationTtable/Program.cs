using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplicationTtable
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exitConsole = false;                       
            while (!exitConsole) {
                Console.Write("请输入1,2,3访问不同的型号的乘法表，输入任意内容结束：");
                string readStr = Console.ReadLine();
                switch (readStr) {
                    case "1":
                        {
                            Console.Write("请输入行数：");
                            int readNum = int.TryParse(Console.ReadLine(), out int isNum) ? isNum : 9;
                            for (int i = 1; i < readNum + 1; i++)
                            {
                                for (int j = 1; j < readNum + 1; j++)
                                {
                                    Console.Write(i + "*" + j + "=" + i * j + "\0");
                                }
                                Console.WriteLine();
                            }
                            break;
                        }
                        
                    case "2":
                        {
                            Console.Write("请输入行数：");
                            int readNum = int.TryParse(Console.ReadLine(), out int isNum) ? isNum : 9;
                            for (int i = 1; i < readNum + 1; i++)
                            {
                                for (int j = 1; j <= i; j++)
                                {
                                    Console.Write(i + "*" + j + "=" + i * j + "\0");
                                }
                                Console.WriteLine();
                            }
                            break;
                        }
                        
                    case "3":
                        {
                            Console.Write("请输入行数：");
                            int readNum = int.TryParse(Console.ReadLine(), out int isNum) ? isNum : 9;
                            //for (int i = 1; i < readNum + 1; i++)
                            //{
                            //    for (int j = 1; j <= i; j++)
                            //    {
                            //        Console.Write(i + "*" + j + "=" + i * j);
                            //    }
                            //    Console.WriteLine();
                            //}
                        }
                        
                        break;
                    default:
                        exitConsole = true;
                        break;
                }
            }
        }
    }
}
