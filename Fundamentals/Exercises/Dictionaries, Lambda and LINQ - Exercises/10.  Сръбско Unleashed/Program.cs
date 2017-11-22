using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _10.Сръбско_Unleashed
{
    class Program
    {
        const string pattern = @"([a-zA-Z]+\s){1,3}@([a-zA-Z0-9]+\s){1,3}[0-9]+\s[0-9]+";
        static void Main(string[] args)
        {
            var entry = Console.ReadLine();
            var dictionary=new Dictionary<string,Dictionary<string,long>>();

            while (entry!="End")
            {
                var matches = Regex.Matches(entry, pattern);
                if (matches.Count > 0)
                {
                    string input = matches[0].Value;
                    var rawEntry = input.Split('@').ToList();
                    var name = rawEntry[0].TrimEnd();
                    var formatedEntry = rawEntry[1].Split().ToList();
                    var ticketPrice = int.Parse(formatedEntry[formatedEntry.Count - 2]);
                    var ticketsCount = int.Parse(formatedEntry[formatedEntry.Count - 1]);
                    formatedEntry.RemoveRange(formatedEntry.Count - 2, 2);
                    var venueName = string.Join(" ", formatedEntry);

                    if (!dictionary.ContainsKey(venueName))
                    {
                        dictionary.Add(venueName, new Dictionary<string, long>());
                    }
                    if (!dictionary[venueName].ContainsKey(name))
                    {
                        dictionary[venueName].Add(name, ticketPrice * ticketsCount);
                    }
                    else
                    {
                        dictionary[venueName][name] += ticketsCount * ticketPrice;
                    }
                }          
                
                entry = Console.ReadLine();
            }

            foreach (var venue in dictionary)
            {
                Console.WriteLine(venue.Key);
                foreach (var artist in venue.Value.OrderByDescending(s=>s.Value))
                {
                    Console.WriteLine($"#  {artist.Key} -> {artist.Value}");
                }
            }
        }
    }
}
