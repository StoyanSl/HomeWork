using System;
using System.Collections.Generic;
using System.Linq;

namespace _9.Legendary_Farming_2Dicts_Solve
{
    class Program
    {
        static void Main()
        {
            var dictionary = new Dictionary<string, int>();
            var keymaterials=new Dictionary<string,int>();
            keymaterials.Add("shards", 0);
            keymaterials.Add("fragments", 0);
            keymaterials.Add("motes", 0);
            string winner = "";
            bool end = true;
            while (end)
            {
                var entry = Console.ReadLine().ToLower().Split().ToList();               
                for(int i=1;i<entry.Count;i+=2)
                {
                    
                    int quantity = int.Parse(entry[i-1]);
                    string material = entry[i];
                    if (keymaterials.ContainsKey(material))
                    {
                        keymaterials[material] += quantity;
                        if (keymaterials[material] >= 250)
                        {
                            keymaterials[material] -= 250;
                            winner = material;
                            end = false;
                            break;

                        }
                    }
                    else
                    {
                        if (!dictionary.ContainsKey(material))
                        {
                            dictionary.Add(material, quantity);
                        }
                        else
                        {
                            dictionary[material] += quantity;
                        }
                    }
                    
                }      
            }
            WinnerChecker(winner);        
            foreach (var keyMaterial  in keymaterials.OrderByDescending(s=>s.Value).ThenBy(s=>s.Key))
            {
                Console.WriteLine($"{keyMaterial.Key}: {keyMaterial.Value}");
            }
            foreach (var material in dictionary.OrderBy(s => s.Key))
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }
        }

        static void WinnerChecker(string winner)
        {
            if(winner=="shards")
            {
                winner = "Shadowmourne obtained!";
            }
            else if (winner == "fragments")
            {
                winner = "Valanyr obtained!";
            }
            else
            {
                winner = "Dragonwrath obtained!";
            }
            Console.WriteLine(winner);
        }
    }
}
