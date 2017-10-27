using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _08.Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(' ').Select(s => s).ToArray();
            int counter = 1;
            int maxCounter = 0;
            string result = " ";
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != " ")
                {
                    for (int j = i + 1; j < numbers.Length; j++)
                    {
                        if (numbers[i] == numbers[j])
                        {
                            counter++;
                            numbers[j] = " ";
                            if (counter > maxCounter)
                            {
                                result = numbers[i];
                                maxCounter = counter;
                            }
                        }
                    }
                    counter = 1;
                }
            }
            if (result==" ")
            {
                Console.WriteLine(numbers[0]);
            }
            else
            {
                Console.WriteLine(result);
            }
           
           
        }
    }
}
