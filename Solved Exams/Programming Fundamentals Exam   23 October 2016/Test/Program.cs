using System;
using System.Linq;
using System.Text.RegularExpressions;

class Winning_Ticket
{
    static void Main()
    {
        var inputData = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        var patterns = new string[] { "\\@{6,9}", "\\#{6,9}", "\\${6,9}", "\\^{6,9}" };

        foreach (var ticket in inputData)
        {
            if (ticket.Length != 20)
            {
                Console.WriteLine("invalid ticket");
                continue;
            }

            string part1 = new string(ticket.Take(10).ToArray());
            string part2 = new string(ticket.Skip(10).Take(10).ToArray());
            //Console.WriteLine(part1);
            //Console.WriteLine(part2);
            bool match = false;

            for (int i = 0; i < patterns.Length; i++)
            {

                if (Regex.IsMatch(part1, patterns[i]) && Regex.IsMatch(part2, patterns[i]))
                {
                    string symbol = GenerateSymbol(i);
                    int repeats = CalculateSymbolsRepeats(part1, char.Parse(symbol),part2);
                    if (repeats == 10)
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - {repeats}{symbol} Jackpot!");
                        match = true;
                        continue;
                    }
                    Console.WriteLine($"ticket \"{ticket}\" - {repeats}{symbol}");
                    match = true;
                    continue;

                }

            }
            if (!match)
            {
                Console.WriteLine($"ticket \"{ ticket}\" - no match");
            }

        }

    }

    public static string GenerateSymbol(int num)
    {

        switch (num)
        {
            case 0:
                return "@";
            case 1:
                return "#";
            case 2:
                return "$";
            case 3:
                return "^";
            default:
                return "error";
        }


    }

    public static int CalculateSymbolsRepeats(string part, char symb,string part2)
    {
        int count = 0;
        int max = 0;
        for (int i = 0; i < part.Length; i++)
        {
            if (part[i] == symb)
            {
                count++;
                if (max < count)
                {
                    max = count;

                }
            }
            else
            {
                count = 0;
            }
        }
        int count2 = 0;
        int max2 = 0;
        for (int i = 0; i < part2.Length; i++)
        {
            if (part2[i] == symb)
            {
                count2++;
                if (max2 < count2)
                {
                    max2 = count2;

                }
            }
            else
            {
                count2 = 0;
            }
        }
        return Math.Min(max2, max);
    }
}
