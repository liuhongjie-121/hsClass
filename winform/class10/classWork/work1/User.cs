using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work1
{
    class User
    {
        private string Name;
        private string Sex;

        public void SetName(string name) {
            Name = name;
        }
        public string GetName() {
            return Name;
        }
        public void SetSex(string sex)
        {
            if (sex == "男" | sex == "女") Sex = sex;
        }
        public string GetSex()
        {
            return Sex;
        }
    }
}
