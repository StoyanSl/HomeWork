using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9th
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            while(true)
            try
            {
              long input = long.Parse(Console.ReadLine());
              count++;
            }
            catch(Exception)
            {
                    Console.WriteLine(count);
                    break;
            }
        }
    }
}
