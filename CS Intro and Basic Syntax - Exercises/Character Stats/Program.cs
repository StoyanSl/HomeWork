using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int chealth = int.Parse(Console.ReadLine());
            int health = int.Parse(Console.ReadLine());
            int cenergy = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Health: " + "|" + new string('|', chealth) + new string('.', health - chealth) + "|");
            Console.WriteLine("Energy: " + "|" + new string('|', cenergy) + new string('.', energy - cenergy) + "|");
        }
    }
}
