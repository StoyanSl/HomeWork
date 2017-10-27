using System;
using System.Collections.Generic;
using System.Linq;
namespace _9.Legendary_Farming
{
    class Program
    {
        static void Main()
        {
            var dictionary=new Dictionary<string,int>();
            dictionary.Add("shards", 0);
            dictionary.Add("fragments", 0);
            dictionary.Add("motes", 0);
            bool loop = true;
            string winner = "";
            while(loop)
            {
                var entry = Console.ReadLine().ToLower().Split().ToList();
                
                for (int i = 1; i < entry.Count; i += 2)
                {
                    if (!dictionary.ContainsKey(entry[i]))
                    {
                        dictionary.Add(entry[i], int.Parse(entry[i - 1]));
                        if (dictionary["shards"] >= 250)
                        {
                            winner = "Shadowmourne obtained!";
                            dictionary["shards"] -= 250;
                            loop = false;
                            break;
                            

                        }
                        if (dictionary["fragments"] >= 250)
                        {
                            winner = "Valanyr obtained!";
                            dictionary["fragments"] -= 250;
                            loop = false;
                            break;
                            
                        }
                        if (dictionary["motes"] >= 250)
                        {
                            winner = "Dragonwrath obtained!";
                            dictionary["motes"] -= 250;
                            loop = false;
                            break;
                            
                        }
                    }
                    else
                    {
                        dictionary[entry[i]] += int.Parse(entry[i - 1]);
                        if (dictionary["shards"] >= 250)
                        {
                            winner = "Shadowmourne obtained!";
                            dictionary["shards"] -= 250;
                            loop = false;
                            break;
                          
                        }
                        if (dictionary["fragments"] >= 250)
                        {
                            winner = "Valanyr obtained!";
                            dictionary["fragments"] -= 250;
                            loop = false;
                            break;
                            
                        }
                        if (dictionary["motes"] >= 250)
                        {
                            winner = "Dragonwrath obtained!";
                            dictionary["motes"] -= 250;
                            loop = false;
                            break;
                           
                        }

                    }
                   
                }
                if (loop==false)
                {
                    break;
                }
            }

            
            var keyMaterials = dictionary.ToList();
            keyMaterials.RemoveRange(3,keyMaterials.Count-3);
            Console.WriteLine(winner);
            foreach (var material in keyMaterials.OrderByDescending(s=>s.Value).ThenBy(s=>s.Key))
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }
            foreach (var item in dictionary.OrderBy(s => s.Key))
            {
                if (item.Key!="motes"&&item.Key!="shards"&&item.Key!="fragments")
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
               
            }
        }
        
}
}
