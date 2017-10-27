using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hornet_Wings
{
    class Program
    {
        static void Main(string[] args)
        {
            int wingFlaps = int.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());
            double totalDistance = (wingFlaps / 1000) * distance;
            double secondsPassed = (wingFlaps / 100) + (wingFlaps / endurance)*5;
            Console.WriteLine($"{totalDistance:f2} m.");
            Console.WriteLine($"{secondsPassed} s.");
        }
    }
}
