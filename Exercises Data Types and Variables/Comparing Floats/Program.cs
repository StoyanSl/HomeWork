using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparing_Floats
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double result = 0.0;
            double eps = 0.000001;
            if (firstNumber>secondNumber)
            {
                result = firstNumber - secondNumber;
            }
            else
            {
                result = secondNumber - firstNumber;
            }
            if (result<0)
            {
               result= result * -1;
            }
            if (result>=eps)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }
        }
    }
}
