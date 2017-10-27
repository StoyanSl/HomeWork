using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("test.txt");
                File.Delete("output.txt");
                for (int i = 0; i < lines.Length; i++)
                {
                    File.AppendAllText("output.txt", $"{i + 1}. {lines[i]}" + Environment.NewLine);
                }        
        }
    }
}
