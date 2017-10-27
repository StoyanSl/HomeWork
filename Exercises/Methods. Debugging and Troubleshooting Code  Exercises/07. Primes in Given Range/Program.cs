using System;
using System.Collections.Generic;

namespace _07.Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int startInput = int.Parse(Console.ReadLine());
            int endInput = int.Parse(Console.ReadLine());
            List<int> nums = new List<int>();
            IsPrime(nums, startInput, endInput);

            Console.WriteLine(string.Join<int>(", ", nums));

        }
        static void IsPrime(List<int> nums, int start, int end)
        {
            for (int i = start; i <= end; i++)
            {

                if (i == 0)
                {
                    i++;
                }
                if (i == 1)
                {
                    i++;
                }

                bool state = true;
                if (i != 1 && i != 0)
                {
                    for (int k = 2; k <= Math.Sqrt(i); k++)
                    {
                        if (i % k == 0)
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
                if (state)
                {
                    nums.Add(i);
                }

            }
        }
    }
}
