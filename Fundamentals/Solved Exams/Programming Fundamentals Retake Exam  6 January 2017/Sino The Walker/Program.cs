using System;

using System.Globalization;


class Sino_The_Walker
{
    static void Main()
    {
        TimeSpan time = TimeSpan.ParseExact(Console.ReadLine(), "hh\\:mm\\:ss", CultureInfo.InvariantCulture);
        long steps = long.Parse(Console.ReadLine()) % (3600 * 24);
        long secondsPerStep = long.Parse(Console.ReadLine()) % (3600 * 24);
        long totalTime = steps * secondsPerStep;
        TimeSpan totalSeconds=TimeSpan.FromSeconds(totalTime);
        TimeSpan output= time.Add(totalSeconds);
        Console.WriteLine("Time Arrival: {0:hh\\:mm\\:ss}",output);
    }
}

