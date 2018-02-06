using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Anonymous_Vox
{

    class Program
    {
        const string pattern = @"([a-zA-Z]+)(?<placeholder>.*)(\1)";

        static void Main()
        {
            string input = Console.ReadLine();
            var values = Console.ReadLine().Split(new char[] {'{', '}'}).ToList();
            for (int i = 0; i < values.Count; i++)
            {
                if (values[i] == "")
                {
                    values.Remove(values[i]);
                }
            }
            string placeholder = "";
            var matches = Regex.Matches(input, pattern);
            List<string> replacers=new List<string>();
            List<string> outputList = new List<string>();
            int index = 0;
            foreach (Match match in matches)
            {
                outputList.Add(match.Value);
                replacers.Add( $"{match.Groups[1]}{values[index]}{match.Groups[1]}");
                index++;
            }
            StringBuilder sb=new StringBuilder();
            for (int i = 0; i < replacers.Count; i++)
            {
                input = input.Replace(outputList[i], replacers[i]);
            }
            
            Console.WriteLine(input);

        }
    }
}
