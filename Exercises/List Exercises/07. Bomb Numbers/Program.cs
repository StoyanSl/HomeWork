using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] bombInput = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i <inputNumbers.Count; i++)
            {
                if (inputNumbers[i]==bombInput[0])
                {

                    for (int j = 1; j <= bombInput[1]; j++)
                    {
                        if (i - j < 0)
                        {
                            break;
                        }
                        else
                        {
                            inputNumbers[i - j] = 0;
                        }
                    }
                    for (int j = 0; j <= bombInput[1]; j++)
                    {
                        if (i+j>=inputNumbers.Count)
                        {
                            break;
                        }
                        else
                        {
                            inputNumbers[i + j] = 0;
                        }
                    }
                    inputNumbers[i] = 0;
                }
            }
            Console.WriteLine(inputNumbers.Sum());
        }
    }
}
