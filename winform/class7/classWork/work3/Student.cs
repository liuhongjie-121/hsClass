using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work3
{
    class Student
    {
        // 名字
        public string Name { get; set; }
        // 成绩
        public double Grade { get; set; }

        // 无参的构造方法
        public void setVal() {
            Name = "张三";
            Grade = 66.6d;
        }
        // 两个参数的构造方法
        public void setVal(string name,double grade)
        {
            Name = name;
            Grade = grade;
        }
    }
}
