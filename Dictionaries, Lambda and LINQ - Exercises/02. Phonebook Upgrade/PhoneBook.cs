using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Phonebook
{
    class PhoneBok
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var phonebook = new SortedDictionary<string, string>();
            while (input != "END")
            {
                var commands = input.Split(' ').ToArray();
                if (commands[0] == "A")
                {
                    phonebook[commands[1]] = commands[2];
                }
                else if (commands[0] == "S")
                {
                    if (phonebook.ContainsKey(commands[1]))
                    {
                        Console.WriteLine("{0} -> {1}", commands[1], phonebook[commands[1]]);
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.", commands[1]);
                    }
                }
                else if (commands[0] == "ListAll")
                {
                    foreach (var contact in phonebook)
                    {
                        Console.WriteLine("{0} -> {1}", contact.Key, contact.Value);
                    }
                }
                input = Console.ReadLine();
            }
        }
    }
}
