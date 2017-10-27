using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Merge_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input1 = File.ReadAllLines("input1.txt").ToArray();
            string[] input2 = File.ReadAllLines("input2.txt");
            File.Delete("output.txt");
            for (int i = 0; i < input1.Length; i++)
            {
                File.AppendAllText("output.txt",input1[i]+Environment.NewLine);
                File.AppendAllText("output.txt", input2[i]+Environment.NewLine);
            }
        }
    }
}
