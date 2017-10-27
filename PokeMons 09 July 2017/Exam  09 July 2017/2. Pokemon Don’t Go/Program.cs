using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Pokemon_Don_t_Go
{
public class Program
    {
        public static void Main()
        {
            var inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var outputList=new List<int>();
            while (inputList.Count > 0)
            {
                var flag = 0;
                var index = int.Parse(Console.ReadLine());
                if (index < 0)
                {
                    var swap = inputList[inputList.Count - 1];
                    flag = inputList[0];
                    outputList.Add(flag);
                    inputList.RemoveAt(0);
                    inputList.Insert(0, swap);
                    for (int i = 0; i < inputList.Count; i++)
                    {
                        if (inputList[i] <= flag)
                        {
                            inputList[i] += flag;
                        }
                        else
                        {
                            inputList[i] -= flag;
                        }
                    }
                }
                else if (index>=0&&index<inputList.Count)
                {
                    flag = inputList[index];
                    inputList.RemoveAt(index);
                    outputList.Add(flag);
                    for (int i = 0; i < inputList.Count; i++)
                    {
                        if (inputList[i] <= flag)
                        {
                            inputList[i] += flag;
                        }
                        else
                        {
                            inputList[i] -= flag;
                        }
                    }
                }
                else
                {
                    var swap = inputList[0];
                    
                    flag = inputList[inputList.Count - 1];
                    outputList.Add(flag);
                    inputList.RemoveAt(inputList.Count - 1);
                    inputList.Add(swap);
                    for (int i = 0; i < inputList.Count; i++)
                    {
                        if (inputList[i] <= flag)
                        {
                            inputList[i] += flag;
                        }
                        else
                        {
                            inputList[i] -= flag;
                        }
                    }
                }
            }
            Console.WriteLine(outputList.Sum());
        }
        }
    }

