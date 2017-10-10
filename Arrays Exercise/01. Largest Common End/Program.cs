using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Largest_Common_End
{
    class Program
    {
        static void Main()
        {
            string[] firstInput = Console.ReadLine().Split(' ').Select(s => s).ToArray();
            string[] secondInput = Console.ReadLine().Split(' ').Select(s => s).ToArray();
            int rightCounter = 0;
            int leftCounter = 0;
            while (rightCounter<firstInput.Length&&rightCounter<secondInput.Length)
            {
                if (firstInput[firstInput.Length-1-rightCounter]==secondInput[secondInput.Length-1-rightCounter])
                {
                    rightCounter++;
                }
                else
                {
                    break;
                }
            }
            while (leftCounter < firstInput.Length && leftCounter < secondInput.Length)
            {
                if (firstInput[ leftCounter] == secondInput[leftCounter])
                {
                    leftCounter++;
                }
                else
                {
                    break;
                }
            }
            if (leftCounter>rightCounter)
            {
                Console.WriteLine(leftCounter);
            }
            else
            {
                Console.WriteLine(rightCounter);
            }
        }
    }
}
