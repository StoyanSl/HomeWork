using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3.Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string didiPattern = @"[^a-zA-Z\-]+";
            string bojoPattern = @"([a-zA-Z]+-[a-zA-Z]+)";
            List<string> outputList=new List<string>();
            int i = 2;
            while (true)
            {
                if (i%2==0)
                {
                    var didimatch = Regex.Match(input, didiPattern);
                    if (didimatch.Success)
                    {
                        outputList.Add(didimatch.Value);
                        input = input.Substring(didimatch.Index+didimatch.Value.Length);
                    }
                    else
                    {
                        break;
                    }
                   
                }
                if (i%2!=0)
                {
                    var bojomatch = Regex.Match(input, bojoPattern);
                    if (bojomatch.Success)
                    {
                        outputList.Add(bojomatch.Value);
                        input = input.Substring(bojomatch.Index+bojomatch.Value.Length);
                    }
                    else
                    {
                        break;
                    }
                }
                i++;
            }
            foreach (var output in outputList)
            {
                Console.WriteLine(output);
            }
        }
    }
}
