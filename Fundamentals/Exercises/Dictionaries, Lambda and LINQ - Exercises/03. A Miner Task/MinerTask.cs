using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.A_Miner_Task
{
    class MinerTask
    {
        static void Main(string[] args)
        {
            var resources=new Dictionary<string,long>();
            for (int i = 1;; i++)
            {
                var input =Console.ReadLine();
                if (input.Equals("stop"))
                {
                    break;
                }
                long quantity = long.Parse(Console.ReadLine());
                if (!resources.Keys.Contains(input))
                {
                    resources.Add(input,0);

                }
                resources[input] += quantity;
            }
            foreach (var resource in resources)
            {
                Console.WriteLine("{0} -> {1}",resource.Key,resource.Value);
            }
        }
    }
}
