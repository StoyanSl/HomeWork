using System;
using System.Collections.Generic;
using System.Linq;

public class RotatеSum
{
    public static void Main()
    {
        int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int n = int.Parse(Console.ReadLine());
        int[] sum = new int[nums.Length];

        for (int i = 0; i < n; i++)
        {
            int lastElement = nums[nums.Length - 1];
            for (int e = nums.Length - 1; e > 0; e--)
            {
                nums[e] = nums[e - 1];
            }
            nums[0] = lastElement;
 
            Console.WriteLine();
            for (int w = 0; w < nums.Length; w++)
            {
                sum[w] += nums[w];
            }
        }
        Console.WriteLine(string.Join(" ", sum));

    }
}