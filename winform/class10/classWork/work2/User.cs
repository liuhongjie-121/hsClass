using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work2
{
    class User
    {
        private string m_Name;
        private string m_Sex;
        private int m_Age;

        public string Name{get;set;}
        public string Sex
        {
            get{
                return m_Sex;
            }
            set{
                if (value == "男" || value == "女") m_Sex = value;
            }
        }
        public int Age
        {
            get{
                return m_Age;
            }
            set{
                if (value >= 10 && value <= 30) m_Age = value;
            }
        }
       
    }
}
