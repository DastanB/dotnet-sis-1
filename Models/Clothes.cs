using System;

namespace firstApp.Models{
    public class Clothe : Product{
        public Clothe(int cost, string name, string _material, string _color) : base(cost, name){
            this.Material = _material;
            this.Color = _color;
        }

        public string Material { get; set; }
        public string Color { get; set; }
    

    }
}