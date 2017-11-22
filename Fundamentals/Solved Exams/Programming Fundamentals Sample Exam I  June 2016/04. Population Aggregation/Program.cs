using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class Program
{
    const string pattern = @"([^@#$\\&0-9])";
    static void Main()
    {
        SortedDictionary<string, int> CountryDictionary = new SortedDictionary<string, int>();
        Dictionary<string, ulong> CityDictionary = new Dictionary<string, ulong>();
        while (true)
        {
            var rawInput = Console.ReadLine();
            if (rawInput == "stop")
            {
                break;
            }
            var input = rawInput.Split('\\').ToList();
            RemovingTheSymbols(input);
            CountryCityValidation(input);
            var country = input[0];
            var town = input[1];
            ulong population = ulong.Parse(input[2]);
            FillingDictionaries(CountryDictionary, CityDictionary, country, town, population);
        }
        PrintingOutput(CountryDictionary, CityDictionary);
    }

     static void FillingDictionaries(SortedDictionary<string, int> CountryDictionary, Dictionary<string, ulong> CityDictionary, string country, string town, ulong population)
    {
        if (!CountryDictionary.ContainsKey(country))
        {
            CountryDictionary.Add(country, 0);
        }
        CountryDictionary[country]++;
        if (!CityDictionary.ContainsKey(town))
        {
            CityDictionary.Add(town, 0);
        }
        CityDictionary[town] = population;
    }

     static void PrintingOutput(SortedDictionary<string, int> CountryDictionary, Dictionary<string, ulong> CityDictionary)
    {
        foreach (var country in CountryDictionary)
        {
            Console.WriteLine($"{country.Key} -> {country.Value}");
        }
        int counter = 0;
        foreach (var town in CityDictionary.OrderByDescending(s => s.Value))
        {
            if (counter < 3)
            {
                Console.WriteLine($"{town.Key} -> {town.Value}");
            }
            counter++;

        }
    }

    static void CountryCityValidation(List<string> input)
    {
        if (!(input[0][0] >= 'A' && input[0][0] <= 'Z'))
        {
            var swap = input[0];
            input[0] = input[1];
            input[1] = swap;
        }
    }

     static void RemovingTheSymbols(List<string> rawInput)
    {
        for (int i = 0; i < 2; i++)
        {
            var matches = Regex.Matches(rawInput[i], pattern);
            var replace = matches.Cast<Match>().Select(a => a.Value.Trim()).ToList();
            rawInput[i] = string.Join("", replace);
        }
    }
}

