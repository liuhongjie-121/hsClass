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
            Information[] s = new Information[3] {
                new Information("张三","男"),
                new Stu("李四", "男","123456"),
                new Stu("王五", "女","456789")
            };
            foreach (var item in s)
            {
                item.Say();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
