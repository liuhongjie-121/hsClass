using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myText.Modal
{
    class userModal
    {
        /// <summary>
        /// 姓名
        /// </summary>
        private string Username = "张三";
        public string userNmae{ 
            get {
                return this.Username;
            }
            set { this.Username = value; }
        } 
        /// <summary>
        /// 年龄
        /// </summary>
        private int Age = 24;
        public int age
        {
            get {
                return this.Age;
            }
            set { this.Age = value; }
        } 

        /// <summary>
        /// // 性别
        /// </summary>
        private string Sex = "男";
        public string sex
        {
            get {
                return this.Sex;
            }           
        } 

        /// <summary>
        /// // 号码
        /// </summary>
        private string Phone = "12345678910";
        public string phone
        {
            get {
                return this.Phone;
            }            
        }
        /// <summary>
        /// 工资
        /// </summary>
        private int MonthMoney = 0;
        public int monthMoney { 
            get { 
                return this.MonthMoney; 
            } set { 
                this.MonthMoney = value; 
            } 
        }

        /// <summary>
        /// 手机品牌
        /// </summary>
        private string PhoneName = "华为";
        public string phoneName
        {
            get {
                return this.PhoneName;
            }
        }
        /// <summary>
        /// 手机型号
        /// </summary>
        private string PhoneType = "P30";
        public string phoneType
        {
            get {
                return this.PhoneType;
            }
        }

        /// <summary>
        /// // 手机颜色
        /// </summary>
        private string PhoneColor = "白色";
        public string phoneColor
        {
            get {
                return this.PhoneColor;
            }
        }
    }
}
