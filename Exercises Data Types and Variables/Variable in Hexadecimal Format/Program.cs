﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable_in_Hexadecimal_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int substring = Convert.ToInt32(number, 16);
            Console.WriteLine(substring);
          
        }
    }
}
