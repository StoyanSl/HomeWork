using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringPattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            var input = Console.ReadLine();
            Regex pattern=new Regex(stringPattern);
            foreach (Match m in pattern.Matches(input))
            {
                Console.Write(m+" ");
            }
        }
    }
}
