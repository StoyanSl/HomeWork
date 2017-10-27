using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var entry = Console.ReadLine().Split('|').ToList();
            var countries  = new Dictionary<string,  List<string>>();
            var cityData=new Dictionary<string,long>();
            var totalPop=new Dictionary<string,long>();
            while (entry[0]!="report")
            {
                if (!countries.ContainsKey(entry[1]))
                {
                    countries.Add(entry[1],new List<string>());
                }
                if (!cityData.ContainsKey(entry[0]))
                {
                    cityData.Add(entry[0],0);
                }
                if (!totalPop.ContainsKey(entry[1]))
                {
                    totalPop.Add(entry[1],0);
                }
               countries[entry[1]].Add(entry[0]);
                cityData[entry[0]] = long.Parse(entry[2]);
                totalPop[entry[1]] += long.Parse(entry[2]);
                entry = Console.ReadLine().Split('|').ToList();
            }
            var countryTotalPop = totalPop.OrderByDescending(pair => pair.Value).ToList();
            foreach (var country in countryTotalPop)
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value})");
                var listOfCities = cityData.OrderByDescending(pair => pair.Value).ToList();
                foreach (var allCities in listOfCities)
                {
                    string cmpCity = allCities.Key;
                    foreach (var city in countries[country.Key])
                    {
                        if (city==cmpCity)
                        {
                            Console.WriteLine($"=>{city}: {cityData[city]}");
                        }                      
                    }  
                }
            }
        }
    }
}
