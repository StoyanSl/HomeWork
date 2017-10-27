using System;
using System.Collections.Generic;
using System.Linq;


namespace _07.Sales_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Sale[] sales=new Sale[n];
            for (int i = 0; i < n; i++)
            {
                sales[i] = SalesReader();
            }
            SortedDictionary<string,double>resultDictionary=new SortedDictionary<string,double>();
            foreach (var name in sales)
            {
                if (!resultDictionary.ContainsKey(name.town))
                {
                    resultDictionary.Add(name.town,summingResult(sales,name.town));
                }
               
            }
            foreach (var town in resultDictionary)
            {
                Console.WriteLine("{0} -> {1:f2}",town.Key,town.Value);
            }
        }

        static double summingResult(Sale[] sales,string name)
        {
            double sum = 0;
            foreach (var product in sales)
            {
                if (product.town==name)
                {
                    sum += product.price * product.quantity;
                }
            }
            return sum;
        }
        static Sale SalesReader()
        {
            Sale saleN=new Sale();
            var input = Console.ReadLine().Split(' ').ToList();
            saleN.town = input[0];
            saleN.product = input[1];
            saleN.price = double.Parse(input[2]);
            saleN.quantity = double.Parse(input[3]);
            return saleN;
        }
        class Sale
        {
            public string town { get; set; }
            public string product { get; set; }
            public double price { get; set; }
            public double quantity { get; set; }
        }
    }
}
