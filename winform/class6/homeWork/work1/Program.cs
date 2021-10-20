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
            Console.Write("请输入姓名:");
            string name = Console.ReadLine();
            Console.Write("请输入年龄:");
            int age = int.Parse(Console.ReadLine());
            Console.Write("请输入学历:");
            string degree = Console.ReadLine();
            // 为学生类赋值
            Student stu = new Student();
            stu.setVal(name, age);
            // 为本科生类赋值
            UnderGraduate ung = new UnderGraduate();
            ung.setVal(name, age, degree);
            ung.Show();

            Console.ReadKey();
        }
    }
}
