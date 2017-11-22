using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberInput = Console.ReadLine();
            string output = Reverse(numberInput);
            Console.WriteLine(output);
        }
        public static string Reverse(string number)
        {
            char[] charArray = number.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
