using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myText.Modal;

namespace myText
{
    class Program
    {
        static void Main(string[] args)
        {
            userModal useM = new userModal();
            Console.Write("请输入姓名:");
            useM.userNmae = Console.ReadLine();
            Console.Write("请输入年龄:");
            // 尝试强制转换
            useM.age = int.TryParse(Console.ReadLine(), out int intAge)? intAge : useM.age;
            Console.Write("请输入月薪:");
            useM.monthMoney = int.TryParse(Console.ReadLine(), out int intMoney)? intMoney : useM.monthMoney;
            Console.WriteLine(string.Format("姓名：{0}，年龄：{1}，性别：{2}\n" +
                "我的手机号码：{3}，我的手机名称是：{4}\n" +
                "我的手机型号：{5}，我的手机颜色是：{6}", 
                useM.userNmae, useM.age, useM.sex, 
                useM.phone,useM.phoneName, 
                useM.phoneType, useM.phoneColor));
            Console.ReadKey();
        }
    }
}
