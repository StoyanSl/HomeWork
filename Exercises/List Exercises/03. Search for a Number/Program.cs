using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] indexNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<int>range=input.GetRange(0, indexNumbers[0]);
            range.RemoveRange(0,indexNumbers[1]);
            if (range.Contains(indexNumbers[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
