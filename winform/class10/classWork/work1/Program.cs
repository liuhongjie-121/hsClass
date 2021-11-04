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
            User u1 = new User();
            Console.Write("请输入姓名:");
            u1.SetName(Console.ReadLine());
            Console.Write("请输入性别:");
            u1.SetName(Console.ReadLine());
            Console.WriteLine("姓名是:"+u1.GetName());           
            string sex = u1.GetSex();
            if (string.IsNullOrEmpty(sex)) Console.WriteLine("您输入的性别可能不规范");
            else Console.WriteLine("性别是:" + sex);
            Console.ReadLine();
        }
    }
}
