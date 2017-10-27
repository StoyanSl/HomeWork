using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Logs_Agreagator_NestedDictSolve
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dictionary=new SortedDictionary<string,SortedDictionary<string,int>>();
            for (int i = 0; i < n; i++)
            {
                var entry = Console.ReadLine().Split(' ').ToList();
                string ip = entry[0];
                string user = entry[1];
                int duration = int.Parse(entry[2]);
                if (!dictionary.ContainsKey(user))
                {
                    dictionary.Add(user,new SortedDictionary<string, int>());
                }
                if (!dictionary[user].ContainsKey(ip))
                {
                    dictionary[user].Add(ip,duration);
                }
                else
                {
                    dictionary[user][ip] += duration;
                }
            }
            foreach (var user in dictionary)
            {
                var sum = user.Value.Values.Sum();
                var ipList = user.Value.Keys.ToList();
                Console.Write($"{user.Key}: {sum} [{string.Join(", ",ipList)}]"+Environment.NewLine);
            }
        }
    }
}
