using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15th
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int flag = 0;
            int pDmg = int.Parse(Console.ReadLine());
            int gDmg = int.Parse(Console.ReadLine());
            int pHealth = 100;
            int gHealth = 100;
         
            while ((gHealth > 0 && gHealth <= 1000) && (pHealth > 0 && pHealth <= 1000))
            {
                if (i % 2 != 0)
                   {
                    gHealth = gHealth - pDmg;
                    if (gHealth > 0)
                    {
                        Console.WriteLine("Pesho used Roundhouse kick and reduced Gosho to {0} health.", gHealth);
                    }
                    else
                    {
                        flag=flag+1;
                        break;
                    }
                   }
                else if (i % 2 == 0)
                   {
                    pHealth = pHealth - gDmg;
                    if (pHealth > 0)
                    {
                        Console.WriteLine("Gosho used Thunderous fist and reduced Pesho to {0} health.", pHealth);
                    }
                    else
                    {
                        flag=flag+1;
                        break;
                    }
                   }
                if (i % 3 == 0)
                {
                    pHealth += 10;
                    gHealth += 10;
                }
                i++;
            }

            if (flag == 1)
            {
                if (gHealth > pHealth)
                {
                    Console.WriteLine(" Gosho won in {0}th round.", i);
                }
                else
                {
                    Console.WriteLine(" Pesho won in {0}th round.", i);
                }
            }
        }
    }
}
