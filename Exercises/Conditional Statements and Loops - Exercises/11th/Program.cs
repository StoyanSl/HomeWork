using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11th
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            var difference = b - a;

            if (difference < 5)
            {
                Console.WriteLine("No");
            }
            for (int i = a; i < b; i++)
            {
                for (int k = a; k < b; k++)
                {
                    for (int n2 = a; n2 < b; n2++)
                    {
                        for (int n3 = a; n3 < b; n3++)
                        {
                            for (int n4 = a; n4 <= b; n4++)
                            {

                                if (a <= i && i < k && k < n2 && n2 < n3 && n3 < n4 && n4 <= b)
                                {
                                    Console.WriteLine("{0} {1} {2} {3} {4}",i,k,n2,n3,n4);
                                }

                            }
                        }
                    }

                }

            }
        }
    }
}
