using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LadyBugsSecondSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = int.Parse(Console.ReadLine());
            var indexes = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] field = new int[arraySize];
            FillingTheArray(indexes, field);
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                var commands = input.Split(' ').ToList();
                long commandIndex = long.Parse(commands[0]);
                string command = commands[1];
                long commandPlaces = long.Parse(commands[2]);
                if (command == "right")
                {
                    if (commandPlaces >= 0)
                    {
                        MoveToRight(field, commandIndex, commandPlaces);
                    }
                    else
                    {
                      
                         MoveToLeft(field, commandIndex, commandPlaces * -1);
                    }

                }
                else
                {
                    if (commandPlaces >= 0)
                    {
                         MoveToLeft(field, commandIndex, commandPlaces);
                    }
                    else
                    {
                       
                        MoveToRight(field, commandIndex, commandPlaces * -1);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", field));
        }

        private static long MoveToLeft(int[] field, long commandIndex, long commandPlaces)
        {
            while (true)
            {
                if (commandIndex > field.Length - 1 || commandIndex < 0 || field[commandIndex] == 0 || commandPlaces == 0) break;
                if (commandIndex - commandPlaces < 0 || Math.Abs(commandIndex - commandPlaces) > field.Length - 1) { field[commandIndex] = 0; break; }
                if (field[commandIndex - commandPlaces] == 0)
                {
                    field[commandIndex - commandPlaces] = 1;
                    field[commandIndex] = 0;
                    break;
                }
                else
                {
                    commandPlaces += commandPlaces;
                }
            }

            return commandPlaces;
        }

        private static long MoveToRight(int[] field, long commandIndex, long commandPlaces)
        {
            while (true)
            {

                if (commandIndex > field.Length - 1 || commandIndex < 0 || field[commandIndex] == 0 || commandPlaces == 0) break;

                if (commandIndex + commandPlaces > field.Length - 1 || commandIndex + commandPlaces < 0) { field[commandIndex] = 0; break; }
                if (field[commandIndex + commandPlaces] == 0)
                {
                    field[commandIndex + commandPlaces] = 1;
                    field[commandIndex] = 0;
                    break;
                }
                else commandPlaces += commandPlaces;

            }

            return commandPlaces;
        }

        private static void FillingTheArray(List<int> indexes, int[] field)
        {
            for (int i = 0; i < field.Length; i++)
            {
                if (indexes.Contains(i))
                {
                    field[i] = 1;
                }
                else
                {
                    field[i] = 0;
                }
            }
        }
    }
}
