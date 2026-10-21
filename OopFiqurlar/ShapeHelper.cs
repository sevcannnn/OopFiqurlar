using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OopFiqurlar
{
    internal class ShapeHelper
    {
       
        public double CalculateArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        public double CalculateArea(double width, double height)
        {
            return width * height;
        }
    }
}