using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long input = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(input));

        }
        static bool IsPrime(long n)
        {
            bool state = true;
            if (n != 1 && n != 0)
            {
                for (int k = 2; k <= Math.Sqrt(n); k++)
                {
                    if (n % k == 0)
                    {
                        state = false;
                        break;
                    }
                }
            }
            else
            {
                state = false;
            }

            return state;
        }
    }
}
