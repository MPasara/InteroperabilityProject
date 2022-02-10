using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Soap.Models
{
    public class Motorcycle
    {
        public string Make { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Power { get; set; }
        public double Weight { get; set; }

        //Needed for serialization
        public Motorcycle() { } 

        public Motorcycle(string make, string name, string type, int power, double weight)
        {
            Make = make;
            Name = name;
            Type = type;
            Power = power;
            Weight = weight;
        }
    }
}