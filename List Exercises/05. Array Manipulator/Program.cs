using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string[] commands = Console.ReadLine().Split(' ').ToArray();

            while (commands[0] != "print")
            {
                if (commands[0] == "add")
                {
                    numbers.Insert(int.Parse(commands[1]), int.Parse(commands[2]));
                }

                else if(commands[0] == "addMany")
                {
                    int pos = int.Parse(commands[1]);
                    for (int i = 2; i < commands.Length; i++)
                    {
                        numbers.Insert(pos, int.Parse(commands[i]));
                        pos++;
                    }
                }
                else if (commands[0] == "contains")
                {
                    Console.WriteLine(numbers.IndexOf(int.Parse(commands[1])));
                }
                else if (commands[0] == "remove")
                {
                    numbers.RemoveAt(int.Parse(commands[1]));
                }
                else if (commands[0] == "shift")
                {
                    int positionsToMove = int.Parse(commands[1]);
                    for (int j = 0; j < positionsToMove; j++)
                    {
                        int firstElement = numbers[0];
                        for (int i = 1; i < numbers.Count; i++)
                        {
                            numbers[i - 1] = numbers[i];
                        }
                        numbers[numbers.Count - 1] = firstElement;
                    }
                }
                else if (commands[0] == "sumPairs")
                {
                    for (int i = 0; i < numbers.Count - 1; i += 2)
                    {
                        numbers[i] += numbers[i + 1];
                        numbers[i + 1] = -1;
                    }
                    numbers.RemoveAll(x => x == -1);

                }

                commands = Console.ReadLine().Split(' ').ToArray();
            }
            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }

    }
}
