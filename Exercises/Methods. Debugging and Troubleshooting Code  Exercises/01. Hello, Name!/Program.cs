using System;


namespace Hello__Name_
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameInput = Console.ReadLine();
            Name(nameInput);
        }
        static void Name(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
