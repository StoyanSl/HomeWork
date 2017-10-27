using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hornet_Assault
{
    class Program
    {
        static void Main()
        {
            var beehives = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            var hornets = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            long hornetsPowerSum = hornets.Sum();
            for (int i = 0; i < beehives.Count; i++)
            {
                beehives[i] -= hornetsPowerSum;

                if (hornets.Count == 0)
                {
                    break;
                }
                if (beehives[i] >= 0)
                {
                    hornetsPowerSum -= hornets[0];
                    hornets.RemoveAt(0);
                }
            }     
            if (beehives.Any(x => x > 0))
            {
                foreach (var beehive in beehives)
                {
                    if (beehive > 0)
                    {
                        Console.Write(beehive + " ");
                    }
                }
            }
            else
            {
                foreach (var hornet in hornets)
                {
                    Console.Write(hornet + " ");
                }
            }
        }
    }
}
