using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopFiqurlar
{
    internal class Kvadrat :IShape
    {
        public double Side { get; set; }
        public double CalculateArea()
        {
            return Side * Side;
        }
        public double CalculatePerimeter()
        {
            return 4 * Side;
        }
    }
}
