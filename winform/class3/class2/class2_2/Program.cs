using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isQuit = false;
            // 验证密码
            string strPassWord;
            while (!isQuit) {
                Console.Write("请输入密码：");
                strPassWord = Console.ReadLine();
                if (strPassWord == "888888")
                {
                    Console.WriteLine("正确");
                    isQuit = true;
                    Console.ReadKey();
                }
                else {
                    Console.WriteLine("错误");
                }
            }

        }
    }
}
