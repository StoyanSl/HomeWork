using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            // char[] separators = new char[]{'.', ',', ':', ';', '(', ')', '[', ']', '\\', '\"', '\'', '/', '!', '?', ' '};
            var arrayOfWords = Console.ReadLine().ToLower().Split(new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var smallWords=new List<string>();
            foreach (var word in arrayOfWords)
            {
                if (word.Length<5)
                {
                    smallWords.Add(word);
                }
            }
           var resultList=smallWords.OrderBy(s => s).Distinct();
            Console.WriteLine(string.Join(", ",resultList));
            
        }
    }
}
