using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Max_Sequence_of_Equal_Elements
{
    public class Program
    {
        public static void Main()
        {

            int[] nums = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
            int start = 0;
            int len = 0;
            int max = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] < nums[i + 1])
                {
                    len++;
                    if (len > max)
                    {
                        start = i - len;


                        max = len;
                    }
                }
                else
                {
                    len = 0;
                }
            }
            for (int i = start + 1; i <= start + max + 1; i++)
            {
                Console.Write(nums[i] + " ");
            }
        }
    }
}
