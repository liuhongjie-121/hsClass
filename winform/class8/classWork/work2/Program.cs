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
            Student stu = new Student(1, "张三");
            stu.Say();
            Console.ReadKey();
        }
    }
}
