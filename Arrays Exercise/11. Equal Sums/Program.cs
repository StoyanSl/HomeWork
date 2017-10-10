using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _11.Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
            int number = 0;
            bool flag = false;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i==0)
                {
                    int sum = 0;
                    for (int j = i+1; j < nums.Length; j++)
                    {
                        sum += nums[j];
                    }
                    if (sum==0)
                    {
                        number = i;
                        flag = true;
                    }
                }
                if (i==1)
                {
                    int sum = 0;
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        sum += nums[j];
                    }
                    if (sum == nums[0])
                    {
                        number = i;
                        flag = true;
                    }
                }
                if (i>1&&i<nums.Length-1)
                {
                    int sum = 0;
                    int sum2 = 0;
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        sum += nums[j];
                    }
                    for (int j = 0; j < i; j++)
                    {
                        sum2 += nums[j];
                    }
                    if (sum == sum2)
                    {
                        number = i;
                        flag = true;
                    }
                }
                if (i==nums.Length-1)
                {
                    int sum = 0;
                    for (int j = 0; j < nums.Length-1; j++)
                    {
                        sum += nums[j];
                    }
                    if (sum == 0)
                    {
                        number = i;
                        flag = true;
                    }
                }
            }
            if (flag)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
