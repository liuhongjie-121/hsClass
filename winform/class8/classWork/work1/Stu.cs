using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work1
{
    class Stu:Information
    {
        private string Phone;

        public Stu(string name, string sex, string phone):base(name,sex)
        {
            Phone = phone;
        }

        public override void Say()
        {
            base.Say();
            Console.WriteLine("你的电话是:" + Phone);
        }
    }
}
