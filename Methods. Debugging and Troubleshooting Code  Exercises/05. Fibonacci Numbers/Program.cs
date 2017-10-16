using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(Fib(input));

        }
        static int Fib(int n)
        {
            int firstNumber = 0;
            int secondNumber = 1;
            int fibnumber = 0;
            if (n == 1 || n == 0)
            {
                fibnumber = firstNumber + 1;
            }
            else if (n == 2)
            {
                fibnumber = secondNumber + 1;
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    fibnumber = firstNumber + secondNumber;
                    firstNumber = secondNumber;
                    secondNumber = fibnumber;
                }
            }
            return fibnumber;
        }

    }
}
