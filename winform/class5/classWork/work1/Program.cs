using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work1
{
    class Program
    {
        static void Main(string[] args){
            // 定义一个3×3矩阵，赋从1开始的奇数，分别求两条对角线之和
            int[,] arr =new int[3,3]{{1,3,5},{7,9,11},{13,15,17}};
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if(j == i){
                        sum1 += arr[i,j];
                    }
                    if (i + j == 2) {
                        sum2 += arr[i, j];
                    }                    
                }
            }
            Console.WriteLine(String.Format("对角线和为:{0}", sum1+sum2));
            Console.ReadKey();
        }
    }
}
