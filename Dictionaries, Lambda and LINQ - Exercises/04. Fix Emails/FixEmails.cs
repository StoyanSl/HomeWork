using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fix_Emails
{
    class FixEmails
    {
        static void Main(string[] args)
        {
            var emailDict = new Dictionary<string, string>();
            for (int i = 0; ; i++)
            {
                string name = Console.ReadLine();
                if (name.Equals("stop"))
                {
                    break;
                }
                string email = Console.ReadLine();
                if (email.EndsWith("us".ToLower()) || email.EndsWith("uk".ToLower()))
                {
                    continue;
                }
                if (!emailDict.ContainsKey(name))
                {
                    emailDict.Add(name, email);
                }

            }
            foreach (var person in emailDict)
            {
                Console.WriteLine("{0} -> {1}", person.Key, person.Value);
            }
        }
    }
}
