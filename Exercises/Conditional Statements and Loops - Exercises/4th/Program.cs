using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4th
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nCount = int.Parse(Console.ReadLine());
            if (nCount < 7)
            {
                switch (month)
                {
                    case "May":
                        Console.WriteLine("Studio: {0:f2} lv.",50*nCount);
                        Console.WriteLine("Double: {0:f2} lv.", 65 * nCount);
                        Console.WriteLine("Suite: {0:f2} lv.", 75 * nCount);
                        break;
                    case "October":
                        Console.WriteLine("Studio: {0:f2} lv.", 50 * nCount);
                        Console.WriteLine("Double: {0:f2} lv.", 65 * nCount);
                        Console.WriteLine("Suite: {0:f2} lv.", 75 * nCount);
                        break;
                    case "June":
                        Console.WriteLine("Studio: {0:f2} lv.", 60 * nCount);
                        Console.WriteLine("Double: {0:f2} lv.", 72 * nCount);
                        Console.WriteLine("Suite: {0:f2} lv.", 82 * nCount);
                        break;
                    case "September":
                        Console.WriteLine("Studio: {0:f2} lv.", 60 * nCount);
                        Console.WriteLine("Double: {0:f2} lv.", 72 * nCount);
                        Console.WriteLine("Suite: {0:f2} lv.", 82 * nCount);
                        break;
                    case "July":
                        Console.WriteLine("Studio: {0:f2} lv.", 68 * nCount);
                        Console.WriteLine("Double: {0:f2} lv.", 77 * nCount);
                        Console.WriteLine("Suite: {0:f2} lv.", 89 * nCount);
                        break;
                    case "August":
                        Console.WriteLine("Studio: {0:f2} lv.", 68 * nCount);
                        Console.WriteLine("Double: {0:f2} lv.", 77 * nCount);
                        Console.WriteLine("Suite: {0:f2} lv.", 89 * nCount);
                        break;
                    case "December":
                        Console.WriteLine("Studio: {0:f2} lv.", 68 * nCount);
                        Console.WriteLine("Double: {0:f2} lv.", 77 * nCount);
                        Console.WriteLine("Suite: {0:f2} lv.", 89 * nCount);
                        break;
                }

            }
            else if(nCount>7&&nCount<=14)
            {
                switch (month)
                {
                    case "May":
                        Console.WriteLine("Studio: {0:f2} lv.", 50 * nCount*0.95);
                        Console.WriteLine("Double: {0:f2} lv.", 65 * nCount);
                        Console.WriteLine("Suite: {0:f2} lv.", 75 * nCount);
                        break;
                    case "October":
                        Console.WriteLine("Studio: {0:f2} lv.", (50 * nCount-50)*0.95);
                        Console.WriteLine("Double: {0:f2} lv.", 65 * nCount);
                        Console.WriteLine("Suite: {0:f2} lv.", 75 * nCount);
                        break;
                    case "June":
                        Console.WriteLine("Studio: {0:f2} lv.", 60 * nCount);
                        Console.WriteLine("Double: {0:f2} lv.", 72 * nCount);
                        Console.WriteLine("Suite: {0:f2} lv.", 82 * nCount);
                        break;
                    case "September":
                        Console.WriteLine("Studio: {0:f2} lv.", 60 * nCount-60);
                        Console.WriteLine("Double: {0:f2} lv.", 72 * nCount);
                        Console.WriteLine("Suite: {0:f2} lv.", 82 * nCount);
                        break;
                    case "July":
                        Console.WriteLine("Studio: {0:f2} lv.", 68 * nCount);
                        Console.WriteLine("Double: {0:f2} lv.", 77 * nCount);
                        Console.WriteLine("Suite: {0:f2} lv.", 89 * nCount);
                        break;
                    case "August":
                        Console.WriteLine("Studio: {0:f2} lv.", 68 * nCount);
                        Console.WriteLine("Double: {0:f2} lv.", 77 * nCount);
                        Console.WriteLine("Suite: {0:f2} lv.", 89 * nCount);
                        break;
                    case "December":
                        Console.WriteLine("Studio: {0:f2} lv.", 68 * nCount);
                        Console.WriteLine("Double: {0:f2} lv.", 77 * nCount);
                        Console.WriteLine("Suite: {0:f2} lv.", 89 * nCount);
                        break;
                }
            }
            else
            {
                switch (month)
                {
                    case "May":
                        Console.WriteLine("Studio: {0:f2} lv.", 50 * nCount);
                        Console.WriteLine("Double: {0:f2} lv.", 65 * nCount);
                        Console.WriteLine("Suite: {0:f2} lv.", 75 * nCount);
                        break;
                    case "October":
                        Console.WriteLine("Studio: {0:f2} lv.", 50 * nCount);
                        Console.WriteLine("Double: {0:f2} lv.", 65 * nCount);
                        Console.WriteLine("Suite: {0:f2} lv.", 75 * nCount);
                        break;
                    case "June":
                        Console.WriteLine("Studio: {0:f2} lv.", 60 * nCount);
                        Console.WriteLine("Double: {0:f2} lv.", 72 * nCount*0.9);
                        Console.WriteLine("Suite: {0:f2} lv.", 82 * nCount);
                        break;
                    case "September":
                        Console.WriteLine("Studio: {0:f2} lv.", 60 * nCount);
                        Console.WriteLine("Double: {0:f2} lv.", 72 * nCount*0.9);
                        Console.WriteLine("Suite: {0:f2} lv.", 82 * nCount);
                        break;
                    case "July":
                        Console.WriteLine("Studio: {0:f2} lv.", 68 * nCount);
                        Console.WriteLine("Double: {0:f2} lv.", 77 * nCount);
                        Console.WriteLine("Suite: {0:f2} lv.", 89 * nCount*0.85);
                        break;
                    case "August":
                        Console.WriteLine("Studio: {0:f2} lv.", 68 * nCount);
                        Console.WriteLine("Double: {0:f2} lv.", 77 * nCount);
                        Console.WriteLine("Suite: {0:f2} lv.", 89 * nCount*0.85);
                        break;
                    case "December":
                        Console.WriteLine("Studio: {0:f2} lv.", 68 * nCount);
                        Console.WriteLine("Double: {0:f2} lv.", 77 * nCount);
                        Console.WriteLine("Suite: {0:f2} lv.", 89 * nCount*0.85);
                        break;
                }
            }
        }
    }
}
