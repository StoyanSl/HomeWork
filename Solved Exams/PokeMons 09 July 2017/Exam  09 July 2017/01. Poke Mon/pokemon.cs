using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Poke_Mon
{
   public class pokemon
    {
        public static void Main()
        {
            long pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustion = int.Parse(Console.ReadLine());
            short counter = 0;
            decimal half = pokePower / 2;
            while (true)
            {
                if (pokePower<distance)
                {
                    break;
                }
                pokePower -= distance;
                counter++;
                if (exhaustion!=0)
                {
                    if (pokePower == half)
                    {
                        pokePower = pokePower / exhaustion;
                    }
                }
           
            }
            Console.WriteLine(pokePower);
            Console.WriteLine(counter);
        }
    }
}
