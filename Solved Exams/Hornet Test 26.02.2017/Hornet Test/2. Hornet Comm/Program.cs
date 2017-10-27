using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3.Hornet_Comm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Messages = new List<string>();
            List<string> Broadcast = new List<string>();
            string patternMessage = @"(\d+) \<\-\> ([a-zA-Z0-9]+)$";
            string patternBroadcast = @"(\D+) \<\-\> ([a-zA-Z0-9]+)$";
            Regex messageRegex = new Regex(patternMessage);
            Regex broadcastRegex = new Regex(patternBroadcast);
            string input = Console.ReadLine();
            while (input != "Hornet is Green")
            {
                if (messageRegex.IsMatch(input))
                {
                    var splitInput = input.Split(new string[] {" <-> "}, StringSplitOptions.RemoveEmptyEntries)
                        .ToList();

                    var frequency = string.Join("", splitInput[0].Reverse());
                    var message = splitInput[1];
                    Messages.Add(frequency + " -> " + message);
                }

                if (broadcastRegex.IsMatch(input))
                {
                    var splitInput = input.Split(new string[] {" <-> "}, StringSplitOptions.RemoveEmptyEntries)
                        .ToList();
                    var message = splitInput[0];
                    var recipent = decrypting(splitInput[1]);
                    Broadcast.Add(recipent + " -> " + message);
                }
                input = Console.ReadLine();
            }

            Console.WriteLine("Broadcasts:");
            if (Broadcast.Count > 0)
            {
                Console.WriteLine(string.Join("\n", Broadcast));
            }
            else
            {
                Console.WriteLine("None");
            }
            Console.WriteLine("Messages:");
            if (Messages.Count > 0)
            {
                Console.WriteLine(string.Join("\n", Messages));
            }
            else
            {
                Console.WriteLine("None");
            }
        }

        static string decrypting(string str)
        {
            var decryted = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 65 && str[i] <= 90)
                {
                    decryted += (char)(str[i] + 32);

                }
                else if (str[i] >= 97 && str[i] <= 122)
                {
                    decryted += (char)(str[i] - 32);
                }
                else
                {
                    decryted += (char)str[i];
                }

            }
            return decryted;
        }
    }
}
