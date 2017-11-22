using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


class WinningTicket
{
    const string pattern = @"([$]{6,9})|([@]{6,9})|([\^]{6,9})|([#]{6,9})";
    private const string pattern2 = @"([$]{10})|([@]{10})|([\^]{10})|([#]{10})";
    static void Main()
    {
        List<string> outputList = new List<string>();
        var tickets = Console.ReadLine().Split(',').ToList();
        for (int i = 0; i < tickets.Count; i++)
        {
            tickets[i] = tickets[i].Trim(' ');
        }
        for (int i = 0; i < tickets.Count; i++)
        { 

            outputList.Add(FormatingTheTicket(tickets[i]));
          
        }
    Console.WriteLine(String.Join("\n", outputList));
    }

    static string FormatingTheTicket(string ticket)
    {
        if (ticket.Length == 20)
        {
            var firstPart = ticket.Substring(0, 10);
            var secondPart = ticket.Substring(10);
            var firstPartMatch = Regex.Match(firstPart, pattern);
            var secondPartMatch = Regex.Match(secondPart, pattern);
            var firstPartJackpotMatch = Regex.Match(firstPart, pattern2);
            var secondPartJackpotMatch = Regex.Match(secondPart, pattern2);

            if (firstPartJackpotMatch.Value == secondPartJackpotMatch.Value && firstPartJackpotMatch.Success)
            {

                return
                    $"ticket \"{ticket}\" - {firstPartJackpotMatch.Value.Length}{firstPartJackpotMatch.Value[0]} Jackpot!";
            }
            else if (firstPartMatch.Success && secondPartMatch.Success)
            {
                if (firstPartMatch.Value[0] == secondPartMatch.Value[0])
                {
                    return
                        $"ticket \"{ticket}\" - {Math.Min(firstPartMatch.Value.Length, secondPartMatch.Value.Length)}{firstPartMatch.Value[0]}";
                }
            }
            else
            {
                return $"ticket \"{ticket}\" - no match";
            }
        }      
            return $"invalid ticket";
    }
}

