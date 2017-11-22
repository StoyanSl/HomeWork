using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class NetherRealms
{
    const string pattern = @"((-[0-9]+\.[0-9]+)|([0-9]+\.[0-9]+)|([0-9]+)|(-[0-9]+))";
    static void Main()
    {
       List<Tuple<string,string>> outputList=new List<Tuple<string, string>>();
        var DemonsNames = Console.ReadLine().Split(',').Select(s => s.Trim(' ')).ToList();
        foreach (var demon in DemonsNames)
        {
            string demonName = demon;
            long health = 0;
            health = CalculatingHealth(demonName, health);
            double dmg =0;
            dmg = CalculatingTheDmg(demonName, dmg);
          outputList.Add(Tuple.Create(demonName,$" - {health} health, {dmg:f2} damage"));

        }
        foreach (var tuple in outputList.OrderBy(s=>s.Item1))
        {
            
            Console.WriteLine(string.Join("",tuple.Item1,tuple.Item2));
        }
    }

     static double CalculatingTheDmg(string demonName, double dmg)
    {
        var matches = Regex.Matches(demonName, pattern);
        int slashcounter = 0;
        int starscounter = 0;
        foreach (Match match in matches)
        {
            dmg += double.Parse(match.Value);
        }
        for (int i = 0; i < demonName.Length; i++)
        {
            char sign = demonName[i];
            if (sign == '/')
            {
                slashcounter++;
            }
            if (sign=='*')
            {
                starscounter++;
            }
        }
        for (int i = 0; i < slashcounter; i++)
        {
            dmg = dmg / 2;
        }
        for (int i = 0; i < starscounter; i++)
        {
            dmg = dmg * 2;
        }
        return dmg;
    }

    private static long CalculatingHealth(string demonName, long health)
    {
        for (int i = 0; i < demonName.Length; i++)
        {
            char sign = demonName[i];
            if (! (sign>='0'&&sign<='9') && sign != '+' && sign != '-' && sign != '*' && sign != '/' && sign != '.')
            {
                health += (int) sign;
            }
        }

        return health;
    }
}

