using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("test.txt");
            for (int i = 1; i < lines.Length; i+=2)
            {
                Console.WriteLine(lines[i]);
            }
        }
    }
}
