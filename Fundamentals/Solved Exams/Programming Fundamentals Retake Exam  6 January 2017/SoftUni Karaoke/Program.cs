using System;
using System.Collections.Generic;
using System.Linq;

class SoftUni_Karaoke
{
    static void Main()
    {
        Dictionary<string, List<string>> awardedParticipants = new Dictionary<string, List<string>>();
        List<string> participants = InputFormatting();

        List<string> songs = InputFormatting();

        while (true)
        {
            List<string> performance = InputFormatting();
            if (performance[0] == "dawn")
            {
                break;
            }
            if (performance.Count == 3)
            {
                PerformanceFormatting(awardedParticipants, participants, songs, performance);
            }
        }
        Output(awardedParticipants);
    }

     static void PerformanceFormatting(Dictionary<string, List<string>> awardedParticipants, List<string> participants, List<string> songs, List<string> performance)
    {
        var name = performance[0].Trim(' ');
        var song = performance[1].Trim(' ');
        var award = performance[2].Trim(' ');
        if (participants.Contains(name) && songs.Contains(song))
        {
            if (!awardedParticipants.Keys.Contains(name))
            {
                awardedParticipants.Add(name, new List<string>());
            }
            if (!awardedParticipants[name].Contains(award))
            {
                awardedParticipants[name].Add(award);
            }
        }
    }

    private static void Output(Dictionary<string, List<string>> awardedParticipants)
    {
        if (awardedParticipants.Count == 0)
        {
            Console.WriteLine("No awards");
        }
        foreach (var awardedParticipant in awardedParticipants.OrderByDescending(s => s.Value.Count).ThenBy(s => s.Key))
        {
            Console.WriteLine($"{awardedParticipant.Key}: {awardedParticipant.Value.Count} awards");
            foreach (var award in awardedParticipant.Value.OrderBy(s => s))
            {
                Console.WriteLine($"--{award}");
            }
        }
    }

    static List<string> InputFormatting()
    {
      var list =Console.ReadLine()
            .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
            .ToList();
        for (int i = 0; i < list.Count; i++)
        {
            list[i] = list[i].Trim(' ');
        }
        return list;
    }
}

