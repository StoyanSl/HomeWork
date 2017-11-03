using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        var array = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
        while (true)
        {
            string commands = Console.ReadLine();
            if (commands=="end")
            {
                break;
            }
            var commandsTokens = commands.Split(' ').Select(s=>s.Trim(' ')).ToList();
            string command = commandsTokens[0];
            if (command=="swap")
            {
                Swaper(array, commandsTokens);
            }
            else if (command == "multiply")
            {
                Multiplier(array, commandsTokens);
            }
            else
            {
                Decreaser(array);
            }
        }
        Console.WriteLine(string.Join(", ",array));
    }

     static void Decreaser(List<long> array)
    {
        for (int i = 0; i < array.Count; i++)
        {
            array[i]--;
        }
    }

     static void Multiplier(List<long> array, List<string> commandsTokens)
    {
        int index1 = int.Parse(commandsTokens[1]);
        int index2 = int.Parse(commandsTokens[2]);
        array[index1] = array[index1] * array[index2];
    }

     static void Swaper(List<long> array, List<string> commandsTokens)
    {
        int index1 = int.Parse(commandsTokens[1]);
        int index2 = int.Parse(commandsTokens[2]);
        long swap = array[index1];
        array[index1] = array[index2];
        array[index2] = swap;
    }
}

