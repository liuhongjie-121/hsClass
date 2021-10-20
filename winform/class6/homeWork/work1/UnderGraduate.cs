using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work1
{
    // 本科生类
    class UnderGraduate:Student
    {
        public string Degree { get; set; }

        public void setVal(string name,int age,string degree) {
            Name = name;
            Age = age;
            Degree = degree;
        }

        public override void Show() {
            base.Show();
            Console.WriteLine("本科生姓名:" + Name + ",年龄:" + Age + "岁,学历:"+ Degree);
        }
    }
}
