using System;

namespace firstApp.Models{
    public class Device : Product{
        public Device(int cost, string name, double weight) : base(cost, name){
            
            this.Weight = weight;
            
        }
        public double Weight { get; set; }

    }
}