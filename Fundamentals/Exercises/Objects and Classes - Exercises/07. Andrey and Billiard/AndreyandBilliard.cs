using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Andrey_and_Billiard
{
    class AndreyandBilliard
    {
        static void Main(string[] args)
        {
            decimal sum = 0;
            int n = int.Parse(Console.ReadLine());
            var shopPriceList=new Dictionary<string,decimal>();
            for (int i = 0; i < n; i++)
            {
                var productsEntry = Console.ReadLine().Split('-').ToList();
                var nameOfProduct = productsEntry[0];
                var productPrice = decimal.Parse(productsEntry[1]);
                if (!shopPriceList.ContainsKey(nameOfProduct))
                {
                    shopPriceList.Add(nameOfProduct,productPrice);
                }
                else
                {
                    shopPriceList[nameOfProduct] = productPrice;
                }
            }
            List<Customer> customers=new List<Customer>();
            
            var customerEntry = Console.ReadLine().Split('-', ',').ToList();
            while (customerEntry[0]!="end of clients")
            {
                var name = customerEntry[0];
                var productName = customerEntry[1];
                var quantity =int.Parse(customerEntry[2]);
                if (shopPriceList.ContainsKey(productName))
                {
                    Customer cstm = new Customer();
                    cstm.name = name;
                   cstm.shopList=new Dictionary<string, int>();
                    cstm.shopList.Add(productName,quantity);                  
                   
                    if (customers.Any(s=>s.name==name))
                    {
                        Customer existingCstm=customers.First(s=>s.name==name);
                        if (existingCstm.shopList.ContainsKey(productName))
                        {
                            existingCstm.shopList[productName] += quantity;
                        }
                        else
                        {
                            existingCstm.shopList.Add(productName,quantity);
                        }
                    }
                    else
                    {
                        customers.Add(cstm);
                    }
                }
                customerEntry = Console.ReadLine().Split('-', ',').ToList();
            }
            foreach (var customer in customers)
            {
                foreach (var item in customer.shopList)
                {
                    customer.bill += item.Value * shopPriceList[item.Key];
                }
            }
            foreach (var customer in customers.OrderBy(s=>s.name))
            {
                string pname = customer.productname;
                Console.WriteLine(customer.name);
                foreach (var item in customer.shopList)
                {
                    Console.WriteLine($"-- {item.Key} - {item.Value}");
                }
              
                Console.WriteLine($"Bill: {customer.bill:f2}");
                sum += customer.bill;
            }
            Console.WriteLine($"Total bill: {sum:f2}");
        }
    }

    class Customer
    {
        public string name { get; set; }
        public Dictionary<string, int> shopList { get; set; }
        public decimal bill { get; set; }
        public string productname { get; set; }
    }
}
