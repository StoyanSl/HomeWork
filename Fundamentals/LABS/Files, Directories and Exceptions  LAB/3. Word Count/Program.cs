using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = new char[]
                {'\n','\r',' ', '.', ',', '!', '?','-'};
            string[] allWords = File.ReadAllText("text.txt").ToLower().Split(separators,StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] checkWords = File.ReadAllText("words.txt").Split(separators).ToArray();
            Dictionary<string,int> Dict=new Dictionary<string, int>();
            foreach (var word in allWords)
            {
                if (checkWords.Contains(word))
                {

                    if (!Dict.Keys.Contains(word))
                    {
                        Dict.Add(word, 1);
                    }
                    else
                    {
                        Dict[word]++;
                    }
                }
            }
            Dict = Dict.OrderByDescending(pair => pair.Value).ToDictionary(pair => pair.Key, pair => pair.Value); File.Delete("output.txt");
           foreach (var word in Dict)
           {
             File.AppendAllText("output.txt", $"{word.Key} - {word.Value}" + Environment.NewLine);
           }         
        }
    }
}
