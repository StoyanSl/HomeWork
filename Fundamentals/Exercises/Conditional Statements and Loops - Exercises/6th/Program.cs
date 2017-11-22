using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6th
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            if (first < second)
            {
                for (int i = first; i <= second; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for(int i=second;i<=first;i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
