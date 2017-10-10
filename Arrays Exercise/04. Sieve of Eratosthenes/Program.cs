using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            bool[] array = new bool[input+1];
            for (int j = 2; j <Math.Sqrt(input); j++)
            {
                for (int i = j*j; i <=input; i=i+j)
                {
                    array[i] = true;
                }
            }
            List<int> output=new List<int>();
            for (int i = 2; i < array.Length; i++)
            {
                if (array[i]==false)
                {
                    output.Add(i);
                }
            }
            Console.WriteLine(string.Join(" ",output));
        }
    }
}
