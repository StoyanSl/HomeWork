using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] alphabet = new char[26];
            int i = 0;
            int k = 0;
            for (char j = 'a'; j <= 'z'; j++)
            {
                alphabet[i] = j;
                i++;
            }
            for (int j = 0; j < input.Length; j++)
            {
                for (int l = 0; l < alphabet.Length; l++)
                {
                    if (input[j]==alphabet[l])
                    {
                        Console.WriteLine("{0} -> {1}", input[j], l);
                    }
                }
            }
        }
    }
}
