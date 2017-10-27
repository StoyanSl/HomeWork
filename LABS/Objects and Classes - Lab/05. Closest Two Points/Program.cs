using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Closest_Two_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Point[] points=new Point[n];
            for (int i = 0; i < n; i++)
            {
                points[i] = inputPoint(Console.ReadLine());
            }
            Point[] closestPoints = FindingClosestPoints(points);
            distancePrint(closestPoints);
            pointPrint(closestPoints[0]);
            pointPrint(closestPoints[1]);
        }

        static void distancePrint(Point[] closestPoints)
        {
            Console.WriteLine("{0:f3}",distance(closestPoints[0],closestPoints[1]));
        }
        static void pointPrint(Point points)
        {
            Console.WriteLine("({0}, {1})",points.x,points.y);
        }
        static Point[] FindingClosestPoints(Point[] points)
        {
            double minValue = double.MaxValue;
            Point[] closestTwoPoints=new Point[2];
            for (int i = 0; i < points.Length; i++)
            {
                for (int j = i+1; j < points.Length; j++)
                {
                    if (distance(points[i],points[j])<minValue)
                    {
                        minValue = distance(points[i], points[j]);
                        closestTwoPoints[0] = points[i];
                        closestTwoPoints[1] = points[j];
                    }
                }
            }
            return closestTwoPoints;
        }
        static Point inputPoint(string input)
        {
            var pointCoordinates = input.Split(' ').Select(int.Parse).ToArray();
            return new Point(){x = pointCoordinates[0],y = pointCoordinates[1]};
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
    }
}
