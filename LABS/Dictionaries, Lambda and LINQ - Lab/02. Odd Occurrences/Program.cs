using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower().Split(' ').Select(s => s).ToArray();
            var words=new Dictionary<string,int>();
            foreach (var word in input)
            {
                words[word] = 0;
            }
            foreach (var word in input)
            {
                if (words.ContainsKey(word))
                {
                    words[word] += 1;
                }
            }
            List<string> pairs = new List<string>();
            foreach (var pair in words)
            {
                if (pair.Value%2!=0)
                {
                   pairs.Add(pair.Key);
                }
            }
            Console.WriteLine(String.Join(", ",pairs));
        }
    }
}
