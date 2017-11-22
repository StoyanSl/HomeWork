using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            byte aged = byte.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            string personalId = Console.ReadLine();
            string eNumber = Console.ReadLine();
            Console.WriteLine("First name: "+firstName);
            Console.WriteLine("Last name: "+lastName);
            Console.WriteLine("Age: "+aged);
            Console.WriteLine("Gender: "+gender);
            Console.WriteLine("Personal ID: "+personalId);
            Console.WriteLine("Unique Employee number: "+eNumber);

            
        }
    }
}
