using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        decimal cash = decimal.Parse(Console.ReadLine());
        int numberOfGuests = int.Parse(Console.ReadLine());
        decimal bananasPrice = decimal.Parse(Console.ReadLine());
        decimal eggsPrice = decimal.Parse(Console.ReadLine());
        decimal berriesPricePK = decimal.Parse(Console.ReadLine());
        int sets = 0;
        while (numberOfGuests%6!=0)
        {
            numberOfGuests++;
        }
        sets = numberOfGuests / 6;
        decimal requiredMoney = sets * (2 * bananasPrice) + sets * (4 * eggsPrice) + sets * (0.2m * berriesPricePK);
        if (cash>=requiredMoney)
        {
            Console.WriteLine($"Ivancho has enough money - it would cost {cash=requiredMoney:f2}lv. ");
        }
        else
        {
            Console.WriteLine($"Ivancho will have to withdraw money - he will need {requiredMoney-cash:f2}lv more. ");
        }
    }
}

