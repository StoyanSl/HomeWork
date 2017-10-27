using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators=new char[] { '\n', '\r', ' ', '.', ',', '!', '?', '-' };
            var bannedWords = Console.ReadLine().Split(new string[] {", "},StringSplitOptions.RemoveEmptyEntries).ToList();
            var textInput = Console.ReadLine();//.Split(separators,StringSplitOptions.RemoveEmptyEntries).ToList();
            foreach (var word in bannedWords)
            {
                if (textInput.Contains(word))
                {
                    textInput = textInput.Replace(word, new string('*', word.Length));
                }
            }
            Console.WriteLine(textInput);
        }
    }
}
