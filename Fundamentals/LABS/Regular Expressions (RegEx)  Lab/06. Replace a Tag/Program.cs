using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.Replace_a_Tag
{
    class Program
    {
        static void Main(string[] args)
        {
            
                  string input = Console.ReadLine();
            while (input!="end")
            {
                string pattern = @"<a.*?href.*?=(.*)>(.*?)<\/a>";
                string replacer = @"[URL href=$1]$2[/URL]";
                input = Regex.Replace(input, pattern, replacer);
                Console.WriteLine(input);
                input = Console.ReadLine();
            }
        }
    }
}
