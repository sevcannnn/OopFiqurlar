using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopFiqurlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IShape> shapes = new List<IShape>();
            shapes.Add(new Daire { Radius = 5 });
            shapes.Add(new Ucbucaq { Side = 10 });
            shapes.Add(new Kvadrat { Side = 15 });

            foreach (var shape in shapes)
            {
                Console.WriteLine($"Area: {shape.CalculateArea()}");
                Console.WriteLine($"Perimeter: {shape.CalculatePerimeter()}");
            }   
        }
    }
}
