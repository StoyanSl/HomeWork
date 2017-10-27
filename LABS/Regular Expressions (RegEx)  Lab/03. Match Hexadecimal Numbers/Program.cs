using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Match_Hexadecimal_Numbers
{
    public class Program
    {
        public static void Main()
        {
            string pattern = @"\b((?:0x|\b)[0-9A-F]+)\b";
            string input=Console.ReadLine();
            var matches =Regex.Matches(input, pattern);
            foreach (Match m in matches)
            {
                Console.Write(m+" ");
            }
        }
    }
}
