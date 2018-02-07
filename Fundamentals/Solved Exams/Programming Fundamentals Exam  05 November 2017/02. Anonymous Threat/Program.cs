using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        var array = Console.ReadLine().Split(' ').ToList();
        while (true)
        {
            var input = Console.ReadLine();
            if (input == "3:1")
            {
                break;
            }
            var commands = input.Split(' ').ToList();
            string action = commands[0];
            if (action == "merge")
            {
                int startIndex = int.Parse(commands[1]);
                int endIndex = int.Parse(commands[2]);
                if (startIndex < 0)
                {
                    startIndex = 0;
                }
                if (startIndex > array.Count - 1)
                {
                    continue;
                }
                if (endIndex > array.Count - 1)
                {
                    endIndex = array.Count - 1;
                }
                if (endIndex < 0)
                {
                    continue;
                }
                List<string> mergeList = new List<string>();
                int counter = 0;
                for (int i = startIndex; i <= endIndex; i++)
                {
                    mergeList.Add(array[i]);
                    counter++;
                }

                array.RemoveRange(startIndex, counter);
                array.Insert(startIndex, string.Join("", mergeList));
            }

            if (action == "divide")
            {
                int index = int.Parse(commands[1]);
                int partitions = int.Parse(commands[2]);
                string theMustDivideString = array[index];
                if (theMustDivideString.Length % partitions == 0)
                {
                    array.RemoveAt(index);
                    int groups = theMustDivideString.Length / partitions;
                    int border = theMustDivideString.Length;
                    for (int i = 0; i < border; i += groups)
                    {
                        List<char> dividedChars = new List<char>();
                        for (int j = 0; j < groups; j++)
                        {
                            dividedChars.Add(theMustDivideString[j]);

                        }
                        theMustDivideString = theMustDivideString.Remove(0, groups);
                        var addString = string.Join("", dividedChars);
                        array.Insert(index, addString);
                        index++;
                    }

                }
                else
                {
                    int stringLength = theMustDivideString.Length;
                    while (true)
                    {
                        if (partitions==0)
                        {
                            continue;
                        }
                        if (partitions>theMustDivideString.Length-1)
                        {
                            continue;

                        }
                        if (stringLength % partitions == 0)
                        {
                            array.RemoveAt(index);
                            int groups = theMustDivideString.Length / partitions;
                           
                            var addString = "";
                            int border = stringLength;
                            for (int i = 0; i < border; i += groups)
                            {
                                
                                List<char> dividedChars = new List<char>();
                                if (i >= border - groups )
                                {
                                    for (int j = 0; j < theMustDivideString.Length; j++)
                                    {
                                        dividedChars.Add(theMustDivideString[j]);
                                    }
                                    addString = string.Join("", dividedChars);
                                    array.Insert(index, addString);
                                    break;

                                }
                                else
                                {
                                    for (int j = 0; j < groups; j++)
                                    {
                                        dividedChars.Add(theMustDivideString[j]);

                                    }
                                    theMustDivideString = theMustDivideString.Remove(0, groups);
                                    addString = string.Join("", dividedChars);
                                    array.Insert(index, addString);
                                    index++;
                                }

                            }
                            break;

                        }
                        else
                        {
                            stringLength--;
                        }
                    }
                }

            }

        }
        Console.WriteLine(string.Join(" ", array));

    }
}

