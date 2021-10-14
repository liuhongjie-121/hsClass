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
            // 选择排序
            int[] arr= new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write(string.Format("请输入第{0}个数：",i+1));
                arr[i] = int.Parse(Console.ReadLine());
            }
            int[] newArr = selectSort(arr);
            Console.WriteLine("选择排序后的数组：");
            for (int j = 0; j < newArr.Length; j++)
            {
                Console.Write(newArr[j] + "\0");
            }
            Console.ReadKey();

        }
        public static int[] selectSort(int[] arrNum) {
            for (int i = 0; i < arrNum.Length; i++)
            {
                int minIndex = i;
                for (int j = i+1; j < arrNum.Length; j++)
                {
                    if(arrNum[j] < arrNum[minIndex]){
                        minIndex = j;
                    }
                }

                if(minIndex !=i){
                    int tempNum = arrNum[i];
                    arrNum[i] = arrNum[minIndex];
                    arrNum[minIndex] = tempNum;
                }
            }
            return arrNum;
        }
    }
}
