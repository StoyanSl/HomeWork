using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> input = Console.ReadLine()
                .Split(' ')
                .Select(s=>double.Parse(s)).ToList();
            Console.WriteLine(String.Join(" ",input.OrderByDescending(x=>x).Take(3)));
        }
    }
}
