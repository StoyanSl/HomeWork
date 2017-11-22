using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Match_Dates
{
    public class Program
    {
        public static void Main()
        {
            var pattern = @"\b((?<day>[\d]{2})(\.|\/|\-)(?<month>[A-z][a-z]{2})\2(?<year>\d{4}))\b";
            string input = Console.ReadLine();
            var Matches = Regex.Matches(input, pattern);
            foreach (Match match in Matches)
            {
                var day = match.Groups["day"].Value;
                var month = match.Groups["month"].Value;
                var year = match.Groups["year"].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
