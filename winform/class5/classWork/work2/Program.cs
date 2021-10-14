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
            List<int> arr =new List<int>{ 1, 10, 15, 20, 25};
            Console.Write("原数组：");
            for (int o = 0; o < arr.Count; o++)
            {
                Console.Write(arr[o] + "\0");
            }
            Console.WriteLine();
            Console.Write("请输入值：");
            int num = int.Parse(Console.ReadLine());
            arr.Add(num);

            for (int i = 0; i < arr.Count-1; i++)
            {
                for (int j = 0; j < arr.Count - 1 - i; j++)
                {
                    if(arr[j]>arr[j+1]){
                        int temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                   
                }
            }
            Console.Write("新数组：");
            for (int s = 0; s < arr.Count; s++)
            {
                Console.Write(arr[s] + "\0");
            }
            Console.ReadKey();
        }
    }
}
