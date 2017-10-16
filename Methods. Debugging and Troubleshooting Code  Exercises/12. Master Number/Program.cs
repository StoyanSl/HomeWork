using System;

using System.Linq;


namespace Master_Number
{
    class Program
    {

        static void Main()
        {
            int n = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            for (int i = 0; i < n; i++)
            {

                if (IsPalindrome(i) && SumOfDigits(i) % 7 == 0 && EvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool IsPalindrome(int i)
        {
            string arr = "" + i;
            if (arr.SequenceEqual(arr.Reverse()))
            {
                return true;
            }
            return false;
        }
        static int SumOfDigits(int i)
        {
            int a = 0;
            while (i > 0)
            {
                a += i % 10;
                i = i / 10;
            }
            return a;
        }
        static bool EvenDigit(int i)
        {
            string arr = "" + i;
            for (int j = 0; j < arr.Length; j++)
            {
                int a = int.Parse(arr[j].ToString());
                if (a % 2 == 0 && i != 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
