using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstVar = "Hello";
            string secondVar = "World";
            object concatenation = firstVar + " " + secondVar;
            string objectValue = (string)(concatenation);
            Console.WriteLine(objectValue);
        }
    }
}
