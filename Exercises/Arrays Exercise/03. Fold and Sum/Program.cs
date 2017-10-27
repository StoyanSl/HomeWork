using System;

using System.Linq;


namespace _03.Fold_and_Sum
{
    class Program
    {
        static void Main()
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] firstRow1=new int[nums.Length/4];
            int[] firstRow2 = new int[nums.Length / 4];
            int[] firstRow= new int[nums.Length/2];
            int[] sum=new int[nums.Length/2];
            for (int i = 0; i <nums.Length/4; i++)
            {
                firstRow1[i] = nums[i];
            }
            Array.Reverse(firstRow1);
            for (int i = (nums.Length/4)+(nums.Length/2); i < nums.Length; i++)
            {
                firstRow2[i- ((nums.Length / 4) + (nums.Length / 2))] = nums[i];
            }
            Array.Reverse(firstRow2);
            for (int i = 0; i < firstRow.Length/2; i++)
            {
                firstRow[i] = firstRow1[i];
            }
            for (int i = firstRow.Length/2; i < firstRow.Length; i++)
            {
                firstRow[i] = firstRow2[i - nums.Length / 4];
            }
            for (int i = nums.Length/4; i <(nums.Length / 4) + (nums.Length / 2); i++)
            {
                sum[i - nums.Length / 4] = firstRow[i- nums.Length / 4] + nums[i];
            }
            for (int i = 0; i < sum.Length; i++)
            {
                Console.Write(sum[i]+" ");
            }
        }
    }
}
