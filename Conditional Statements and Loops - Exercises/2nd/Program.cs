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
            int quantity = int.Parse(Console.ReadLine());
            switch (proffesion)
            {
                case "SoftUni Student":
                    Console.WriteLine("The SoftUni Student has to pay {0:f2}.",quantity*1.70);
                    break;
                case "Businesswoman":
                    Console.WriteLine("The Businesswoman has to pay {0:f2}.", quantity);
                    break;
                case "Businessman":
                    Console.WriteLine("The Businessman has to pay {0:f2}.", quantity);
                    break;
                case "Athlete":
                    Console.WriteLine("The Athlete has to pay {0:f2}.", quantity * 0.70);
                    break;
                default:
                    Console.WriteLine("The {0} has to pay {1:f2}.",proffesion,quantity*1.20);
                    break;
            }
        }
    }
}
