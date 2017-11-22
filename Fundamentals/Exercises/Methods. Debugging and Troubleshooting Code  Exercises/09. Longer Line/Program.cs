using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());
            findingLongerLine(x1, y1, x2, y2, x3, y3, x4, y4);
        }
        static void findingLongerLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double lineA = Math.Abs((x1 + y1) - (x2 + y2));
            double lineB = Math.Abs((x3 + y3) - (x4 + y4));
            if (lineA > lineB)
            {
                if (Math.Abs(x1 + y1) > Math.Abs(x2 + y2))
                {
                    Console.WriteLine("(" + x2 + ", " + y2 + ")" + "(" + x1 + ", " + y1 + ")");
                }
                else if (Math.Abs(x2 + y2) > Math.Abs(x1 + y1))
                {
                    Console.WriteLine("(" + x1 + ", " + y1 + ")" + "(" + x2 + ", " + y2 + ")");
                }
                else if (Math.Abs(x1 + x2) == Math.Abs(y1 + y2))
                {
                    Console.WriteLine("(" + x1 + ", " + y1 + ")" + "(" + x2 + ", " + y2 + ")");
                }
            }
            else if (lineB > lineA)
            {
                if (Math.Abs(x3 + y3) > Math.Abs(x4 + y4))
                {
                    Console.WriteLine("(" + x4 + ", " + y4 + ")" + "(" + x3 + ", " + y3 + ")");
                }
                else if (Math.Abs(x2 + y2) > Math.Abs(x1 + y1))
                {
                    Console.WriteLine("(" + x3 + ", " + y3 + ")" + "(" + x4 + ", " + y4 + ")");
                }
                else if (Math.Abs(x1 + x2) == Math.Abs(y1 + y2))
                {
                    Console.WriteLine("(" + x3 + ", " + y3 + ")" + "(" + x4 + ", " + y4 + ")");
                }
            }
            else if (lineA == lineB)
            {
                if (Math.Abs(x1 + y1) > Math.Abs(x2 + y2))
                {
                    Console.WriteLine("(" + x2 + ", " + y2 + ")" + "(" + x1 + ", " + y1 + ")");
                }
                else if (Math.Abs(x2 + y2) > Math.Abs(x1 + y1))
                {
                    Console.WriteLine("(" + x1 + ", " + y1 + ")" + "(" + x2 + ", " + y2 + ")");
                }
                else if (Math.Abs(x1 + x2) == Math.Abs(y1 + y2))
                {
                    Console.WriteLine("(" + x1 + ", " + y1 + ")" + "(" + x2 + ", " + y2 + ")");
                }
            }
        }
    }
}
