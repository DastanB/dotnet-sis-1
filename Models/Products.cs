using System;

namespace firstApp.Models{
    public class Product{

        public Product(int cost, string name){
            this.Cost = cost;
            this.Name = name;
        }
        public int Cost { get; set; }
        public string  Name { get; set; }
    }
}