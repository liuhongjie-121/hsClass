using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work3
{
    class IndexerClass
    {
        private List<string> Name = new List<string>();

        public string this[int i] {
            get {
                if (i<3) return Name[i];
                else return "索引超限";
            }
            set {
                if (i<3) Name.Add(value);     
            }
        }
    }
}
