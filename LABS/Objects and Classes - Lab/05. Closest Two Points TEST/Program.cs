using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Closest_Two_Points_TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            Point[] points = readPoints();
            Point[] closestTwoPoints= FindClosestTwoPoints(points);
            PrintDistance(closestTwoPoints);
            PrintPoint(closestTwoPoints[0]);
            PrintPoint(closestTwoPoints[1]);
        }
        static void PrintPoint(Point point)
        {
            Console.WriteLine("({0}, {1})", point.x, point.y);

        }
        static void PrintDistance(Point[] points)
        {
            Console.WriteLine("{0:f3}", distance(points[0], points[1]));

        }
        static Point[] FindClosestTwoPoints(Point[] points)
        {
            double minDistance = double.MaxValue;
            Point[] closestTwoPoints = null;
            for (int i = 0; i < points.Length; i++)
            {
                for (int j = i+1; j < points.Length-1; j++)
                {
                    double distanceD = Program.distance(points[i], points[j]);
                    if (distanceD<minDistance)
                    {
                        distanceD = minDistance;
                        closestTwoPoints=new Point[]{points[i],points[j]};
                    }
                }
            }
            return closestTwoPoints;
        }
        static double distance(Point p1, Point p2)
        {
            double sideA = Math.Abs(p1.x - p2.x);
            double sideB = Math.Abs(p1.y - p2.y);
            return  Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
           
        }
        static void Print(Point[] points)
        {
            for (int i = 0; i < points.Length; i++)
            {
                Console.WriteLine("({0}, {1})",points[i].x,points[i].y);
            }
        }
        static Point[] readPoints()
        {
            int n = int.Parse(Console.ReadLine());
            Point[] points=new Point[n];
            for (int i = 0; i < n; i++)
            {
                points[i] = input();
            }
            return points;
        }
        static Point input()
        {
            int[] pointParameters = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Point point=new Point(){x=pointParameters[0],y=pointParameters[1]};
            return point;
        }
        class Point
        {
            public int x { get; set; }
            public int y { get; set; }
        }
    }
}
