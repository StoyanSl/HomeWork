using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8th
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int n = int.Parse(Console.ReadLine());
            string ingredient = "";
            for (int i = 0; i < n; i++)
            {
                ingredient = Console.ReadLine();
                switch (ingredient.ToLower())
                {
                    case "cheese":sum = sum + 500;
                        break;
                    case "salami":
                        sum = sum + 600;
                        break;
                    case "pepper":
                        sum = sum + 50;
                        break;
                    case "tomato sauce":
                        sum = sum + 150;
                        break;
                    default: break;
                }
            }
            Console.WriteLine("Total calories: {0}",sum);
        }
    }
}
