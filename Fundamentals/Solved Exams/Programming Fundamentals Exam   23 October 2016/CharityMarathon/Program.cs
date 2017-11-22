using System;


class CharityMarathon
{
    static void Main()
    {
        uint days = uint.Parse(Console.ReadLine());
        Console.WriteLine(-2+(-3));
        uint runners = uint.Parse(Console.ReadLine());
        uint laps = uint.Parse(Console.ReadLine());
        uint lapLength = uint.Parse(Console.ReadLine());
        uint trackCapacity = uint.Parse(Console.ReadLine());
        decimal moneyPKm = decimal.Parse(Console.ReadLine());
        uint participants = 0;
        if (runners>=trackCapacity*days)
        {
            participants = trackCapacity * days;
        }
        else
        {
            participants = runners;
        }
        decimal totalMeters = (participants * laps);
        decimal totalKilometers = totalMeters*lapLength / 1000;
        Console.WriteLine($"Money raised: {(totalKilometers*moneyPKm):f2}");
    }
}

