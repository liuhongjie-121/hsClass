using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 登录
            bool isQuit = false;
            string strUser ;
            string strPassWord ;
            while (!isQuit) {
                Console.Write("请输入用户名：");
                strUser = Console.ReadLine();                
                if (strUser == "admin")
                {
                    Console.Write("请输入密码：");
                    strPassWord = Console.ReadLine();
                    if (strPassWord == "888888")
                    {
                        Console.WriteLine("登录成功");
                        isQuit = true;
                        Console.ReadKey();
                    }
                    else {
                        Console.WriteLine("密码不正确");
                    }
                }
                else {
                    Console.WriteLine("用户名不存在");
                }
            }
        }
    }
}
