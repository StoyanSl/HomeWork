using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13th
{
    class Program
    {
        static void Main(string[] args)
        {
            int flag = 0;
            int blah = 0;
            int digitOne = 0;
            int digitTwo = 0;
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            for (int i = first; i <= second; i++)
            {
                for (int k = first; k <=second; k++)
                {
                   if(k+i==third)
                    {
                        digitOne = i;
                        digitTwo = k;
                        flag = 1;
                    }
                    blah++;
                }
            }
            if (flag == 1)
            {
                Console.WriteLine("Number found! {0} + {1} = {2}", digitOne, digitTwo, third);
            }
            else
            {
                Console.WriteLine("{0} combinations - neither equals {1}",blah,third);
            }
        }
    }
}