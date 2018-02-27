using System;
using System.Collections.Generic;

namespace firstApp.Models
{
    class Program
    {
        static void Main(string[] args)
        {
            Food pro1 = new Food(150, "Cola", "drinks", 500);
            Clothe pro2 = new Clothe(40000, "jeans", "cotton", "dark-blue");
            Device pro3 = new Device(300000, "HP Pavillion", 2);
            Household pro4 = new Household(900, "Fairy", "washing");

            Order order1 = new Order();
            order1.OrderNumber = 1;
            order1.Products = new List<Product>();
            order1.Products.Add(pro1);
            order1.Products.Add(pro3);      

            Order order2 = new Order();
            order2.OrderNumber = 2;
            order2.Products = new List<Product>();
            order2.Products.Add(pro3);           

            List<Product> products = new List<Product>();
            products.Add(pro1);
            products.Add(pro2);
            products.Add(pro3);
            products.Add(pro4);

            Console.WriteLine("All products");

            for(int i = 0; i < products.Count; i++)
            {
                var prod = products[i];

                int k = 0;

                k++;

                Console.WriteLine("Prod: " + prod.Name + "; Count: " + k);
            }

            Console.WriteLine("All purchased products");

            for(int i = 0; i < products.Count; i++)
            {
                var prod = products[i];

                int k = 0;

                if(order1.Products.Contains(prod))
                    k++;
                
                if(order2.Products.Contains(prod))
                    k++;

                Console.WriteLine("Prod: " + prod.Name + "; Count: " + k);
            }

            Console.WriteLine("total price of market");
            int s = 0;
            for(int i = 0; i < products.Count; i++)
            {
                var prod = products[i];

                s = s + prod.Cost;
            }
            Console.WriteLine(s);
        }
    }
}