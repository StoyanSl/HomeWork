using System;
using System.Collections.Generic;
using System.Linq;


namespace _4.Pokemon_Evolution
{
   public class Program
    {
        public static void Main()
        {
            Dictionary<string, List<Tuple<string, int>>> headDict = new Dictionary<string, List<Tuple<string, int>>>();
            var outputList=new List<string>();
            while (true)
            {
                var input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToList();
                if (input[0] == "wubbalubbadubdub")
                {
                    break;
                }
                if (input.Count == 1&&(headDict.ContainsKey(input[0])))
                {
                    outputList.Add(input[0]);
                }               
                if (input.Count > 1)
                {
                    var pokeName = input[0];
                    var pokeEvo = input[1];
                    var evoIndex = int.Parse(input[2]);
                    if (!headDict.ContainsKey(pokeName))
                    {
                        headDict.Add(pokeName, new List<Tuple<string, int>>());
                    }
                    headDict[pokeName].Add(Tuple.Create(pokeEvo,evoIndex));
                }
            }

            foreach (var output in outputList)
            {
                var pokeName = output;             
                    foreach (var pokemon in headDict.Where(s => s.Key == pokeName))
                    {
                        Console.WriteLine($"# {pokemon.Key}");
                       
                            foreach (var tuple in pokemon.Value)
                            {
                                Console.WriteLine($"{tuple.Item1} <-> {tuple.Item2}");
                            }                      
                    }
                
            }
            foreach (var pokemon in headDict)
            {
                Console.WriteLine($"# {pokemon.Key}");
                foreach (var tuple in pokemon.Value.OrderByDescending(s=>s.Item2))
                {
                    Console.WriteLine($"{tuple.Item1} <-> {tuple.Item2}");
                }
            }         
        }
    }
}
