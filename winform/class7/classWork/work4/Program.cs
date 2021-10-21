using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work4
{
    class Program
    {
        static void Main(string[] args)
        {
            pgMethod();
            Console.ReadKey();
        }
        // 创建一个类的实例对象
        private static Program pg;
        // 类的构造方法声明为私有
        private Program() {
            Console.WriteLine("Hello World!!");
        }
        // 定义一个静态用于返回该实例
        public static Program pgMethod() {
            if(pg == null){
                pg = new Program();
            }
            return pg;
        }
    }
}
