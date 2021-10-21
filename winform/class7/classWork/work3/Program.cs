using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            stu.setVal();
            Console.WriteLine("无参赋值:我的名字是"+stu.Name+",我的成绩是"+stu.Grade);
            Console.Write("请输入姓名:");
            string name = Console.ReadLine();
            Console.Write("请输入成绩:");
            double grade = double.Parse(Console.ReadLine());
            stu.setVal(name,grade);
            Console.WriteLine("有参赋值:我的名字是" + stu.Name + ",我的成绩是" + stu.Grade);
        }
    }
}
