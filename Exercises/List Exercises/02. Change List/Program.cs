using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string[] commands = Console.ReadLine().Split(' ').ToArray();
            while (commands[0]!="Odd"&&commands[0]!="Even")
            {
                if (commands[0]=="Delete")
                {
                    input.RemoveAll(p => p == int.Parse(commands[1]));
                }
                else
                {
                    input.Insert(int.Parse(commands[2]),int.Parse(commands[1]));
                }
                 commands = Console.ReadLine().Split(' ').ToArray();
            }
            if (commands[0]=="Even")
            {
                foreach (var num in input)
                {
                    if (num%2==0)
                    {
                        Console.Write("{0} ", num);
                    }
                }
            }
            else
            {
                foreach (var num in input)
                {
                    if (num % 2 != 0)
                    {
                       Console.Write("{0} ",num);
                    }
                }
            }
        }
    }
}
