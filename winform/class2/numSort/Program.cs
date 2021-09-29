using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numSort2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入第一个数：");
            int num1 = int.TryParse(Console.ReadLine(), out int isIntNum1) ? isIntNum1 : 0;
            Console.Write("请输入第二个数：");
            int num2 = int.TryParse(Console.ReadLine(), out int isIntNum2) ? isIntNum2 : 1;
            Console.Write("请输入第三个数：");
            int num3 = int.TryParse(Console.ReadLine(), out int isIntNum3) ? isIntNum3 : 2;

            // 方法1
            int maxNum = (num1 > num2 ? num1 : num2) > num3 ? (num1 > num2 ? num1 : num2) : num3;
            int minNum = (num1 < num2 ? num1 : num2) < num3 ? (num1 < num2 ? num1 : num2) : num3;
            int midNum = (num1 + num2 + num3) - maxNum - minNum;
            Console.WriteLine("方法一：");
            Console.WriteLine("最小的是：" + minNum + ",第二个是：" + midNum + ",最大的是：" + maxNum);

            int[] arr = { num1, num2, num3 };

            //方法二:冒泡排序
            Console.WriteLine("方法二：");
            int[] arrNum1 = bubbleSort(arr);
            Console.WriteLine("最小的是：" + arrNum1[0] + ",第二个是：" + arrNum1[1] + ",最大的是：" + arrNum1[2]);

            //方法三:插入排序
            Console.WriteLine("方法三：");
            int[] arrNum2 = insertSort(arr);
            Console.WriteLine("最小的是：" + arrNum2[0] + ",第二个是：" + arrNum2[1] + ",最大的是：" + arrNum2[2]);

            //方法三:插入简单选择排序
            Console.WriteLine("方法四：");
            int[] arrNum3 = selectSort(arr);
            Console.WriteLine("最小的是：" + arrNum3[0] + ",第二个是：" + arrNum3[1] + ",最大的是：" + arrNum3[2]);

            //方法三:快速排序
            Console.WriteLine("方法五：");
            int[] arrNum4 = quickSort(arr, 0, arr.Length - 1);
            Console.WriteLine("最小的是：" + arrNum4[0] + ",第二个是：" + arrNum4[1] + ",最大的是：" + arrNum4[2]);

            Console.ReadKey();
        }
        // 方法二，冒泡排序
        public static int[] bubbleSort(int[] arrNum)
        {
            for (int i = 0; i < arrNum.Length - 1; i++)
            {
                for (int j = 0; j < arrNum.Length - 1 - i; j++)
                {
                    if (arrNum[j] > arrNum[j + 1])
                    {
                        int tempNum = arrNum[j + 1];
                        arrNum[j + 1] = arrNum[j];
                        arrNum[j] = tempNum;
                    }
                }
            }
            return arrNum;
        }
        // 方法三，插入排序
        public static int[] insertSort(int[] arrNum)
        {
            int preIndex, current;
            for (int i = 1; i < arrNum.Length; i++)
            {
                preIndex = i - 1;
                current = arrNum[i];
                // 拿到i的位置的元素跟前面的元素做比较
                while (preIndex >= 0 && arrNum[preIndex] > current)
                {
                    // 向后移动
                    arrNum[preIndex + 1] = arrNum[preIndex];
                    preIndex--;
                }
                arrNum[preIndex + 1] = current;
            }
            return arrNum;
        }
        // 方法四，简单选择排序
        public static int[] selectSort(int[] arrNum)
        {
            for (int i = 0; i < arrNum.Length - 1; i++)
            {
                // 记录最小索引
                int minIndex = i;
                for (int j = i + 1; j < arrNum.Length; j++)
                {
                    if (arrNum[j] < arrNum[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // 交互最小值,如果索引是最小值就不用交换
                if (minIndex != i)
                {
                    int tempNum = arrNum[i];
                    arrNum[i] = arrNum[minIndex];
                    arrNum[minIndex] = tempNum;
                }
            }
            return arrNum;
        }
        // 方法五，快速排序
        public static int[] quickSort(int[] arrNum, int left, int right)
        {
            if (left < right)
            {
                // 基准数，把比它的或等于它的放在它的左边，大于它的放在它的右边
                int x = arrNum[left];
                int i = left;
                int j = right;
                // i==j，找到了一个中间的位置，这个中间数是基准数所在的位置
                while (i < j)
                {
                    // 从后往前比较
                    // 找到一个比较基数，小于或等于的数字，应该把它放在x的左边
                    while (i < j)
                    {
                        if (arrNum[j] <= x)
                        {
                            arrNum[i] = arrNum[j];
                            break;
                        }
                        else
                        {
                            j--;
                        }
                    }
                    while (i < j)
                    {
                        if (arrNum[j] > x)
                        {
                            arrNum[j] = arrNum[i];
                        }
                        else
                        {
                            i++;
                        }
                    }
                }
                arrNum[i] = x;
                quickSort(arrNum, left, i - 1);
                quickSort(arrNum, i + 1, right);
            }
            return arrNum;
        }
    }
}
