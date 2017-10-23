using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _11.Dragon_Army
{
    class Program
    {
        const string pattern = @"([a-zA-Z]+\s)([a-zA-Z]+\s)([0-9]+\s)([0-9]+\s)[0-9]+";
        static void Main(string[] args)
        {
            var headDictionary=new Dictionary<string,Dictionary<string,List<long>>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string entry = Console.ReadLine();
                var inputList=new List<string>();
                var matches = Regex.Matches(entry, pattern);
                if (matches.Count<=0)
                {
                    var defaultValues= new List<string>(){"type","name","45","250","10"};
                    var entryList = entry.Split(' ').ToList();
                    for (int j = 0; j < entryList.Count; j++)
                    {
                        if ( entryList[j] == "null")
                        {

                            entryList[j] = defaultValues[j];
                        }
                    }
                    inputList.AddRange(entryList);
                }
                else
                {
                    inputList = entry.Split(' ').ToList();
                }
                var drakeType = inputList[0];
                var drakeName = inputList[1];
                long dmg = long.Parse(inputList[2]);
                long health = long.Parse(inputList[3]);
                long armour = long.Parse(inputList[4]);
                if (!headDictionary.ContainsKey(drakeType))
                {
                    headDictionary.Add(drakeType,new Dictionary<string, List<long>>());
                }
                if (!headDictionary[drakeType].ContainsKey(drakeName))
                {
                    headDictionary[drakeType].Add(drakeName,new List<long>(){dmg,health,armour});
                }
                else
                {
                    var newList=new List<long>() { dmg, health, armour };
                    headDictionary[drakeType][drakeName].Clear();
                    headDictionary[drakeType][drakeName].AddRange(newList);
                }
            }
            foreach (var drakeType in headDictionary)
            {
                Console.WriteLine($"{drakeType.Key}::({average(drakeType.Key,headDictionary,0):f2}/{average(drakeType.Key, headDictionary, 1):f2}/{average(drakeType.Key, headDictionary, 2):f2})");
                foreach (var drake in drakeType.Value.OrderBy(s=>s.Key))
                {
                    Console.WriteLine($"-{drake.Key} -> damage: {drake.Value[0]}, health: {drake.Value[1]}, armor: {drake.Value[2]}");
                }
            }

        }

        static double average(string drakeType, Dictionary<string, Dictionary<string, List<long>>> headDictionary,int i)
        {
            List<long> averageDmg = new List<long>();
            foreach (var dType in headDictionary)
            {
                if (dType.Key==drakeType)
                {
                    foreach (var list in dType.Value.Values)
                    {
                        averageDmg.Add(list[i]);
                    }
                }
            }
            double averageValue = averageDmg.Average();
            return averageValue;
        }
    }
}
