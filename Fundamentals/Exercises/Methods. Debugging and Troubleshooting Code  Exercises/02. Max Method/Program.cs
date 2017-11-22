using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumberInput = int.Parse(Console.ReadLine());
            int secondNumberInput = int.Parse(Console.ReadLine());
            int thirdNumberInput = int.Parse(Console.ReadLine());
            GetMax(firstNumberInput, secondNumberInput, thirdNumberInput);

        }
        static void GetMax(int firstNumber, int secondNumber, int thirdNumber)
        {
            if (firstNumber > secondNumber && firstNumber > thirdNumber)
            {
                Console.WriteLine(firstNumber);
            }
            else if (secondNumber > firstNumber && secondNumber > thirdNumber)
            {
                Console.WriteLine(secondNumber);
            }
            else
            {
                Console.WriteLine(thirdNumber);
            }
        }
    }
}
