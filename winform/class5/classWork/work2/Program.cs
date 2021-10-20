using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 已知一个一维数组（按升序排列），插入一个数后排序规则不变
            Random r = new Random();
            List<int> arr =new List<int>();
            for (int i = 0; i < 5; i++)
            {
                arr.Add(r.Next(0, 100));
            }
            arr.Sort();
            Console.WriteLine("原数组：" + string.Join(",", arr));
            Console.Write("请输入一个数字：");
            int num = int.Parse(Console.ReadLine());
            arr.Add(num);
            arr.Sort();
            Console.WriteLine("新数组："+ string.Join(",", arr));
            Console.ReadKey();
        }
    }
}
