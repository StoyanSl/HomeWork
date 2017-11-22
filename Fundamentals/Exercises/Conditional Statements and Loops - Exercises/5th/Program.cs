using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5th
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (input.EndsWith("y") == true)
            {
                
                Console.WriteLine("{0}ies", input.Remove(input.Length - 1));
            }
            else if(input.EndsWith("o") == true|| input.EndsWith("ch") == true|| input.EndsWith("s") == true|| input.EndsWith("sh") == true|| input.EndsWith("x") == true|| input.EndsWith("z") == true)
            {
                Console.WriteLine("{0}es",input);
            }
            else
            {
                Console.WriteLine("{0}s",input);
            }
        }
    }
}
