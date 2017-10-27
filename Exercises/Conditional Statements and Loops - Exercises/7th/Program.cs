using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7th
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            while(true)
            {
                string input = Console.ReadLine();
                
                if(input!="Bake!")
                {
                    Console.WriteLine("Adding ingredient {0}.",input);
                    count++;
                }
                else
                {
                    Console.WriteLine("Preparing cake with {0} ingredients.",count);
                    break;
                }
            }
        }
    }
}
