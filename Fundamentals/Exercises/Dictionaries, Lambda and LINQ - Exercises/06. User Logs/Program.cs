using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.User_Logs
{
    class Program
    {
      
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, int>> userDictionary = new SortedDictionary<string, Dictionary<string, int>>();
            List<string> entry = Console.ReadLine().Split().ToList();
            while (entry[0]!="end")
            {
                string IP = entry[0].Substring(entry[0].IndexOf('=') + 1);
                string user = entry[2].Substring(entry[2].IndexOf('=') + 1);              
                if (!userDictionary.Keys.Contains(user))
                {
                    userDictionary.Add(user,new Dictionary<string, int>());
                    AdressCheck(userDictionary[user],IP);
                }
                else
                {
                    AdressCheck(userDictionary[user], IP);
                }
                entry = Console.ReadLine().Split().ToList();
            }
            foreach (var user in userDictionary)
            {
                Console.WriteLine($"{user.Key}: ");
                int br = 0;
                foreach (var adress in user.Value)
                {
                   
                    if (br==user.Value.Count-1)
                    {
                        Console.Write($"{adress.Key} => {adress.Value}.");
                        Console.WriteLine();
                        br++;
                    }
                    else
                    {
                        Console.Write($"{adress.Key} => {adress.Value}, ");
                        br++;
                    }                   
                }
            }
        }
        static void AdressCheck(Dictionary<string, int> adres, string IP)
        {
            if (!adres.ContainsKey(IP))
            {
                adres.Add(IP, 1);
            }
            else
            {
                adres[IP]++;
            }
        }
    }
}
