using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string formula = Console.ReadLine();
            if (formula == "face")
            {
                faceDiago(side);
            }
            if (formula == "space")
            {
                spaceDiago(side);
            }
            if (formula == "volume")
            {
                volume(side);
            }
            if (formula == "area")
            {
                area(side);
            }

        }
        static void faceDiago(double side)
        {
            Console.WriteLine("{0:f2}", Math.Sqrt(2 * side * side));
        }
        static void spaceDiago(double side)
        {
            Console.WriteLine("{0:f2}", Math.Sqrt(3 * side * side));
        }
        static void volume(double side)
        {
            Console.WriteLine("{0:f2}", side * side * side);
        }
        static void area(double side)
        {
            Console.WriteLine("{0:f2}", 6 * side * side);
        }
    }
}
