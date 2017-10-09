using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements_and_Loops__Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string proffesion = Console.ReadLine();
            switch (proffesion)
            {
                case "SoftUni Student":
                    Console.WriteLine("Beer");
                    break;
                case "Businesswoman":
                    Console.WriteLine("Coffee");
                    break;
                case "Businessman":
                    Console.WriteLine("Coffee");
                    break;
                case "Athlete":
                    Console.WriteLine("Water");
                    break;
                default:
                    Console.WriteLine("Tea");
                    break;
            }
        }
    }
}
