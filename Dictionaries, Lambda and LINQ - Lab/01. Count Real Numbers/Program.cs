using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split(' ').Select(s => double.Parse(s)).ToArray();
            var counts=new SortedDictionary<double,int>();
            foreach (var num in nums)
            {
                counts[num] = 0;
            }
            foreach (var num in nums)
            {
                if (counts.ContainsKey(num))
                {
                    counts[num]++;
                }
            }
            foreach (var num in counts.Keys)
            {
                Console.WriteLine("{0} -> {1}",num,counts[num]);
            }
        }
    }
}
