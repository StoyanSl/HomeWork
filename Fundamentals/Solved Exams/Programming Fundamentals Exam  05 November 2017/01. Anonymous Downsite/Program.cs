using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01.Anonymous_Downsite
{
    class Program
    {
        static void Main()
        {
            int numberOfWebsites = int.Parse(Console.ReadLine());
            ulong securityKey = ulong.Parse(Console.ReadLine());         
            decimal totalLoss = 0m;
            for (int i = 0; i <numberOfWebsites; i++)
            {
                var website = Console.ReadLine().Split(' ').ToList();
                string siteName = website[0];
                decimal siteVisits = decimal.Parse(website[1]);
                decimal siteCommercialPricePerVisit = decimal.Parse(website[2]);
                decimal siteLoss = siteVisits * siteCommercialPricePerVisit;// ako ne stava test s decimal na siteVisits
                totalLoss += siteLoss;
                Console.WriteLine(siteName);
               
            }
            BigInteger securityToken = BigInteger.Pow(securityKey, numberOfWebsites);
            Console.WriteLine($"Total Loss: {totalLoss:f20}");
            Console.WriteLine($"Security Token: {securityToken}");
        }
    }
}
