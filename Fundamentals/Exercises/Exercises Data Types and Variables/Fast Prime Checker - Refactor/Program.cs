using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fast_Prime_Checker___Refactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputN = int.Parse(Console.ReadLine());
            for (int i = 0; i <= inputN; i++)
            {
                bool state = true;
                for (int k = 2; k <= Math.Sqrt(i); k++)
                {
                    if (i % k == 0)
                    {
                        state = false;
                        break;
                    }
                }
                if (i!=0 && i!=1)
                {
                    Console.WriteLine($"{i} -> {state}");
                }
               
            }
        }
    }
}
