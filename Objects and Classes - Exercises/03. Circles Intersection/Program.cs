using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Circles_Intersection
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstProps = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondProps = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Point point1 = pointReader(firstProps);
            Point point2 = pointReader(secondProps);
            double distance = Program.distance(point1, point2);
            circle circle1 = circleReader(point1, firstProps);
            circle circle2 = circleReader(point2, secondProps);
            if (Intersect(circle1,circle2,distance))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        static bool Intersect(circle c1, circle c2,double distance)
        {
            if (distance<=c1.radius+c2.radius)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
        static circle circleReader(Point point, int[] arr)
        {
            circle circleN=new circle();
            circleN.center = point;
            circleN.radius = arr[2];
            return circleN;
        }
        static Point pointReader(int[] arr)
        {
            Point pointN =new Point();
            pointN.x = arr[0];
            pointN.y = arr[1];
            return pointN;
        }
        static double distance(Point p1, Point p2)
        {
            double sideA = Math.Abs(p1.x - p2.x);
            double sideB = Math.Abs(p1.y - p2.y);
            return Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));

        }
        class Point
        {
            public int x { get; set; }
            public int y { get; set; }
        }
        class circle
        {
            public Point center { get; set; }
            public int radius { get; set; }
        }
    }
}
