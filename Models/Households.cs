using System;

namespace firstApp.Models{
    public class Household : Product {
        public Household(int cost, string name, string type): base(cost, name){
            this.Type = type;
        }
        public string Type { get; set; }
    }
}