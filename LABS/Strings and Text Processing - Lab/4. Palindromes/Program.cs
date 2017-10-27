using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = new char[] { '\n', '\r', ' ', '.', ',', '!', '?', '-' };
            var input = Console.ReadLine().Split(separators,StringSplitOptions.RemoveEmptyEntries).ToList();
                List<string> outputs=new List<string>();
            foreach (var word in input)
            {
               var reversedWord = word.Reverse();
                if (word==string.Join("",reversedWord))
                {
                    if (!outputs.Contains(string.Join("", reversedWord)))
                    {
                        outputs.Add(string.Join("", reversedWord));
                    }
                    
                }
            }
            
            Console.WriteLine(string.Join(", ",outputs.OrderBy(s=>s)));
        }
    }
}
