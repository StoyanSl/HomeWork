using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Pairs_by_Difference
{
   public class Program
    {
       public static void Main()
        {
            int[] nums = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
            int input = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    int difference = nums[i] - nums[j];
                   
                    if (Math.Abs(difference) == input) 
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
