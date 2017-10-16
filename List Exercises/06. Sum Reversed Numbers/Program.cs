using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int sum = 0;
            for (int i = 0; i < inputNumbers.Count; i++)
            {
                var reverse = 0;
                while (inputNumbers[i]>0)
                {
                    int a=inputNumbers[i] % 10;
                    reverse = reverse * 10 + a;
                    inputNumbers[i] /= 10;
                }
                sum += reverse;
            }
            Console.WriteLine(sum);
        }
    }
}
