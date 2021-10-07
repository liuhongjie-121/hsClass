using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 判断原因
            Console.Write("请输入一个字符：");
            string strVowel = Console.ReadLine();
            switch (strVowel)
            {
                case "a":case"e":case"i":case"o":case"u":
                    Console.WriteLine("您输入了一个元音");
                    break;
                default:
                    Console.WriteLine("这不是一个元音");
                    break;
            }
            Console.ReadKey();
        }
    }
}
