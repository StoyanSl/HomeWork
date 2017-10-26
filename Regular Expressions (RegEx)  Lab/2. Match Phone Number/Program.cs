using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2.Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> output=new List<string>();
            string input = Console.ReadLine();
            string pattern = @"(\+359(\s|\-)2\2[\d]{3}\2[\d]{4})\b";
            var collection = Regex.Matches(input, pattern);
            foreach (Match m  in collection)
            {
              output.Add(m.Value);
            }
            Console.WriteLine(string.Join(", ",output));
        }
    }
}
