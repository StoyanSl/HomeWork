using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Fold_and_SUm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int>row1=new List<int>();
            List<int> rev=new List<int>();
            List<int>row2=new List<int>();
            row1.AddRange(input.GetRange(0, input.Count / 4));
            row1.Reverse();
            rev.AddRange(input.GetRange(input.Count-row1.Count,row1.Count));
            rev.Reverse();
            row1.AddRange(rev);
            rev.Clear();
            row2.AddRange(input.GetRange(row1.Count/2,input.Count-row1.Count));
            var sum=row1.Select((x,i)=>x+row2[i]);
            Console.WriteLine(string.Join(" ",sum));
        }
    }
}
