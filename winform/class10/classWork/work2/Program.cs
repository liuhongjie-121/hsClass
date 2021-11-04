using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work2
{
    class Program
    {
        static void Main(string[] args)
        {
            User u2 = new User();
            Console.Write("请输入姓名:");
            u2.Name = Console.ReadLine();
            Console.Write("请输入性别:");
            u2.Sex = Console.ReadLine();
            Console.Write("请输入年龄:");
            u2.Age = int.Parse(Console.ReadLine().ToString());
            Console.WriteLine("姓名是:" + u2.Name);
            if (string.IsNullOrEmpty(u2.Sex)) Console.WriteLine("您输入的性别可能不规范");
            else Console.WriteLine("性别是:" + u2.Sex);
            if (u2.Age == 0) Console.WriteLine("您输入的年龄可能不规范");
            else Console.WriteLine("年龄是:" + u2.Age);
            Console.ReadLine();
        }
    }
}
