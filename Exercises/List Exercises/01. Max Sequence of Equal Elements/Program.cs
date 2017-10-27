using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> currentResult=new List<int>();         
            List<int> finalResult=new List<int>();
            int counter = 1;
            int maxCounter = 1;
            currentResult.Add(inputNumbers[0]);
            for (int i = 0; i < inputNumbers.Count-1; i++)
            {
                if (inputNumbers[i]== inputNumbers[i+1])
                {
                    counter++;
                    currentResult.Add(inputNumbers[i+1]);
                }
                else
                {
                    counter = 1;
                    currentResult.Clear();
                    currentResult.Add(inputNumbers[i+1]);
                }
                if (counter>maxCounter)
                {
                    finalResult.Clear();
                    finalResult.AddRange(currentResult);
                    maxCounter = counter;
                }
            }
            Console.WriteLine(String.Join(" ",finalResult));
        }
    }
}

