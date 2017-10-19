using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();
            Random rnd=new Random();
            for (int i = 0; i < words.Length; i++)
            {
                int firstIndex = rnd.Next(0, words.Length);
                int secondIndex = rnd.Next(0, words.Length);

                string swap = words[firstIndex];
                words[firstIndex] = words[secondIndex];
                words[secondIndex] = swap;
            }
            Console.WriteLine(string.Join("\n",words));
        }
    }
}
