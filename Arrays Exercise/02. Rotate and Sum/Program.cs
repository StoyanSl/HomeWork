using System;
using System.Linq;


namespace _02.Rotate_and_Sum
{
    class Program
    {
        static void Main()
        {
            long[] nums = Console.ReadLine().Split(' ').Select(s => long.Parse(s)).ToArray();
            long[] sum=new long[nums.Length];
            long rotations = long.Parse(Console.ReadLine());
            for (int r = 0; r < rotations; r++)
            {
                long lastDigit = nums[nums.Length - 1];
                for (long i = nums.Length-1; i>0; i--)
                {
                    nums[i] = nums[i - 1];

                }
                nums[0] = lastDigit;
                for (int i = 0; i < nums.Length; i++)
                {
                    sum[i] = sum[i]+nums[i];
                }
            }
            for (int i = 0; i < sum.Length; i++)
            {
                Console.Write(sum[i]+" ");
               
            }
        }
    }
}
