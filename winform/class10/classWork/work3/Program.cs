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
            IndexerClass ic = new IndexerClass();
            bool Close = false;
            int Index = 0;
            while (!Close)
            {
                Console.Write("请输入姓名:");
                ic[Index] = Console.ReadLine();
                Console.WriteLine(ic[Index]);
                if (Index < 3) Index++;
                else {
                    Console.ReadKey();
                    Close = true;
                }
            }
            
        }
    }
}
