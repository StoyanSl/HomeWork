using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            string x1input = Console.ReadLine();
            string y1input = Console.ReadLine();
            string x2input = Console.ReadLine();
            string y2input = Console.ReadLine();
            double x1 = Math.Abs(double.Parse(x1input));
            double y1 = Math.Abs(double.Parse(y1input));
            double x2 = Math.Abs(double.Parse(x2input));
            double y2 = Math.Abs(double.Parse(y2input));
            ClosestPoint(x1, y1, x2, y2, x1input, y1input, x2input, y2input)
                ;
        }
        static void ClosestPoint(double x1, double y1, double x2, double y2, string x1input, string y1input, string x2input, string y2input)
        {
            if (x1 + y1 > x2 + y2)
            {
                Console.WriteLine("(" + x2input + ", " + y2input + ")");
            }
            else if (x2 + y2 > x1 + y1)
            {
                Console.WriteLine("(" + x1input + ", " + y1input + ")");
            }
            else if (x1 + x2 == y1 + y2)
            {
                Console.WriteLine("(" + x1input + ", " + y1input + ")");
            }
        }
    }
}
