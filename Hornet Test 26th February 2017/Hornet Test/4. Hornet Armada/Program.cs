using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hornet_Armada
{

    class soldier
    {
        
        public soldier(string type,long soldierCount )
        {
            this.type = type;
            this.soldierCount = soldierCount;
           
        }
        public string type { get; set; }
        public long soldierCount { get; set; }
       
    }
    class Program
    {
        const string pattern = @"([0-9+\][.])";
      
        static void Main()
        {
            var activityDict=new Dictionary<string,long>();
            char[] separators = new Char[] {'=', '-', '>', ':', ' '};
            var legionsDictionary=new Dictionary<string,List<soldier>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var entry = Console.ReadLine().Split(separators,StringSplitOptions.RemoveEmptyEntries).ToList();
                int activity = int.Parse(entry[0]);
                string legionName = entry[1];
                string soldierType = entry[2];
                long soldierCount = long.Parse(entry[3]);
                soldier soldier=new soldier(soldierType,soldierCount);
                if (!legionsDictionary.ContainsKey(legionName))
                {
                    legionsDictionary.Add(legionName,new List<soldier>());
                    activityDict.Add(legionName,0);
                }
                if (legionsDictionary.ContainsKey(legionName))
                {
                    bool flag =true;
                    foreach (var soldierBoy in legionsDictionary[legionName] )
                    {
                        if (soldierBoy.type==soldierType)
                        {
                            soldierBoy.soldierCount += soldierCount;
                            if (activityDict[legionName] < activity)
                            {
                                activityDict[legionName] = activity;
                            }
                            flag = false;
                        }                     
                    }
                    if (flag)
                    {
                        legionsDictionary[legionName].Add(soldier);
                        if (activityDict[legionName] < activity)
                        {
                            activityDict[legionName] = activity;
                        }
                        
                    }                  
                }
               

            }
            var secondEntry = Console.ReadLine();
            var matches = Regex.Matches(secondEntry, pattern);
            bool flagP = false;
            if (matches.Count > 0) flagP = true;
            if (flagP)
            {
                var secondEntrySplit = secondEntry.Split('\\').ToList();
                var activity = int.Parse(secondEntrySplit[0]);
                var soldierType = secondEntrySplit[1];   
                var outputDict=new Dictionary<string,long>();
                foreach (var legion in legionsDictionary)
                {
                    foreach (var soldier in legion.Value)
                    {
                        if (soldier.type==soldierType&&activityDict[legion.Key]<activity)
                        {                         
                            outputDict.Add(legion.Key,soldier.soldierCount);
                        }
                    }
                    
                }
                foreach (var outputSoldier in outputDict.OrderByDescending(s=>s.Value))
                {
                    Console.WriteLine($"{outputSoldier.Key} -> {outputSoldier.Value}");
                }
            }
            else
            {
                var soldierType = secondEntry;
                var outputDict = new Dictionary<string, long>();
                foreach(var legion in legionsDictionary)
                {                  
                        foreach (var soldierBoy in legion.Value)
                        {
                            if (soldierBoy.type == soldierType)
                            {
                                outputDict.Add(legion.Key,activityDict[legion.Key]);
                            }
                        }
                    
                }
                foreach (var outputSoldier in outputDict.OrderByDescending(s => s.Value))
                {
                    Console.WriteLine($"{outputSoldier.Value} : {outputSoldier.Key}");
                }

            }
        }
    }
}
