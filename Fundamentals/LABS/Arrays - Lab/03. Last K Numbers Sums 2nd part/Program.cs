using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Last_K_Numbers_Sums_2nd_part
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] seq = new int[n];
            seq[0] = 1;
            int sum = 0;
            for (int i = 1; i <n; i++)
            {
                 sum = 0;
                for (int j = i-k; j < i; j++)
                {                  
                    if (j>=0)
                    {
                        sum += seq[j];
                    }
                    seq[i] = sum;
                }
            }
            for (int i = 0; i < seq.Length; i++)
            {
                Console.WriteLine(seq[i]);
            }
        }
    }
}
