using System;
using System.Collections.Generic;
using System.Linq;

class Endurance_Rally
{
    static void Main()
    {
        var drivers = Console.ReadLine().Split(' ').ToList();
        List<double> zones = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
        List<Int64> indexes = Console.ReadLine().Split(' ').Select(Int64.Parse).ToList();
        List<string> outputList=new List<string>();
        for (int i = 0; i < drivers.Count; i++)
        {
            int firstLetterOfDriverName = drivers[i][0];
            double driverFuel = double.Parse(firstLetterOfDriverName.ToString());
            var result= FindingTheResult(zones, indexes, driverFuel).Split(' ').ToList();
            outputList.Add( FormatingTheResult(result,  drivers[i]));
        }
        Console.WriteLine(string.Join("\n", outputList));
    }

    static string FormatingTheResult(List<string>result,string driver)
    {
        if (result[0] == "finisher")
        {
            return $"{driver} - fuel left {double.Parse(result[1]):f2}";
        }
        else 
        {
            return $"{driver} - reached {result[1]}";
        }
    }
    static string FindingTheResult(List<double> zones, List<Int64> indexes, double driverFuel)
    {
        var counter = 0;
        bool flag = false;
        for (int j = 0; j < zones.Count; j++)
        {
            if (indexes.Contains(j))
            {
                driverFuel += zones[j];
            }
            else
            {
                driverFuel -= zones[j];
                if (driverFuel<=0)
                {
                    flag = true;
                    counter = j;
                    break;                  
                }
            }
        }
        if (flag)
        {
            return $"notfinisher {counter}";
        }
        else
        {
            return $"finisher {driverFuel}";
        }
    }
    
}

