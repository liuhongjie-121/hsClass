using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work1
{
    // 学生类
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void setVal(string name,int age) {
            Name = name;
            Age = age;
        }

        public virtual void Show() {           
            Console.WriteLine("学生姓名:"+Name+",年龄:"+Age+"岁");
        }
    }
}
