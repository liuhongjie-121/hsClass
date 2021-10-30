using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work1
{
    class Information
    {
        public string Name { get; set; }
        public string Sex { get; set; }

        public Information(string name, string sex)
        {
            Name = name;
            Sex = sex;
        }
        public virtual void Say() {
            Console.WriteLine("Hello,"+Name);
        }
    }
}