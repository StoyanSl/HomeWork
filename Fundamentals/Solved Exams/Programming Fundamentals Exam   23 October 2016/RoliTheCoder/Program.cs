using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoliTheCoder
{
    class Event
    {
        public Event(string name)
        {
            this.name = name;
            this.participants = new List<string>();
        }
        public string name { get; set; }
        public List<string> participants { get; set; }
    }
    class Program
    {
        static void Main()
        {
            Dictionary<int, Event> EventsDictionary = new Dictionary<int, Event>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Time for Code")
                {
                    break;

                }
                var formatedInput = input.Split(' ').Select(s => s.Trim(' ')).ToList();
                int id = int.Parse(formatedInput[0]);
               
                string eventName = formatedInput[1];
                if (eventName[0] != '#')
                {
                    continue;
                }
                if (eventName.Length==0)
                {
                    continue;
                }
                if (!EventsDictionary.ContainsKey(id))
                {
                    EventsDictionary.Add(id, new Event(eventName));
                }
                if (EventsDictionary.ContainsKey(id))
                {
                    if (EventsDictionary[id].name == eventName)
                    {
                        for (int i = 2; i < formatedInput.Count; i++)
                        {
                            if (!EventsDictionary[id].participants.Contains(formatedInput[i]) && formatedInput[i].Length > 0 && formatedInput[i][0]=='@')
                            {
                                EventsDictionary[id].participants.Add(formatedInput[i]);
                            }
                        }
                    }
                    else
                    {
                        continue;
                    }
                }

               
            }
            foreach (var eve in EventsDictionary.OrderByDescending(s=>s.Value.participants.Count).ThenBy(s=>s.Value.name))
            {
                Console.WriteLine($"{eve.Value.name.TrimStart('#')} - {eve.Value.participants.Count}");
                foreach (var participant in eve.Value.participants.OrderBy(s=>s))
                {
                    Console.WriteLine(participant);
                }
            }
        }
    }
}
