using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dictionary = new SortedDictionary<string, List<string>>();
            SortedDictionary<string, int> dictionaryDuration = new SortedDictionary<string, int>();
            for (int i = 0; i < n; i++)
            {
                var entry = Console.ReadLine().Split(' ').ToList();
                string name = entry[1];
                string ip = entry[0];
                int duration = int.Parse(entry[2]);
                if (!dictionary.ContainsKey(name))
                {
                    dictionary.Add(name, new List<string>());
                }
                if (!dictionary[name].Contains(ip))
                {
                    dictionary[name].Add(ip);
                }


                if (!dictionaryDuration.ContainsKey(name))
                {
                    dictionaryDuration.Add(name, 0);
                }
                dictionaryDuration[name] += duration;
            }
            foreach (var user in dictionary)
            {
                string name = user.Key;
                var ipList = user.Value;
                ipList = ipList.Distinct().ToList();
                ipList.Sort();
                Console.Write($"{user.Key}: {dictionaryDuration[name]} [{String.Join(", ", ipList)}]");
                Console.WriteLine();
            }
        }

    }
}
