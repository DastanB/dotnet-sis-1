using System;

namespace firstApp.Models{
    public class Food: Product{

        public Food(int cost, string name, string type, double weight): base(cost, name){
            this.Type = type;
            this.Weight = weight;
        }
        public string Type { get; set; }
        public double Weight { get; set; }
    }
}