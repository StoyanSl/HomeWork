﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Factorial(n);
        }

        static void Factorial(int n)
        {
            BigInteger factorial = 1;
            int counter = 0;
            for (int i = 1; i <= n; i++)
            {
                factorial = factorial * i;
            }
            while (factorial % 10 == 0)
            {
                factorial = factorial / 10;
                counter++;
            }
            Console.WriteLine(counter);
        }
    }
}
