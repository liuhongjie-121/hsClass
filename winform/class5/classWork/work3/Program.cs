using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 定义一个3×3矩阵，赋100以内的随机值，求最大值及行列号。
            int[,] arr = new int[3,3];
            Random r = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr[i, j] = r.Next(0, 100);
                }
            }
            int k = arr[0, 0];
            for (int s = 0; s < 3; s++)
            {
                for (int t = 0; t < 3; t++)
                {
                    Console.Write(string.Format("[{0},{1}]={2}\0",s,t,arr[s,t]));
                    if(k<arr[s,t]){
                        k = arr[s, t];
                    }
                }
                Console.WriteLine();
            }
            Console.Write("最大值为:" + k.ToString());
            Console.ReadKey();
        }
    }
}
