using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work2
{
    class Student:Person
    {
        public int Id { get; set; }
          
        public Student(int id,string name):base(name) {
            Id = id;
        }

        public override void Say()
        {
            base.Say();
            Console.Write("正在学习");
        }
    }
}
