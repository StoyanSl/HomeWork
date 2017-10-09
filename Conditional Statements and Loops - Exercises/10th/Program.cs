using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10th
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i <= number; i++)
            {
                for (int k = 0; k < i; k++)
                {

                    Console.Write(i+" ");
                }
                Console.WriteLine("");
            }
        }
    }
}
