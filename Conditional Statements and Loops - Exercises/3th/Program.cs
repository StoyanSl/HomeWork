using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3th
{
    class Program
    {
        static void Main(string[] args)
        {
            int cPpl = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            if (cPpl <= 50)
            {
                switch (package)
                {
                    case "Normal":
                        Console.WriteLine("We can offer you the Small Hall");
                        Console.WriteLine("The price per person is {0:f2}$",(3000*0.95)/cPpl);
                        break;
                    case"Gold":
                        Console.WriteLine("We can offer you the Small Hall");
                        Console.WriteLine("The price per person is {0:f2}$", (3250 * 0.9) / cPpl);
                        break;
                    case "Platinum":
                        Console.WriteLine("We can offer you the Small Hall");
                        Console.WriteLine("The price per person is {0:f2}$", (3500*0.85) / cPpl);
                        break;
                }
            }
            else if (cPpl <= 100 && cPpl > 50)
            {
                switch (package)
                {
                    case "Normal":
                        Console.WriteLine("We can offer you the Terrace");
                        Console.WriteLine("The price per person is {0:f2}$", ((5000+500) * 0.95) / cPpl);
                        break;
                    case "Gold":
                        Console.WriteLine("We can offer you the Terrace");
                        Console.WriteLine("The price per person is {0:f2}$", (((5000 + 750)) * 0.9) / cPpl);
                        break;
                    case "Platinum":
                        Console.WriteLine("We can offer you the Terrace");
                        Console.WriteLine("The price per person is {0:f2}$", ((5000 + 1000) * 0.85) / cPpl);
                        break;
                }
            }
            else if (cPpl>100 && cPpl<=120)
            {
                switch (package)
                {
                    case "Normal":
                        Console.WriteLine("We can offer you the Great Hall");
                        Console.WriteLine("The price per person is {0:f2}$", ((7500 + 500) * 0.95) / cPpl);
                        break;
                    case "Gold":
                        Console.WriteLine("We can offer you the Great Hall");
                        Console.WriteLine("The price per person is {0:f2}$", (((7500 + 750)) * 0.9) / cPpl);
                        break;
                    case "Platinum":
                        Console.WriteLine("We can offer you the Great Hall");
                        Console.WriteLine("The price per person is {0:f2}$", ((7500 + 1000) * 0.85) / cPpl);
                        break;
                }
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
