using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figreType = Console.ReadLine();
            if (figreType == "triangle")
            {
                triangle();
            }
            if (figreType == "square")
            {
                square();
            }
            if (figreType == "rectangle")
            {
                rectangle();
            }
            if (figreType == "circle")
            {
                circle();
            }
        }
        static void triangle()
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:f2}", side * (height / 2));

        }
        static void square()
        {
            double side = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:f2}", side * side);
        }
        static void rectangle()
        {
            double widht = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:f2}", widht * height);
        }
        static void circle()
        {
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:f2}", Math.PI * radius * radius);
        }
    }
}
