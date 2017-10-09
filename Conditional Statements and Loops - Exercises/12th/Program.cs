using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            int comb = 0;
            int sum = 0;
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            for (int i=first ; i >=1; i--)
            {
                for (int k = 1; k <= second; k++)
                {                   
                    comb++;
                    sum = sum + 3 * (i * k);
                    if (third<=sum)
                    {                       
                        Console.WriteLine("{0} combinations",comb);
                        Console.WriteLine("Sum: {0} >= {1}",sum,third);
                        break;                      
                    }
                    
                }
                if (third <= sum) { break; }
            }
            if(third>sum)
            {
                Console.WriteLine("{0} combinations",comb);
                Console.WriteLine("Sum: {0}",sum);
            }
        }
    }
}
