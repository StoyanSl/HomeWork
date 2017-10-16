using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English_Name_of_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            long numberInput = long.Parse(Console.ReadLine());
            string writtenNumber = EnglishName(numberInput);
            Console.WriteLine(writtenNumber);

        }
        static string EnglishName(long number)
        {
            string[] a = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            int lastDigit = (int)(Math.Abs(number) % 10);
            string result = a[lastDigit];
            return result;

        }
    }
}
