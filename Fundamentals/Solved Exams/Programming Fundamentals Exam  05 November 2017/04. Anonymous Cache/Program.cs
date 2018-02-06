using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Anonymous_Cache
{
    class Program
    {
        static void Main()
        {
            Dictionary<string,List<Tuple<string,long>>> headDict=new Dictionary<string, List<Tuple<string, long>>>();
            Dictionary<string, List<Tuple<string, long>>> cacheDict = new Dictionary<string, List<Tuple<string, long>>>();
            Dictionary<string,long> sumDict=new Dictionary<string, long>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input== "thetinggoesskrra")
                {
                    break;
                    
                }
                var splitedInput = input.Split(new string[] {" | "}, StringSplitOptions.RemoveEmptyEntries).ToList();
                if (splitedInput.Count==1)
                {
                    string dataset = splitedInput[0];
                    if (!headDict.ContainsKey(dataset))
                    {
                        headDict.Add(dataset, new List<Tuple<string, long>>());
                    }
                    if (cacheDict.ContainsKey(dataset))
                    {
                        headDict[dataset].AddRange(cacheDict[dataset]);
                    }
                }
                else
                {
                    var data = splitedInput[0].Split(new string[] {" -> "}, StringSplitOptions.RemoveEmptyEntries)
                        .ToList();
                    string dataKey = data[0];
                    string dataset = splitedInput[1];
                    long dataSize = long.Parse(data[1]);
                    if (headDict.ContainsKey(dataset))
                    {
                        headDict[splitedInput[1]].Add(Tuple.Create(dataKey,dataSize));
                    }
                    else
                    {
                        if (!cacheDict.ContainsKey(dataset))
                        {
                            cacheDict.Add(dataset,new List<Tuple<string, long>>());
                        }
                        cacheDict[dataset].Add(Tuple.Create(dataKey,dataSize));
                    }
                }

            }
            foreach (var data in headDict)
            {
                sumDict.Add(data.Key,0);
                foreach (var tuple in data.Value)
                {
                    sumDict[data.Key] += tuple.Item2;
                }
            }
        
            foreach (var summedData in sumDict.OrderByDescending(s => s.Value))
            {
                foreach (var data in headDict)
                {
                    if (data.Key == summedData.Key)
                    {
                        Console.WriteLine($"Data Set: {data.Key}, Total Size: {sumDict[data.Key]}");
                        foreach (var tuple in data.Value)
                        {
                            Console.WriteLine($"$.{tuple.Item1}");
                        }
                    }
                }
                break;
                
            }
            
        }
    }

    
}
