using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Distance_between_Points
{
    class Program
    {
        static void Main(string[] args)
        {
         input();
        }

        static void input()
        {
            int[] firstPoint = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondPoint = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Point point1 = new Point() { x = firstPoint[0], y = firstPoint[1] };
            Point point2 = new Point() { x = secondPoint[0], y = secondPoint[1] };
            Console.WriteLine("{0:f3}",distance(point1,point2));
        }

        static double distance(Point p1,Point p2)
        {
            double sideA = Math.Abs(p1.x-p2.x);
            double sideB = Math.Abs(p1.y-p2.y);
            double sideC = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
            return sideC;
        }
        class Point
        {
            public int x { get; set; }
            public int y { get; set; }
        }
    }
}
