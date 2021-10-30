using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work3
{
    class Cirecle:Shape
    {
        public double Area(double num)
        {
            return Math.Pow(num,2)* Math.PI;
        }
    }
}
