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
            People p = new People();
            Bird b = new Bird();
            p.Name = "人";
            b.Name = "老鹰";
            b.SayName();
            b.IsEagle();
            p.SayName();
            Console.ReadKey();
        }
    }
}
